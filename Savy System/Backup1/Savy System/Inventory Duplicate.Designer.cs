namespace WindowsApplication1
{
    partial class InvDupFrm
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
            this.okbtn = new System.Windows.Forms.Button();
            this.donebytxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.IDtxt = new System.Windows.Forms.Label();
            this.ItemNmetxt = new System.Windows.Forms.Label();
            this.qtytxt = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.SyspassTxt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // okbtn
            // 
            this.okbtn.Location = new System.Drawing.Point(204, 297);
            this.okbtn.Name = "okbtn";
            this.okbtn.Size = new System.Drawing.Size(97, 38);
            this.okbtn.TabIndex = 0;
            this.okbtn.Text = "OK";
            this.okbtn.UseVisualStyleBackColor = true;
            this.okbtn.Click += new System.EventHandler(this.okbtn_Click);
            // 
            // donebytxt
            // 
            this.donebytxt.Location = new System.Drawing.Point(204, 220);
            this.donebytxt.Name = "donebytxt";
            this.donebytxt.Size = new System.Drawing.Size(252, 20);
            this.donebytxt.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(185, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Inventory Transaction";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Transaction done by:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Item ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Item Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(61, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Reason:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(201, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Add Quantity to Duplicate Item";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(61, 157);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Type of Transaction: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(201, 157);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Adding";
            // 
            // IDtxt
            // 
            this.IDtxt.AutoSize = true;
            this.IDtxt.Location = new System.Drawing.Point(201, 64);
            this.IDtxt.Name = "IDtxt";
            this.IDtxt.Size = new System.Drawing.Size(33, 13);
            this.IDtxt.TabIndex = 10;
            this.IDtxt.Text = "None";
            // 
            // ItemNmetxt
            // 
            this.ItemNmetxt.AutoSize = true;
            this.ItemNmetxt.Location = new System.Drawing.Point(201, 97);
            this.ItemNmetxt.Name = "ItemNmetxt";
            this.ItemNmetxt.Size = new System.Drawing.Size(33, 13);
            this.ItemNmetxt.TabIndex = 11;
            this.ItemNmetxt.Text = "None";
            // 
            // qtytxt
            // 
            this.qtytxt.AutoSize = true;
            this.qtytxt.Location = new System.Drawing.Point(201, 125);
            this.qtytxt.Name = "qtytxt";
            this.qtytxt.Size = new System.Drawing.Size(33, 13);
            this.qtytxt.TabIndex = 13;
            this.qtytxt.Text = "None";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(61, 125);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "Quantity:";
            // 
            // SyspassTxt
            // 
            this.SyspassTxt.Location = new System.Drawing.Point(204, 246);
            this.SyspassTxt.Name = "SyspassTxt";
            this.SyspassTxt.PasswordChar = '*';
            this.SyspassTxt.Size = new System.Drawing.Size(252, 20);
            this.SyspassTxt.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(62, 253);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "System Password:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(324, 297);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 38);
            this.button1.TabIndex = 16;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // InvDupFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 358);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.SyspassTxt);
            this.Controls.Add(this.qtytxt);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.ItemNmetxt);
            this.Controls.Add(this.IDtxt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.donebytxt);
            this.Controls.Add(this.okbtn);
            this.Name = "InvDupFrm";
            this.Text = "Inventory";
            this.Load += new System.EventHandler(this.InvDupFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button okbtn;
        private System.Windows.Forms.TextBox donebytxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label IDtxt;
        private System.Windows.Forms.Label ItemNmetxt;
        private System.Windows.Forms.Label qtytxt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox SyspassTxt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
    }
}