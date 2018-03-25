namespace WindowsApplication1
{
    partial class AccountsPayable
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountsPayable));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PayableCancelbtn = new System.Windows.Forms.Button();
            this.PayableViewbtn = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.AccountPDate1 = new System.Windows.Forms.DateTimePicker();
            this.AccountPDay2 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(23, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(72, 72);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 64;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(101, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 18);
            this.label1.TabIndex = 63;
            this.label1.Text = "Account Payable:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(155, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 62;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 61;
            this.label4.Text = "End";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 60;
            this.label3.Text = "Begin";
            // 
            // PayableCancelbtn
            // 
            this.PayableCancelbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PayableCancelbtn.Location = new System.Drawing.Point(171, 290);
            this.PayableCancelbtn.Name = "PayableCancelbtn";
            this.PayableCancelbtn.Size = new System.Drawing.Size(78, 24);
            this.PayableCancelbtn.TabIndex = 57;
            this.PayableCancelbtn.Text = "Cancel";
            this.PayableCancelbtn.UseVisualStyleBackColor = true;
            this.PayableCancelbtn.Click += new System.EventHandler(this.PayableCancelbtn_Click);
            // 
            // PayableViewbtn
            // 
            this.PayableViewbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PayableViewbtn.Location = new System.Drawing.Point(69, 290);
            this.PayableViewbtn.Name = "PayableViewbtn";
            this.PayableViewbtn.Size = new System.Drawing.Size(78, 24);
            this.PayableViewbtn.TabIndex = 56;
            this.PayableViewbtn.Text = "View";
            this.PayableViewbtn.UseVisualStyleBackColor = true;
            this.PayableViewbtn.Click += new System.EventHandler(this.PayableViewbtn_Click);
            // 
            // AccountPDate1
            // 
            this.AccountPDate1.Location = new System.Drawing.Point(73, 160);
            this.AccountPDate1.Name = "AccountPDate1";
            this.AccountPDate1.Size = new System.Drawing.Size(200, 20);
            this.AccountPDate1.TabIndex = 65;
            // 
            // AccountPDay2
            // 
            this.AccountPDay2.Location = new System.Drawing.Point(73, 192);
            this.AccountPDay2.Name = "AccountPDay2";
            this.AccountPDay2.Size = new System.Drawing.Size(200, 20);
            this.AccountPDay2.TabIndex = 66;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(266, 16);
            this.label2.TabIndex = 67;
            this.label2.Text = "Select Date to Print Account Payable:";
            // 
            // AccountsPayable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 339);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AccountPDay2);
            this.Controls.Add(this.AccountPDate1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PayableCancelbtn);
            this.Controls.Add(this.PayableViewbtn);
            this.MinimizeBox = false;
            this.Name = "AccountsPayable";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AccountsPayable";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button PayableCancelbtn;
        private System.Windows.Forms.Button PayableViewbtn;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DateTimePicker AccountPDate1;
        private System.Windows.Forms.DateTimePicker AccountPDay2;
        private System.Windows.Forms.Label label2;
    }
}