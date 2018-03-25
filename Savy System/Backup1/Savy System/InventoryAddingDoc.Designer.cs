namespace WindowsApplication1
{
    partial class InvAddFrm
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
            this.button1 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.SyspassTxt = new System.Windows.Forms.TextBox();
            this.qtytxt = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.ItemNmetxt = new System.Windows.Forms.Label();
            this.IDtxt = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.donebytxt = new System.Windows.Forms.TextBox();
            this.okbtn = new System.Windows.Forms.Button();
            this.reasontxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(368, 311);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 38);
            this.button1.TabIndex = 33;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(94, 277);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 13);
            this.label9.TabIndex = 32;
            this.label9.Text = "System Password:";
            // 
            // SyspassTxt
            // 
            this.SyspassTxt.Location = new System.Drawing.Point(236, 270);
            this.SyspassTxt.Name = "SyspassTxt";
            this.SyspassTxt.PasswordChar = '*';
            this.SyspassTxt.Size = new System.Drawing.Size(252, 20);
            this.SyspassTxt.TabIndex = 31;
            // 
            // qtytxt
            // 
            this.qtytxt.AutoSize = true;
            this.qtytxt.Location = new System.Drawing.Point(233, 129);
            this.qtytxt.Name = "qtytxt";
            this.qtytxt.Size = new System.Drawing.Size(33, 13);
            this.qtytxt.TabIndex = 30;
            this.qtytxt.Text = "None";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(93, 129);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 13);
            this.label10.TabIndex = 29;
            this.label10.Text = "Quantity:";
            // 
            // ItemNmetxt
            // 
            this.ItemNmetxt.AutoSize = true;
            this.ItemNmetxt.Location = new System.Drawing.Point(233, 101);
            this.ItemNmetxt.Name = "ItemNmetxt";
            this.ItemNmetxt.Size = new System.Drawing.Size(33, 13);
            this.ItemNmetxt.TabIndex = 28;
            this.ItemNmetxt.Text = "None";
            // 
            // IDtxt
            // 
            this.IDtxt.AutoSize = true;
            this.IDtxt.Location = new System.Drawing.Point(233, 68);
            this.IDtxt.Name = "IDtxt";
            this.IDtxt.Size = new System.Drawing.Size(33, 13);
            this.IDtxt.TabIndex = 27;
            this.IDtxt.Text = "None";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(233, 161);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "Adding";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(93, 161);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "Type of Transaction: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(93, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Reason:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(93, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Item Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(93, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Item ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Transaction done by:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(217, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Inventory Transaction";
            // 
            // donebytxt
            // 
            this.donebytxt.Location = new System.Drawing.Point(236, 244);
            this.donebytxt.Name = "donebytxt";
            this.donebytxt.Size = new System.Drawing.Size(252, 20);
            this.donebytxt.TabIndex = 18;
            // 
            // okbtn
            // 
            this.okbtn.Location = new System.Drawing.Point(248, 311);
            this.okbtn.Name = "okbtn";
            this.okbtn.Size = new System.Drawing.Size(97, 38);
            this.okbtn.TabIndex = 17;
            this.okbtn.Text = "OK";
            this.okbtn.UseVisualStyleBackColor = true;
            this.okbtn.Click += new System.EventHandler(this.okbtn_Click);
            // 
            // reasontxt
            // 
            this.reasontxt.Location = new System.Drawing.Point(236, 190);
            this.reasontxt.Multiline = true;
            this.reasontxt.Name = "reasontxt";
            this.reasontxt.Size = new System.Drawing.Size(252, 48);
            this.reasontxt.TabIndex = 34;
            // 
            // InvAddFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 361);
            this.Controls.Add(this.reasontxt);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.SyspassTxt);
            this.Controls.Add(this.qtytxt);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.ItemNmetxt);
            this.Controls.Add(this.IDtxt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.donebytxt);
            this.Controls.Add(this.okbtn);
            this.Name = "InvAddFrm";
            this.Text = "Inventory";
            this.Load += new System.EventHandler(this.InvAddFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox SyspassTxt;
        private System.Windows.Forms.Label qtytxt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label ItemNmetxt;
        private System.Windows.Forms.Label IDtxt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox donebytxt;
        private System.Windows.Forms.Button okbtn;
        private System.Windows.Forms.TextBox reasontxt;
    }
}