namespace Eve_Margin_Form
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbQuantity = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbBuyPrice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbTotalBuyPrice = new System.Windows.Forms.TextBox();
            this.tbClearPrice = new System.Windows.Forms.TextBox();
            this.tbTotalBrokerFee = new System.Windows.Forms.TextBox();
            this.tbTotalCorpWallet = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.submit = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.rbAmarr = new System.Windows.Forms.RadioButton();
            this.rbRens = new System.Windows.Forms.RadioButton();
            this.rbHek = new System.Windows.Forms.RadioButton();
            this.rbJita = new System.Windows.Forms.RadioButton();
            this.tbJita = new System.Windows.Forms.TextBox();
            this.tbAmarr = new System.Windows.Forms.TextBox();
            this.tbHek = new System.Windows.Forms.TextBox();
            this.tbRens = new System.Windows.Forms.TextBox();
            this.tbDefault = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbQuantity
            // 
            this.tbQuantity.Location = new System.Drawing.Point(64, 12);
            this.tbQuantity.Name = "tbQuantity";
            this.tbQuantity.Size = new System.Drawing.Size(100, 20);
            this.tbQuantity.TabIndex = 0;
            this.tbQuantity.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Quantity";
            // 
            // tbBuyPrice
            // 
            this.tbBuyPrice.Location = new System.Drawing.Point(64, 38);
            this.tbBuyPrice.Name = "tbBuyPrice";
            this.tbBuyPrice.Size = new System.Drawing.Size(100, 20);
            this.tbBuyPrice.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Buy Price";
            // 
            // tbTotalBuyPrice
            // 
            this.tbTotalBuyPrice.Location = new System.Drawing.Point(450, 12);
            this.tbTotalBuyPrice.Name = "tbTotalBuyPrice";
            this.tbTotalBuyPrice.ReadOnly = true;
            this.tbTotalBuyPrice.Size = new System.Drawing.Size(121, 20);
            this.tbTotalBuyPrice.TabIndex = 15;
            this.tbTotalBuyPrice.TabStop = false;
            // 
            // tbClearPrice
            // 
            this.tbClearPrice.Location = new System.Drawing.Point(450, 90);
            this.tbClearPrice.Name = "tbClearPrice";
            this.tbClearPrice.ReadOnly = true;
            this.tbClearPrice.Size = new System.Drawing.Size(121, 20);
            this.tbClearPrice.TabIndex = 8;
            this.tbClearPrice.TabStop = false;
            // 
            // tbTotalBrokerFee
            // 
            this.tbTotalBrokerFee.Location = new System.Drawing.Point(450, 38);
            this.tbTotalBrokerFee.Name = "tbTotalBrokerFee";
            this.tbTotalBrokerFee.ReadOnly = true;
            this.tbTotalBrokerFee.Size = new System.Drawing.Size(121, 20);
            this.tbTotalBrokerFee.TabIndex = 6;
            this.tbTotalBrokerFee.TabStop = false;
            // 
            // tbTotalCorpWallet
            // 
            this.tbTotalCorpWallet.Location = new System.Drawing.Point(450, 64);
            this.tbTotalCorpWallet.Name = "tbTotalCorpWallet";
            this.tbTotalCorpWallet.ReadOnly = true;
            this.tbTotalCorpWallet.Size = new System.Drawing.Size(121, 20);
            this.tbTotalCorpWallet.TabIndex = 7;
            this.tbTotalCorpWallet.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(365, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Total Buy Price:";
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(64, 64);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(100, 46);
            this.submit.TabIndex = 2;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(349, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Clear price per unit:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(329, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Required in corp wallet:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(362, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Total broker fee:";
            // 
            // rbAmarr
            // 
            this.rbAmarr.AutoSize = true;
            this.rbAmarr.Location = new System.Drawing.Point(175, 38);
            this.rbAmarr.Name = "rbAmarr";
            this.rbAmarr.Size = new System.Drawing.Size(52, 17);
            this.rbAmarr.TabIndex = 5;
            this.rbAmarr.TabStop = true;
            this.rbAmarr.Text = "Amarr";
            this.rbAmarr.UseVisualStyleBackColor = true;
            this.rbAmarr.CheckedChanged += new System.EventHandler(this.rbAmarr_CheckedChanged);
            // 
            // rbRens
            // 
            this.rbRens.AutoSize = true;
            this.rbRens.Location = new System.Drawing.Point(175, 61);
            this.rbRens.Name = "rbRens";
            this.rbRens.Size = new System.Drawing.Size(50, 17);
            this.rbRens.TabIndex = 11;
            this.rbRens.TabStop = true;
            this.rbRens.Text = "Rens";
            this.rbRens.UseVisualStyleBackColor = true;
            // 
            // rbHek
            // 
            this.rbHek.AutoSize = true;
            this.rbHek.Location = new System.Drawing.Point(175, 84);
            this.rbHek.Name = "rbHek";
            this.rbHek.Size = new System.Drawing.Size(45, 17);
            this.rbHek.TabIndex = 8;
            this.rbHek.TabStop = true;
            this.rbHek.Text = "Hek";
            this.rbHek.UseVisualStyleBackColor = true;
            // 
            // rbJita
            // 
            this.rbJita.AutoSize = true;
            this.rbJita.Location = new System.Drawing.Point(175, 15);
            this.rbJita.Name = "rbJita";
            this.rbJita.Size = new System.Drawing.Size(41, 17);
            this.rbJita.TabIndex = 3;
            this.rbJita.TabStop = true;
            this.rbJita.Text = "Jita";
            this.rbJita.UseVisualStyleBackColor = true;
            this.rbJita.CheckedChanged += new System.EventHandler(this.rbJita_CheckedChanged);
            // 
            // tbJita
            // 
            this.tbJita.Location = new System.Drawing.Point(234, 12);
            this.tbJita.Name = "tbJita";
            this.tbJita.Size = new System.Drawing.Size(44, 20);
            this.tbJita.TabIndex = 4;
            this.tbJita.TextChanged += new System.EventHandler(this.tbJita_TextChanged);
            // 
            // tbAmarr
            // 
            this.tbAmarr.Location = new System.Drawing.Point(234, 35);
            this.tbAmarr.Name = "tbAmarr";
            this.tbAmarr.Size = new System.Drawing.Size(45, 20);
            this.tbAmarr.TabIndex = 6;
            // 
            // tbHek
            // 
            this.tbHek.Location = new System.Drawing.Point(234, 80);
            this.tbHek.Name = "tbHek";
            this.tbHek.Size = new System.Drawing.Size(44, 20);
            this.tbHek.TabIndex = 10;
            // 
            // tbRens
            // 
            this.tbRens.Location = new System.Drawing.Point(234, 58);
            this.tbRens.Name = "tbRens";
            this.tbRens.Size = new System.Drawing.Size(45, 20);
            this.tbRens.TabIndex = 8;
            // 
            // tbDefault
            // 
            this.tbDefault.Location = new System.Drawing.Point(234, 106);
            this.tbDefault.Name = "tbDefault";
            this.tbDefault.Size = new System.Drawing.Size(44, 20);
            this.tbDefault.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(175, 109);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Default";
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(234, 132);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(44, 23);
            this.save.TabIndex = 12;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 157);
            this.Controls.Add(this.save);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbDefault);
            this.Controls.Add(this.tbRens);
            this.Controls.Add(this.tbHek);
            this.Controls.Add(this.tbAmarr);
            this.Controls.Add(this.tbJita);
            this.Controls.Add(this.rbJita);
            this.Controls.Add(this.rbHek);
            this.Controls.Add(this.rbRens);
            this.Controls.Add(this.rbAmarr);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbTotalCorpWallet);
            this.Controls.Add(this.tbTotalBrokerFee);
            this.Controls.Add(this.tbClearPrice);
            this.Controls.Add(this.tbTotalBuyPrice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbBuyPrice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbQuantity);
            this.Name = "Form1";
            this.Text = "Eve Margin Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbQuantity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbBuyPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbTotalBuyPrice;
        private System.Windows.Forms.TextBox tbClearPrice;
        private System.Windows.Forms.TextBox tbTotalBrokerFee;
        private System.Windows.Forms.TextBox tbTotalCorpWallet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rbAmarr;
        private System.Windows.Forms.RadioButton rbRens;
        private System.Windows.Forms.RadioButton rbHek;
        private System.Windows.Forms.RadioButton rbJita;
        private System.Windows.Forms.TextBox tbJita;
        private System.Windows.Forms.TextBox tbAmarr;
        private System.Windows.Forms.TextBox tbHek;
        private System.Windows.Forms.TextBox tbRens;
        private System.Windows.Forms.TextBox tbDefault;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button save;
    }
}

