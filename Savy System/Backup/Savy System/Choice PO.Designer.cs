namespace WindowsApplication1
{
    partial class Choice_PO
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Choice_PO));
            this.PODatebtn = new System.Windows.Forms.RadioButton();
            this.POCancelbtn = new System.Windows.Forms.Button();
            this.POViewbtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.POViewrbtn = new System.Windows.Forms.RadioButton();
            this.PONobtn = new System.Windows.Forms.RadioButton();
            this.PONofrmtxt = new System.Windows.Forms.TextBox();
            this.PONouptxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.POFrmpick = new System.Windows.Forms.DateTimePicker();
            this.POUppick = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PODatebtn
            // 
            this.PODatebtn.AutoSize = true;
            this.PODatebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PODatebtn.Location = new System.Drawing.Point(53, 205);
            this.PODatebtn.Name = "PODatebtn";
            this.PODatebtn.Size = new System.Drawing.Size(123, 20);
            this.PODatebtn.TabIndex = 34;
            this.PODatebtn.Text = "Date Purchased";
            this.PODatebtn.UseVisualStyleBackColor = true;
            this.PODatebtn.CheckedChanged += new System.EventHandler(this.PODatebtn_CheckedChanged);
            // 
            // POCancelbtn
            // 
            this.POCancelbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.POCancelbtn.Location = new System.Drawing.Point(184, 300);
            this.POCancelbtn.Name = "POCancelbtn";
            this.POCancelbtn.Size = new System.Drawing.Size(75, 42);
            this.POCancelbtn.TabIndex = 33;
            this.POCancelbtn.Text = "Cancel";
            this.POCancelbtn.UseVisualStyleBackColor = true;
            this.POCancelbtn.Click += new System.EventHandler(this.POCancelbtn_Click);
            // 
            // POViewbtn
            // 
            this.POViewbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.POViewbtn.Location = new System.Drawing.Point(82, 300);
            this.POViewbtn.Name = "POViewbtn";
            this.POViewbtn.Size = new System.Drawing.Size(75, 42);
            this.POViewbtn.TabIndex = 32;
            this.POViewbtn.Text = "View";
            this.POViewbtn.UseVisualStyleBackColor = true;
            this.POViewbtn.Click += new System.EventHandler(this.POViewbtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(26, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(72, 72);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(106, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 18);
            this.label1.TabIndex = 30;
            this.label1.Text = "View PO by:";
            // 
            // POViewrbtn
            // 
            this.POViewrbtn.AutoSize = true;
            this.POViewrbtn.Checked = true;
            this.POViewrbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.POViewrbtn.Location = new System.Drawing.Point(53, 92);
            this.POViewrbtn.Name = "POViewrbtn";
            this.POViewrbtn.Size = new System.Drawing.Size(73, 20);
            this.POViewrbtn.TabIndex = 29;
            this.POViewrbtn.TabStop = true;
            this.POViewrbtn.Text = "View All";
            this.POViewrbtn.UseVisualStyleBackColor = true;
            this.POViewrbtn.CheckedChanged += new System.EventHandler(this.POViewrbtn_CheckedChanged);
            // 
            // PONobtn
            // 
            this.PONobtn.AutoSize = true;
            this.PONobtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PONobtn.Location = new System.Drawing.Point(53, 118);
            this.PONobtn.Name = "PONobtn";
            this.PONobtn.Size = new System.Drawing.Size(69, 20);
            this.PONobtn.TabIndex = 28;
            this.PONobtn.Text = "PO No.";
            this.PONobtn.UseVisualStyleBackColor = true;
            this.PONobtn.CheckedChanged += new System.EventHandler(this.PONobtn_CheckedChanged);
            // 
            // PONofrmtxt
            // 
            this.PONofrmtxt.Enabled = false;
            this.PONofrmtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PONofrmtxt.Location = new System.Drawing.Point(112, 147);
            this.PONofrmtxt.Name = "PONofrmtxt";
            this.PONofrmtxt.Size = new System.Drawing.Size(100, 22);
            this.PONofrmtxt.TabIndex = 35;
            this.PONofrmtxt.TextChanged += new System.EventHandler(this.PONofrmtxt_TextChanged);
            // 
            // PONouptxt
            // 
            this.PONouptxt.Enabled = false;
            this.PONouptxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PONouptxt.Location = new System.Drawing.Point(112, 179);
            this.PONouptxt.Name = "PONouptxt";
            this.PONouptxt.Size = new System.Drawing.Size(100, 22);
            this.PONouptxt.TabIndex = 36;
            this.PONouptxt.TextChanged += new System.EventHandler(this.PONouptxt_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(71, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 16);
            this.label2.TabIndex = 37;
            this.label2.Text = "From";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(71, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 16);
            this.label3.TabIndex = 38;
            this.label3.Text = "Up to";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(50, 260);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 16);
            this.label4.TabIndex = 42;
            this.label4.Text = "Up to";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(50, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 16);
            this.label5.TabIndex = 41;
            this.label5.Text = "From";
            // 
            // POFrmpick
            // 
            this.POFrmpick.Enabled = false;
            this.POFrmpick.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.POFrmpick.Location = new System.Drawing.Point(86, 231);
            this.POFrmpick.Name = "POFrmpick";
            this.POFrmpick.Size = new System.Drawing.Size(220, 22);
            this.POFrmpick.TabIndex = 43;
            // 
            // POUppick
            // 
            this.POUppick.Enabled = false;
            this.POUppick.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.POUppick.Location = new System.Drawing.Point(86, 254);
            this.POUppick.Name = "POUppick";
            this.POUppick.Size = new System.Drawing.Size(220, 22);
            this.POUppick.TabIndex = 44;
            // 
            // Choice_PO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 365);
            this.Controls.Add(this.POUppick);
            this.Controls.Add(this.POFrmpick);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PONouptxt);
            this.Controls.Add(this.PONofrmtxt);
            this.Controls.Add(this.PODatebtn);
            this.Controls.Add(this.POCancelbtn);
            this.Controls.Add(this.POViewbtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.POViewrbtn);
            this.Controls.Add(this.PONobtn);
            this.MaximizeBox = false;
            this.Name = "Choice_PO";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Choice_PO";
            this.Load += new System.EventHandler(this.Choice_PO_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton PODatebtn;
        private System.Windows.Forms.Button POCancelbtn;
        private System.Windows.Forms.Button POViewbtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton POViewrbtn;
        private System.Windows.Forms.RadioButton PONobtn;
        private System.Windows.Forms.TextBox PONofrmtxt;
        private System.Windows.Forms.TextBox PONouptxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DateTimePicker POFrmpick;
        private System.Windows.Forms.DateTimePicker POUppick;
    }
}