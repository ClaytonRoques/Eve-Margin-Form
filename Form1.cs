using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eve_Margin_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            tbJita.Text = Properties.Settings.Default.jitaBroker.ToString();
            tbAmarr.Text = Properties.Settings.Default.amarrBroker.ToString();
            tbRens.Text = Properties.Settings.Default.rensBroker.ToString();
            tbHek.Text = Properties.Settings.Default.hekBroker.ToString();
            tbDefault.Text = Properties.Settings.Default.defaultBroker.ToString();
        }
        private void submit_Click(object sender, EventArgs e)
        {
            long buyPrice;
            int qtyDoubled;
            double totalBuyPrice, totalBroker, corpWallet, clearPrice, brokerFee;
            try
            {
                buyPrice = long.Parse(tbBuyPrice.Text);
                qtyDoubled = int.Parse(tbQuantity.Text) * 2;

                if (rbJita.Checked == true)
                {
                    brokerFee = double.Parse(tbJita.Text);
                }
                else if (rbAmarr.Checked == true)
                {
                    brokerFee = double.Parse(tbAmarr.Text);
                }
                else if (rbRens.Checked == true)
                {
                    brokerFee = double.Parse(tbRens.Text);
                }
                else if (rbHek.Checked == true)
                {
                    brokerFee = double.Parse(tbHek.Text);
                }
                else
                {
                    brokerFee = double.Parse(tbDefault.Text);
                }
                MarginCalc(brokerFee, qtyDoubled, buyPrice, out totalBuyPrice, out totalBroker);
                MarginWallet(totalBuyPrice, qtyDoubled, out corpWallet, out clearPrice);

                tbTotalBuyPrice.Text = totalBuyPrice.ToString("C");
                tbTotalBrokerFee.Text = totalBroker.ToString("C");
                tbTotalCorpWallet.Text = corpWallet.ToString("C");
                tbClearPrice.Text = clearPrice.ToString("C");
            }
            catch
            {
                MessageBox.Show("Error!");
            }
        }
        static void MarginCalc(double brokerFee, int buyDoubled, long buyPrice, out double totalBuyPrice, out double totalBroker)
        {
            totalBuyPrice = buyDoubled * buyPrice;
            totalBroker = totalBuyPrice * brokerFee;
            totalBuyPrice += totalBroker;
        }
        static void MarginWallet(double totalBuyPrice, int buyDoubled, out double corpWallet, out double clearPrice)
        {
            double escrowPercent = .24;
            corpWallet = totalBuyPrice * escrowPercent;
            clearPrice = corpWallet / (buyDoubled / 2);
        }
        private void save_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.jitaBroker = double.Parse(tbJita.Text);
            Properties.Settings.Default.amarrBroker = double.Parse(tbAmarr.Text);
            Properties.Settings.Default.rensBroker = double.Parse(tbRens.Text);
            Properties.Settings.Default.hekBroker = double.Parse(tbHek.Text);
            Properties.Settings.Default.defaultBroker = double.Parse(tbDefault.Text);
            Properties.Settings.Default.Save();
        }
    }
}
