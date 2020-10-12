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
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void submit_Click(object sender, EventArgs e)
        {
            long buyPrice;
            int qtyDoubled;
            try
            {
                buyPrice = long.Parse(tbBuyPrice.Text);
                qtyDoubled = int.Parse(tbQuantity.Text) * 2;
                double totalBuyPrice, totalBroker, corpWallet, clearPrice;
                MarginCalc(qtyDoubled, buyPrice, out totalBuyPrice, out totalBroker);
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
        static void MarginCalc(int buyDoubled, long buyPrice, out double totalBuyPrice, out double totalBroker)
        {
            double brokerFee = .044;
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
    }
}
