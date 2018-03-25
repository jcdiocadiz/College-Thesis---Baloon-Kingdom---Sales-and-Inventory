namespace WindowsApplication1
{
    partial class ChoiceRentedItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChoiceRentedItem));
            this.RentalCOFtxt = new System.Windows.Forms.TextBox();
            this.Cancelbtn = new System.Windows.Forms.Button();
            this.CustViewbtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.COF = new System.Windows.Forms.RadioButton();
            this.RentalViewrbtn = new System.Windows.Forms.RadioButton();
            this.RentalViewbtn = new System.Windows.Forms.Button();
            this.RentalCancelbtn = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // RentalCOFtxt
            // 
            this.RentalCOFtxt.Enabled = false;
            this.RentalCOFtxt.Location = new System.Drawing.Point(102, 156);
            this.RentalCOFtxt.Name = "RentalCOFtxt";
            this.RentalCOFtxt.Size = new System.Drawing.Size(100, 20);
            this.RentalCOFtxt.TabIndex = 20;
            this.RentalCOFtxt.TextChanged += new System.EventHandler(this.RentalCOFtxt_TextChanged);
            // 
            // Cancelbtn
            // 
            this.Cancelbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancelbtn.Location = new System.Drawing.Point(179, 292);
            this.Cancelbtn.Name = "Cancelbtn";
            this.Cancelbtn.Size = new System.Drawing.Size(75, 23);
            this.Cancelbtn.TabIndex = 19;
            this.Cancelbtn.Text = "Cancel";
            this.Cancelbtn.UseVisualStyleBackColor = true;
            // 
            // CustViewbtn
            // 
            this.CustViewbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustViewbtn.Location = new System.Drawing.Point(77, 292);
            this.CustViewbtn.Name = "CustViewbtn";
            this.CustViewbtn.Size = new System.Drawing.Size(75, 23);
            this.CustViewbtn.TabIndex = 18;
            this.CustViewbtn.Text = "View";
            this.CustViewbtn.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(30, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(62, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(98, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 18);
            this.label1.TabIndex = 16;
            this.label1.Text = "View Rental by:";
            // 
            // COF
            // 
            this.COF.AutoSize = true;
            this.COF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.COF.Location = new System.Drawing.Point(82, 130);
            this.COF.Name = "COF";
            this.COF.Size = new System.Drawing.Size(53, 20);
            this.COF.TabIndex = 15;
            this.COF.TabStop = true;
            this.COF.Text = "COF";
            this.COF.UseVisualStyleBackColor = true;
            this.COF.CheckedChanged += new System.EventHandler(this.COF_CheckedChanged);
            // 
            // RentalViewrbtn
            // 
            this.RentalViewrbtn.AutoSize = true;
            this.RentalViewrbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RentalViewrbtn.Location = new System.Drawing.Point(82, 97);
            this.RentalViewrbtn.Name = "RentalViewrbtn";
            this.RentalViewrbtn.Size = new System.Drawing.Size(73, 20);
            this.RentalViewrbtn.TabIndex = 14;
            this.RentalViewrbtn.TabStop = true;
            this.RentalViewrbtn.Text = "View All";
            this.RentalViewrbtn.UseVisualStyleBackColor = true;
            this.RentalViewrbtn.CheckedChanged += new System.EventHandler(this.RentalViewrbtn_CheckedChanged);
            // 
            // RentalViewbtn
            // 
            this.RentalViewbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RentalViewbtn.Location = new System.Drawing.Point(60, 198);
            this.RentalViewbtn.Name = "RentalViewbtn";
            this.RentalViewbtn.Size = new System.Drawing.Size(75, 42);
            this.RentalViewbtn.TabIndex = 18;
            this.RentalViewbtn.Text = "View";
            this.RentalViewbtn.UseVisualStyleBackColor = true;
            this.RentalViewbtn.Click += new System.EventHandler(this.RentalViewbtn_Click);
            // 
            // RentalCancelbtn
            // 
            this.RentalCancelbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RentalCancelbtn.Location = new System.Drawing.Point(162, 198);
            this.RentalCancelbtn.Name = "RentalCancelbtn";
            this.RentalCancelbtn.Size = new System.Drawing.Size(75, 42);
            this.RentalCancelbtn.TabIndex = 19;
            this.RentalCancelbtn.Text = "Cancel";
            this.RentalCancelbtn.UseVisualStyleBackColor = true;
            this.RentalCancelbtn.Click += new System.EventHandler(this.RentalCancelbtn_Click);
            // 
            // ChoiceRentedItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.RentalCOFtxt);
            this.Controls.Add(this.RentalCancelbtn);
            this.Controls.Add(this.Cancelbtn);
            this.Controls.Add(this.RentalViewbtn);
            this.Controls.Add(this.CustViewbtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.COF);
            this.Controls.Add(this.RentalViewrbtn);
            this.MaximizeBox = false;
            this.Name = "ChoiceRentedItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChoiceRentedItem";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox RentalCOFtxt;
        private System.Windows.Forms.Button Cancelbtn;
        private System.Windows.Forms.Button CustViewbtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton COF;
        private System.Windows.Forms.RadioButton RentalViewrbtn;
        private System.Windows.Forms.Button RentalViewbtn;
        private System.Windows.Forms.Button RentalCancelbtn;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}