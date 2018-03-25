namespace WindowsApplication1
{
    partial class Choice_Supplier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Choice_Supplier));
            this.SuppCancelbtn = new System.Windows.Forms.Button();
            this.SuppViewbtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Suppnmebtn = new System.Windows.Forms.RadioButton();
            this.SuppIDbtn = new System.Windows.Forms.RadioButton();
            this.SupIDFrmtxt = new System.Windows.Forms.TextBox();
            this.SupIDUptxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SupNameUptxt = new System.Windows.Forms.TextBox();
            this.SupNameFrmtxt = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.Supviewalrbtn = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // SuppCancelbtn
            // 
            this.SuppCancelbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SuppCancelbtn.Location = new System.Drawing.Point(162, 300);
            this.SuppCancelbtn.Name = "SuppCancelbtn";
            this.SuppCancelbtn.Size = new System.Drawing.Size(75, 36);
            this.SuppCancelbtn.TabIndex = 13;
            this.SuppCancelbtn.Text = "Cancel";
            this.SuppCancelbtn.UseVisualStyleBackColor = true;
            this.SuppCancelbtn.Click += new System.EventHandler(this.SuppCancelbtn_Click);
            // 
            // SuppViewbtn
            // 
            this.SuppViewbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SuppViewbtn.Location = new System.Drawing.Point(60, 300);
            this.SuppViewbtn.Name = "SuppViewbtn";
            this.SuppViewbtn.Size = new System.Drawing.Size(75, 36);
            this.SuppViewbtn.TabIndex = 12;
            this.SuppViewbtn.Text = "View";
            this.SuppViewbtn.UseVisualStyleBackColor = true;
            this.SuppViewbtn.Click += new System.EventHandler(this.SuppViewbtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(20, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(79, 62);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(100, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 18);
            this.label1.TabIndex = 10;
            this.label1.Text = "View Supplier by:";
            // 
            // Suppnmebtn
            // 
            this.Suppnmebtn.AutoSize = true;
            this.Suppnmebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Suppnmebtn.Location = new System.Drawing.Point(84, 179);
            this.Suppnmebtn.Name = "Suppnmebtn";
            this.Suppnmebtn.Size = new System.Drawing.Size(116, 20);
            this.Suppnmebtn.TabIndex = 8;
            this.Suppnmebtn.Text = "Supplier Name";
            this.Suppnmebtn.UseVisualStyleBackColor = true;
            this.Suppnmebtn.CheckedChanged += new System.EventHandler(this.Suppnmebtn_CheckedChanged);
            // 
            // SuppIDbtn
            // 
            this.SuppIDbtn.AutoSize = true;
            this.SuppIDbtn.Checked = true;
            this.SuppIDbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SuppIDbtn.Location = new System.Drawing.Point(84, 82);
            this.SuppIDbtn.Name = "SuppIDbtn";
            this.SuppIDbtn.Size = new System.Drawing.Size(92, 20);
            this.SuppIDbtn.TabIndex = 7;
            this.SuppIDbtn.TabStop = true;
            this.SuppIDbtn.Text = "Supplier ID";
            this.SuppIDbtn.UseVisualStyleBackColor = true;
            this.SuppIDbtn.CheckedChanged += new System.EventHandler(this.SuppIDbtn_CheckedChanged);
            // 
            // SupIDFrmtxt
            // 
            this.SupIDFrmtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SupIDFrmtxt.Location = new System.Drawing.Point(158, 108);
            this.SupIDFrmtxt.Name = "SupIDFrmtxt";
            this.SupIDFrmtxt.Size = new System.Drawing.Size(100, 22);
            this.SupIDFrmtxt.TabIndex = 14;
            this.SupIDFrmtxt.TextChanged += new System.EventHandler(this.SupIDFrmtxt_TextChanged);
            // 
            // SupIDUptxt
            // 
            this.SupIDUptxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SupIDUptxt.Location = new System.Drawing.Point(158, 141);
            this.SupIDUptxt.Name = "SupIDUptxt";
            this.SupIDUptxt.Size = new System.Drawing.Size(100, 22);
            this.SupIDUptxt.TabIndex = 15;
            this.SupIDUptxt.TextChanged += new System.EventHandler(this.SupIDUptxt_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(117, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "From";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(117, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "Up to";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(117, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 16);
            this.label4.TabIndex = 21;
            this.label4.Text = "Up to";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(117, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 16);
            this.label5.TabIndex = 20;
            this.label5.Text = "From";
            // 
            // SupNameUptxt
            // 
            this.SupNameUptxt.Enabled = false;
            this.SupNameUptxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SupNameUptxt.Location = new System.Drawing.Point(158, 238);
            this.SupNameUptxt.Name = "SupNameUptxt";
            this.SupNameUptxt.Size = new System.Drawing.Size(100, 22);
            this.SupNameUptxt.TabIndex = 19;
            this.SupNameUptxt.TextChanged += new System.EventHandler(this.SupNameUptxt_TextChanged);
            this.SupNameUptxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SupNameUptxt_KeyPress);
            // 
            // SupNameFrmtxt
            // 
            this.SupNameFrmtxt.Enabled = false;
            this.SupNameFrmtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SupNameFrmtxt.Location = new System.Drawing.Point(158, 205);
            this.SupNameFrmtxt.Name = "SupNameFrmtxt";
            this.SupNameFrmtxt.Size = new System.Drawing.Size(100, 22);
            this.SupNameFrmtxt.TabIndex = 18;
            this.SupNameFrmtxt.TextChanged += new System.EventHandler(this.SupNameFrmtxt_TextChanged);
            this.SupNameFrmtxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SupNameFrmtxt_KeyPress);
            // 
            // Supviewalrbtn
            // 
            this.Supviewalrbtn.AutoSize = true;
            this.Supviewalrbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Supviewalrbtn.Location = new System.Drawing.Point(84, 264);
            this.Supviewalrbtn.Name = "Supviewalrbtn";
            this.Supviewalrbtn.Size = new System.Drawing.Size(73, 20);
            this.Supviewalrbtn.TabIndex = 22;
            this.Supviewalrbtn.TabStop = true;
            this.Supviewalrbtn.Text = "View All";
            this.Supviewalrbtn.UseVisualStyleBackColor = true;
            this.Supviewalrbtn.CheckedChanged += new System.EventHandler(this.Supviewalrbtn_CheckedChanged);
            // 
            // Choice_Supplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 358);
            this.Controls.Add(this.Supviewalrbtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.SupNameUptxt);
            this.Controls.Add(this.SupNameFrmtxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SupIDUptxt);
            this.Controls.Add(this.SupIDFrmtxt);
            this.Controls.Add(this.SuppCancelbtn);
            this.Controls.Add(this.SuppViewbtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Suppnmebtn);
            this.Controls.Add(this.SuppIDbtn);
            this.MaximizeBox = false;
            this.Name = "Choice_Supplier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Choice_Supplier";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SuppCancelbtn;
        private System.Windows.Forms.Button SuppViewbtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton Suppnmebtn;
        private System.Windows.Forms.RadioButton SuppIDbtn;
        private System.Windows.Forms.TextBox SupIDFrmtxt;
        private System.Windows.Forms.TextBox SupIDUptxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox SupNameUptxt;
        private System.Windows.Forms.TextBox SupNameFrmtxt;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.RadioButton Supviewalrbtn;
    }
}