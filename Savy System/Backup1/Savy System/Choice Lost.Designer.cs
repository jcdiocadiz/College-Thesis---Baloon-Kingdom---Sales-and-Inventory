namespace WindowsApplication1
{
    partial class Choice_Lost
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Choice_Lost));
            this.LostCancelbtn = new System.Windows.Forms.Button();
            this.LostViewbtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LostQtyrbtn = new System.Windows.Forms.RadioButton();
            this.LostViewrbtn = new System.Windows.Forms.RadioButton();
            this.LostQtytxt = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.LostItemrbtn = new System.Windows.Forms.RadioButton();
            this.LostItemtxt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LostCancelbtn
            // 
            this.LostCancelbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LostCancelbtn.Location = new System.Drawing.Point(166, 287);
            this.LostCancelbtn.Name = "LostCancelbtn";
            this.LostCancelbtn.Size = new System.Drawing.Size(75, 23);
            this.LostCancelbtn.TabIndex = 13;
            this.LostCancelbtn.Text = "Cancel";
            this.LostCancelbtn.UseVisualStyleBackColor = true;
            this.LostCancelbtn.Click += new System.EventHandler(this.LostCancelbtn_Click);
            // 
            // LostViewbtn
            // 
            this.LostViewbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LostViewbtn.Location = new System.Drawing.Point(64, 287);
            this.LostViewbtn.Name = "LostViewbtn";
            this.LostViewbtn.Size = new System.Drawing.Size(75, 23);
            this.LostViewbtn.TabIndex = 12;
            this.LostViewbtn.Text = "View";
            this.LostViewbtn.UseVisualStyleBackColor = true;
            this.LostViewbtn.Click += new System.EventHandler(this.LostViewbtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(31, 15);
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
            this.label1.Location = new System.Drawing.Point(99, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 18);
            this.label1.TabIndex = 10;
            this.label1.Text = "View Lost Item by:";
            // 
            // LostQtyrbtn
            // 
            this.LostQtyrbtn.AutoSize = true;
            this.LostQtyrbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LostQtyrbtn.Location = new System.Drawing.Point(66, 119);
            this.LostQtyrbtn.Name = "LostQtyrbtn";
            this.LostQtyrbtn.Size = new System.Drawing.Size(56, 20);
            this.LostQtyrbtn.TabIndex = 8;
            this.LostQtyrbtn.Text = "COF:";
            this.LostQtyrbtn.UseVisualStyleBackColor = true;
            this.LostQtyrbtn.CheckedChanged += new System.EventHandler(this.LostQtyrbtn_CheckedChanged);
            // 
            // LostViewrbtn
            // 
            this.LostViewrbtn.AutoSize = true;
            this.LostViewrbtn.Checked = true;
            this.LostViewrbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LostViewrbtn.Location = new System.Drawing.Point(66, 86);
            this.LostViewrbtn.Name = "LostViewrbtn";
            this.LostViewrbtn.Size = new System.Drawing.Size(73, 20);
            this.LostViewrbtn.TabIndex = 7;
            this.LostViewrbtn.TabStop = true;
            this.LostViewrbtn.Text = "View All";
            this.LostViewrbtn.UseVisualStyleBackColor = true;
            this.LostViewrbtn.CheckedChanged += new System.EventHandler(this.LostViewrbtn_CheckedChanged);
            // 
            // LostQtytxt
            // 
            this.LostQtytxt.Enabled = false;
            this.LostQtytxt.Location = new System.Drawing.Point(85, 139);
            this.LostQtytxt.Name = "LostQtytxt";
            this.LostQtytxt.Size = new System.Drawing.Size(137, 20);
            this.LostQtytxt.TabIndex = 14;
            this.LostQtytxt.TextChanged += new System.EventHandler(this.LostQtytxt_TextChanged);
            // 
            // LostItemrbtn
            // 
            this.LostItemrbtn.AutoSize = true;
            this.LostItemrbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LostItemrbtn.Location = new System.Drawing.Point(66, 182);
            this.LostItemrbtn.Name = "LostItemrbtn";
            this.LostItemrbtn.Size = new System.Drawing.Size(67, 20);
            this.LostItemrbtn.TabIndex = 15;
            this.LostItemrbtn.TabStop = true;
            this.LostItemrbtn.Text = "Item ID";
            this.LostItemrbtn.UseVisualStyleBackColor = true;
            this.LostItemrbtn.CheckedChanged += new System.EventHandler(this.LostItemrbtn_CheckedChanged);
            // 
            // LostItemtxt
            // 
            this.LostItemtxt.Enabled = false;
            this.LostItemtxt.Location = new System.Drawing.Point(85, 219);
            this.LostItemtxt.Name = "LostItemtxt";
            this.LostItemtxt.Size = new System.Drawing.Size(137, 20);
            this.LostItemtxt.TabIndex = 16;
            this.LostItemtxt.TextChanged += new System.EventHandler(this.LostItemtxt_TextChanged);
            // 
            // Choice_Lost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 339);
            this.Controls.Add(this.LostItemtxt);
            this.Controls.Add(this.LostItemrbtn);
            this.Controls.Add(this.LostQtytxt);
            this.Controls.Add(this.LostCancelbtn);
            this.Controls.Add(this.LostViewbtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LostQtyrbtn);
            this.Controls.Add(this.LostViewrbtn);
            this.Name = "Choice_Lost";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Choice_Lost";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LostCancelbtn;
        private System.Windows.Forms.Button LostViewbtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton LostQtyrbtn;
        private System.Windows.Forms.RadioButton LostViewrbtn;
        private System.Windows.Forms.TextBox LostQtytxt;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.RadioButton LostItemrbtn;
        private System.Windows.Forms.TextBox LostItemtxt;
    }
}