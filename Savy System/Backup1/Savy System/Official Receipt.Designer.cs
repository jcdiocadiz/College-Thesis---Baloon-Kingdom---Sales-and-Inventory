namespace WindowsApplication1
{
    partial class frmOR
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
            this.components = new System.ComponentModel.Container();
            this.Okbtn = new System.Windows.Forms.Button();
            this.ORnumtxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.COFNumLbl = new System.Windows.Forms.Label();
            this.VatPerLbl = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.VATAmtLbl = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.ServChLbl = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.TotLbl = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label125 = new System.Windows.Forms.Label();
            this.OrderAmtLbl = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Recordtxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Syspasstxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Okbtn
            // 
            this.Okbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Okbtn.Location = new System.Drawing.Point(256, 456);
            this.Okbtn.Name = "Okbtn";
            this.Okbtn.Size = new System.Drawing.Size(104, 35);
            this.Okbtn.TabIndex = 0;
            this.Okbtn.Text = "OK";
            this.Okbtn.UseVisualStyleBackColor = true;
            this.Okbtn.Click += new System.EventHandler(this.Okbtn_Click);
            // 
            // ORnumtxt
            // 
            this.ORnumtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ORnumtxt.Location = new System.Drawing.Point(247, 314);
            this.ORnumtxt.Name = "ORnumtxt";
            this.ORnumtxt.Size = new System.Drawing.Size(181, 23);
            this.ORnumtxt.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 317);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Official Reciept Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(54, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "COF Number";
            // 
            // COFNumLbl
            // 
            this.COFNumLbl.AutoSize = true;
            this.COFNumLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.COFNumLbl.Location = new System.Drawing.Point(246, 66);
            this.COFNumLbl.Name = "COFNumLbl";
            this.COFNumLbl.Size = new System.Drawing.Size(42, 17);
            this.COFNumLbl.TabIndex = 4;
            this.COFNumLbl.Text = "None";
            // 
            // VatPerLbl
            // 
            this.VatPerLbl.AutoSize = true;
            this.VatPerLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VatPerLbl.Location = new System.Drawing.Point(246, 102);
            this.VatPerLbl.Name = "VatPerLbl";
            this.VatPerLbl.Size = new System.Drawing.Size(42, 17);
            this.VatPerLbl.TabIndex = 8;
            this.VatPerLbl.Text = "None";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(54, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 17);
            this.label7.TabIndex = 7;
            this.label7.Text = "VAT Percentage";
            // 
            // VATAmtLbl
            // 
            this.VATAmtLbl.AutoSize = true;
            this.VATAmtLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VATAmtLbl.Location = new System.Drawing.Point(246, 143);
            this.VATAmtLbl.Name = "VATAmtLbl";
            this.VATAmtLbl.Size = new System.Drawing.Size(42, 17);
            this.VATAmtLbl.TabIndex = 10;
            this.VATAmtLbl.Text = "None";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(54, 143);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 17);
            this.label9.TabIndex = 9;
            this.label9.Text = "VAT Amount";
            // 
            // ServChLbl
            // 
            this.ServChLbl.AutoSize = true;
            this.ServChLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServChLbl.Location = new System.Drawing.Point(247, 185);
            this.ServChLbl.Name = "ServChLbl";
            this.ServChLbl.Size = new System.Drawing.Size(42, 17);
            this.ServChLbl.TabIndex = 12;
            this.ServChLbl.Text = "None";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(55, 185);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(105, 17);
            this.label11.TabIndex = 11;
            this.label11.Text = "Service Charge";
            // 
            // TotLbl
            // 
            this.TotLbl.AutoSize = true;
            this.TotLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotLbl.Location = new System.Drawing.Point(245, 270);
            this.TotLbl.Name = "TotLbl";
            this.TotLbl.Size = new System.Drawing.Size(42, 17);
            this.TotLbl.TabIndex = 14;
            this.TotLbl.Text = "None";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(53, 270);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(105, 17);
            this.label13.TabIndex = 13;
            this.label13.Text = "Overall Amount";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(204, 19);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(156, 18);
            this.label14.TabIndex = 15;
            this.label14.Text = "OFFICIAL RECEIPT";
            // 
            // label125
            // 
            this.label125.AutoSize = true;
            this.label125.BackColor = System.Drawing.SystemColors.Window;
            this.label125.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label125.ForeColor = System.Drawing.Color.DarkOrange;
            this.label125.Location = new System.Drawing.Point(435, 317);
            this.label125.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label125.Name = "label125";
            this.label125.Size = new System.Drawing.Size(18, 24);
            this.label125.TabIndex = 291;
            this.label125.Text = "*";
            // 
            // OrderAmtLbl
            // 
            this.OrderAmtLbl.AutoSize = true;
            this.OrderAmtLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderAmtLbl.Location = new System.Drawing.Point(246, 227);
            this.OrderAmtLbl.Name = "OrderAmtLbl";
            this.OrderAmtLbl.Size = new System.Drawing.Size(42, 17);
            this.OrderAmtLbl.TabIndex = 293;
            this.OrderAmtLbl.Text = "None";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(54, 227);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(97, 17);
            this.label16.TabIndex = 292;
            this.label16.Text = "Order Amount";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Window;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkOrange;
            this.label3.Location = new System.Drawing.Point(435, 359);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 24);
            this.label3.TabIndex = 296;
            this.label3.Text = "*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(52, 362);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 17);
            this.label4.TabIndex = 295;
            this.label4.Text = "Recorded By:";
            // 
            // Recordtxt
            // 
            this.Recordtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Recordtxt.Location = new System.Drawing.Point(247, 359);
            this.Recordtxt.Name = "Recordtxt";
            this.Recordtxt.Size = new System.Drawing.Size(181, 23);
            this.Recordtxt.TabIndex = 294;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(52, 407);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 17);
            this.label5.TabIndex = 298;
            this.label5.Text = "System Password:";
            // 
            // Syspasstxt
            // 
            this.Syspasstxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Syspasstxt.Location = new System.Drawing.Point(247, 404);
            this.Syspasstxt.Name = "Syspasstxt";
            this.Syspasstxt.PasswordChar = '*';
            this.Syspasstxt.Size = new System.Drawing.Size(181, 23);
            this.Syspasstxt.TabIndex = 297;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Window;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkOrange;
            this.label6.Location = new System.Drawing.Point(435, 407);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 24);
            this.label6.TabIndex = 299;
            this.label6.Text = "*";
            // 
            // frmOR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(607, 521);
            this.ControlBox = false;
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Syspasstxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Recordtxt);
            this.Controls.Add(this.OrderAmtLbl);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label125);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.TotLbl);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.ServChLbl);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.VATAmtLbl);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.VatPerLbl);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.COFNumLbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ORnumtxt);
            this.Controls.Add(this.Okbtn);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmOR";
            this.Opacity = 0.93;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Official Receipt";
            this.Load += new System.EventHandler(this.frmOR_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Okbtn;
        private System.Windows.Forms.TextBox ORnumtxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label COFNumLbl;
        private System.Windows.Forms.Label VatPerLbl;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label VATAmtLbl;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label ServChLbl;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label TotLbl;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label125;
        private System.Windows.Forms.Label OrderAmtLbl;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Recordtxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Syspasstxt;
        private System.Windows.Forms.Label label6;
    }
}