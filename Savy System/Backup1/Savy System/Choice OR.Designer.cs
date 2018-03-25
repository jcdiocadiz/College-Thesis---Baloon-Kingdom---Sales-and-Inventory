namespace WindowsApplication1
{
    partial class Choice_OR
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Choice_OR));
            this.ORCanbtn = new System.Windows.Forms.Button();
            this.ORVibtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ORvirbtn = new System.Windows.Forms.RadioButton();
            this.ORIDrbtn = new System.Windows.Forms.RadioButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.ORnumtxt = new System.Windows.Forms.TextBox();
            this.From = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ORUptxt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ORCanbtn
            // 
            this.ORCanbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ORCanbtn.Location = new System.Drawing.Point(209, 191);
            this.ORCanbtn.Name = "ORCanbtn";
            this.ORCanbtn.Size = new System.Drawing.Size(75, 37);
            this.ORCanbtn.TabIndex = 13;
            this.ORCanbtn.Text = "Cancel";
            this.ORCanbtn.UseVisualStyleBackColor = true;
            this.ORCanbtn.Click += new System.EventHandler(this.ORCanbtn_Click);
            // 
            // ORVibtn
            // 
            this.ORVibtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ORVibtn.Location = new System.Drawing.Point(77, 191);
            this.ORVibtn.Name = "ORVibtn";
            this.ORVibtn.Size = new System.Drawing.Size(75, 37);
            this.ORVibtn.TabIndex = 12;
            this.ORVibtn.Text = "View";
            this.ORVibtn.UseVisualStyleBackColor = true;
            this.ORVibtn.Click += new System.EventHandler(this.ORVibtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(27, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(62, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(95, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 18);
            this.label1.TabIndex = 10;
            this.label1.Text = "View OR by:";
            // 
            // ORvirbtn
            // 
            this.ORvirbtn.AutoSize = true;
            this.ORvirbtn.Checked = true;
            this.ORvirbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ORvirbtn.Location = new System.Drawing.Point(90, 71);
            this.ORvirbtn.Name = "ORvirbtn";
            this.ORvirbtn.Size = new System.Drawing.Size(73, 20);
            this.ORvirbtn.TabIndex = 7;
            this.ORvirbtn.TabStop = true;
            this.ORvirbtn.Text = "View All";
            this.ORvirbtn.UseVisualStyleBackColor = true;
            this.ORvirbtn.CheckedChanged += new System.EventHandler(this.ORvirbtn_CheckedChanged);
            // 
            // ORIDrbtn
            // 
            this.ORIDrbtn.AutoSize = true;
            this.ORIDrbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ORIDrbtn.Location = new System.Drawing.Point(90, 97);
            this.ORIDrbtn.Name = "ORIDrbtn";
            this.ORIDrbtn.Size = new System.Drawing.Size(62, 20);
            this.ORIDrbtn.TabIndex = 15;
            this.ORIDrbtn.Text = "OR ID";
            this.ORIDrbtn.UseVisualStyleBackColor = true;
            this.ORIDrbtn.CheckedChanged += new System.EventHandler(this.ORIDrbtn_CheckedChanged);
            // 
            // ORnumtxt
            // 
            this.ORnumtxt.Enabled = false;
            this.ORnumtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ORnumtxt.Location = new System.Drawing.Point(154, 123);
            this.ORnumtxt.Name = "ORnumtxt";
            this.ORnumtxt.Size = new System.Drawing.Size(100, 22);
            this.ORnumtxt.TabIndex = 16;
            this.ORnumtxt.TextChanged += new System.EventHandler(this.ORnumtxt_TextChanged);
            // 
            // From
            // 
            this.From.AutoSize = true;
            this.From.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.From.Location = new System.Drawing.Point(113, 126);
            this.From.Name = "From";
            this.From.Size = new System.Drawing.Size(39, 16);
            this.From.TabIndex = 17;
            this.From.Text = "From";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(113, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 16);
            this.label3.TabIndex = 18;
            this.label3.Text = "Up to";
            // 
            // ORUptxt
            // 
            this.ORUptxt.Enabled = false;
            this.ORUptxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ORUptxt.Location = new System.Drawing.Point(154, 148);
            this.ORUptxt.Name = "ORUptxt";
            this.ORUptxt.Size = new System.Drawing.Size(100, 22);
            this.ORUptxt.TabIndex = 19;
            this.ORUptxt.TextChanged += new System.EventHandler(this.ORUptxt_TextChanged);
            // 
            // Choice_OR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 264);
            this.Controls.Add(this.ORUptxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.From);
            this.Controls.Add(this.ORnumtxt);
            this.Controls.Add(this.ORIDrbtn);
            this.Controls.Add(this.ORCanbtn);
            this.Controls.Add(this.ORVibtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ORvirbtn);
            this.Name = "Choice_OR";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Choice_OR";
            this.Load += new System.EventHandler(this.Choice_OR_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ORCanbtn;
        private System.Windows.Forms.Button ORVibtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton ORvirbtn;
        private System.Windows.Forms.RadioButton ORIDrbtn;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox ORnumtxt;
        private System.Windows.Forms.Label From;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ORUptxt;
    }
}