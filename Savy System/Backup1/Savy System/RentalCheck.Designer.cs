namespace WindowsApplication1
{
    partial class RentalCheck
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RentalCheck));
            this.RentalDatetxt = new System.Windows.Forms.TextBox();
            this.RentalCancelbtn = new System.Windows.Forms.Button();
            this.RentalViewbtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.RentalDaterbtn = new System.Windows.Forms.RadioButton();
            this.RentalViewrbtn = new System.Windows.Forms.RadioButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // RentalDatetxt
            // 
            this.RentalDatetxt.Enabled = false;
            this.RentalDatetxt.Location = new System.Drawing.Point(157, 104);
            this.RentalDatetxt.Name = "RentalDatetxt";
            this.RentalDatetxt.Size = new System.Drawing.Size(100, 20);
            this.RentalDatetxt.TabIndex = 26;
            this.RentalDatetxt.TextChanged += new System.EventHandler(this.RentalDatetxt_TextChanged);
            // 
            // RentalCancelbtn
            // 
            this.RentalCancelbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RentalCancelbtn.Location = new System.Drawing.Point(170, 158);
            this.RentalCancelbtn.Name = "RentalCancelbtn";
            this.RentalCancelbtn.Size = new System.Drawing.Size(75, 40);
            this.RentalCancelbtn.TabIndex = 21;
            this.RentalCancelbtn.Text = "Cancel";
            this.RentalCancelbtn.UseVisualStyleBackColor = true;
            this.RentalCancelbtn.Click += new System.EventHandler(this.RentalCancelbtn_Click);
            // 
            // RentalViewbtn
            // 
            this.RentalViewbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RentalViewbtn.Location = new System.Drawing.Point(68, 158);
            this.RentalViewbtn.Name = "RentalViewbtn";
            this.RentalViewbtn.Size = new System.Drawing.Size(75, 40);
            this.RentalViewbtn.TabIndex = 20;
            this.RentalViewbtn.Text = "View";
            this.RentalViewbtn.UseVisualStyleBackColor = true;
            this.RentalViewbtn.Click += new System.EventHandler(this.RentalViewbtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(25, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(62, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(93, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 18);
            this.label1.TabIndex = 18;
            this.label1.Text = "View Rental by:";
            // 
            // RentalDaterbtn
            // 
            this.RentalDaterbtn.AutoSize = true;
            this.RentalDaterbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RentalDaterbtn.Location = new System.Drawing.Point(96, 103);
            this.RentalDaterbtn.Name = "RentalDaterbtn";
            this.RentalDaterbtn.Size = new System.Drawing.Size(53, 20);
            this.RentalDaterbtn.TabIndex = 16;
            this.RentalDaterbtn.TabStop = true;
            this.RentalDaterbtn.Text = "COF";
            this.RentalDaterbtn.UseVisualStyleBackColor = true;
            this.RentalDaterbtn.CheckedChanged += new System.EventHandler(this.RentalDaterbtn_CheckedChanged);
            // 
            // RentalViewrbtn
            // 
            this.RentalViewrbtn.AutoSize = true;
            this.RentalViewrbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RentalViewrbtn.Location = new System.Drawing.Point(96, 70);
            this.RentalViewrbtn.Name = "RentalViewrbtn";
            this.RentalViewrbtn.Size = new System.Drawing.Size(73, 20);
            this.RentalViewrbtn.TabIndex = 15;
            this.RentalViewrbtn.TabStop = true;
            this.RentalViewrbtn.Text = "View All";
            this.RentalViewrbtn.UseVisualStyleBackColor = true;
            this.RentalViewrbtn.CheckedChanged += new System.EventHandler(this.RentalViewrbtn_CheckedChanged);
            // 
            // RentalCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 236);
            this.Controls.Add(this.RentalDatetxt);
            this.Controls.Add(this.RentalCancelbtn);
            this.Controls.Add(this.RentalViewbtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RentalDaterbtn);
            this.Controls.Add(this.RentalViewrbtn);
            this.MaximizeBox = false;
            this.Name = "RentalCheck";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RentalCheck";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox RentalDatetxt;
        private System.Windows.Forms.Button RentalCancelbtn;
        private System.Windows.Forms.Button RentalViewbtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton RentalDaterbtn;
        private System.Windows.Forms.RadioButton RentalViewrbtn;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}