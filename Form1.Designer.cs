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
            this.label1.TabIndex = 9;
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
            this.label2.TabIndex = 3;
            this.label2.Text = "Buy Price";
            // 
            // tbTotalBuyPrice
            // 
            this.tbTotalBuyPrice.Location = new System.Drawing.Point(342, 12);
            this.tbTotalBuyPrice.Name = "tbTotalBuyPrice";
            this.tbTotalBuyPrice.ReadOnly = true;
            this.tbTotalBuyPrice.Size = new System.Drawing.Size(121, 20);
            this.tbTotalBuyPrice.TabIndex = 4;
            this.tbTotalBuyPrice.TabStop = false;
            // 
            // tbClearPrice
            // 
            this.tbClearPrice.Location = new System.Drawing.Point(342, 90);
            this.tbClearPrice.Name = "tbClearPrice";
            this.tbClearPrice.ReadOnly = true;
            this.tbClearPrice.Size = new System.Drawing.Size(121, 20);
            this.tbClearPrice.TabIndex = 8;
            this.tbClearPrice.TabStop = false;
            // 
            // tbTotalBrokerFee
            // 
            this.tbTotalBrokerFee.Location = new System.Drawing.Point(342, 38);
            this.tbTotalBrokerFee.Name = "tbTotalBrokerFee";
            this.tbTotalBrokerFee.ReadOnly = true;
            this.tbTotalBrokerFee.Size = new System.Drawing.Size(121, 20);
            this.tbTotalBrokerFee.TabIndex = 6;
            this.tbTotalBrokerFee.TabStop = false;
            // 
            // tbTotalCorpWallet
            // 
            this.tbTotalCorpWallet.Location = new System.Drawing.Point(342, 64);
            this.tbTotalCorpWallet.Name = "tbTotalCorpWallet";
            this.tbTotalCorpWallet.ReadOnly = true;
            this.tbTotalCorpWallet.Size = new System.Drawing.Size(121, 20);
            this.tbTotalCorpWallet.TabIndex = 7;
            this.tbTotalCorpWallet.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(257, 15);
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
            this.label4.Location = new System.Drawing.Point(241, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Clear price per unit:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(221, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Required in corp wallet:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(254, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Total broker fee:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 116);
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
            this.MaximumSize = new System.Drawing.Size(500, 155);
            this.MinimumSize = new System.Drawing.Size(500, 155);
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
    }
}

