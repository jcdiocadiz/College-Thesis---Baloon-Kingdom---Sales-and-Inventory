namespace WindowsApplication1
{
    partial class ChoiceRefund
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChoiceRefund));
            this.RefundCOFtxt = new System.Windows.Forms.TextBox();
            this.RefundCancelbtn = new System.Windows.Forms.Button();
            this.RefundViewbtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.RefundCOFrbtn = new System.Windows.Forms.RadioButton();
            this.RefundViewrbtn = new System.Windows.Forms.RadioButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // RefundCOFtxt
            // 
            this.RefundCOFtxt.Enabled = false;
            this.RefundCOFtxt.Location = new System.Drawing.Point(105, 156);
            this.RefundCOFtxt.Name = "RefundCOFtxt";
            this.RefundCOFtxt.Size = new System.Drawing.Size(100, 20);
            this.RefundCOFtxt.TabIndex = 27;
            this.RefundCOFtxt.TextChanged += new System.EventHandler(this.RefundCOFtxt_TextChanged);
            // 
            // RefundCancelbtn
            // 
            this.RefundCancelbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RefundCancelbtn.Location = new System.Drawing.Point(165, 210);
            this.RefundCancelbtn.Name = "RefundCancelbtn";
            this.RefundCancelbtn.Size = new System.Drawing.Size(75, 39);
            this.RefundCancelbtn.TabIndex = 26;
            this.RefundCancelbtn.Text = "Cancel";
            this.RefundCancelbtn.UseVisualStyleBackColor = true;
            this.RefundCancelbtn.Click += new System.EventHandler(this.RefundCancelbtn_Click);
            // 
            // RefundViewbtn
            // 
            this.RefundViewbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RefundViewbtn.Location = new System.Drawing.Point(63, 210);
            this.RefundViewbtn.Name = "RefundViewbtn";
            this.RefundViewbtn.Size = new System.Drawing.Size(75, 39);
            this.RefundViewbtn.TabIndex = 25;
            this.RefundViewbtn.Text = "View";
            this.RefundViewbtn.UseVisualStyleBackColor = true;
            this.RefundViewbtn.Click += new System.EventHandler(this.RefundViewbtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(33, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(62, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(101, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 18);
            this.label1.TabIndex = 23;
            this.label1.Text = "View Refund by:";
            // 
            // RefundCOFrbtn
            // 
            this.RefundCOFrbtn.AutoSize = true;
            this.RefundCOFrbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RefundCOFrbtn.Location = new System.Drawing.Point(85, 130);
            this.RefundCOFrbtn.Name = "RefundCOFrbtn";
            this.RefundCOFrbtn.Size = new System.Drawing.Size(53, 20);
            this.RefundCOFrbtn.TabIndex = 22;
            this.RefundCOFrbtn.TabStop = true;
            this.RefundCOFrbtn.Text = "COF";
            this.RefundCOFrbtn.UseVisualStyleBackColor = true;
            this.RefundCOFrbtn.CheckedChanged += new System.EventHandler(this.RefundCOFrbtn_CheckedChanged);
            // 
            // RefundViewrbtn
            // 
            this.RefundViewrbtn.AutoSize = true;
            this.RefundViewrbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RefundViewrbtn.Location = new System.Drawing.Point(85, 97);
            this.RefundViewrbtn.Name = "RefundViewrbtn";
            this.RefundViewrbtn.Size = new System.Drawing.Size(73, 20);
            this.RefundViewrbtn.TabIndex = 21;
            this.RefundViewrbtn.TabStop = true;
            this.RefundViewrbtn.Text = "View All";
            this.RefundViewrbtn.UseVisualStyleBackColor = true;
            this.RefundViewrbtn.CheckedChanged += new System.EventHandler(this.RefundViewrbtn_CheckedChanged);
            // 
            // ChoiceRefund
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 280);
            this.Controls.Add(this.RefundCOFtxt);
            this.Controls.Add(this.RefundCancelbtn);
            this.Controls.Add(this.RefundViewbtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RefundCOFrbtn);
            this.Controls.Add(this.RefundViewrbtn);
            this.Name = "ChoiceRefund";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChoiceRefund";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox RefundCOFtxt;
        private System.Windows.Forms.Button RefundCancelbtn;
        private System.Windows.Forms.Button RefundViewbtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton RefundCOFrbtn;
        private System.Windows.Forms.RadioButton RefundViewrbtn;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}