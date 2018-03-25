namespace WindowsApplication1
{
    partial class AccountsReceivable
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountsReceivable));
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SalesCancelbtn = new System.Windows.Forms.Button();
            this.SalesViewbtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.AccountRcvD1 = new System.Windows.Forms.DateTimePicker();
            this.AccountRcvD2 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 52;
            this.label4.Text = "End";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 51;
            this.label3.Text = "Begin";
            // 
            // SalesCancelbtn
            // 
            this.SalesCancelbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalesCancelbtn.Location = new System.Drawing.Point(171, 279);
            this.SalesCancelbtn.Name = "SalesCancelbtn";
            this.SalesCancelbtn.Size = new System.Drawing.Size(78, 24);
            this.SalesCancelbtn.TabIndex = 47;
            this.SalesCancelbtn.Text = "Cancel";
            this.SalesCancelbtn.UseVisualStyleBackColor = true;
            this.SalesCancelbtn.Click += new System.EventHandler(this.SalesCancelbtn_Click);
            // 
            // SalesViewbtn
            // 
            this.SalesViewbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalesViewbtn.Location = new System.Drawing.Point(69, 279);
            this.SalesViewbtn.Name = "SalesViewbtn";
            this.SalesViewbtn.Size = new System.Drawing.Size(78, 24);
            this.SalesViewbtn.TabIndex = 46;
            this.SalesViewbtn.Text = "View";
            this.SalesViewbtn.UseVisualStyleBackColor = true;
            this.SalesViewbtn.Click += new System.EventHandler(this.SalesViewbtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(23, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(72, 72);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 55;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(101, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 18);
            this.label1.TabIndex = 54;
            this.label1.Text = "Account Receivable:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(288, 16);
            this.label2.TabIndex = 56;
            this.label2.Text = "Select Date to Print Account Receivable:";
            // 
            // AccountRcvD1
            // 
            this.AccountRcvD1.Location = new System.Drawing.Point(69, 152);
            this.AccountRcvD1.Name = "AccountRcvD1";
            this.AccountRcvD1.Size = new System.Drawing.Size(200, 20);
            this.AccountRcvD1.TabIndex = 57;
            // 
            // AccountRcvD2
            // 
            this.AccountRcvD2.Location = new System.Drawing.Point(69, 189);
            this.AccountRcvD2.Name = "AccountRcvD2";
            this.AccountRcvD2.Size = new System.Drawing.Size(200, 20);
            this.AccountRcvD2.TabIndex = 58;
            // 
            // AccountsReceivable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 339);
            this.Controls.Add(this.AccountRcvD2);
            this.Controls.Add(this.AccountRcvD1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SalesCancelbtn);
            this.Controls.Add(this.SalesViewbtn);
            this.MaximizeBox = false;
            this.Name = "AccountsReceivable";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AccountsReceivable";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button SalesCancelbtn;
        private System.Windows.Forms.Button SalesViewbtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker AccountRcvD1;
        private System.Windows.Forms.DateTimePicker AccountRcvD2;
    }
}