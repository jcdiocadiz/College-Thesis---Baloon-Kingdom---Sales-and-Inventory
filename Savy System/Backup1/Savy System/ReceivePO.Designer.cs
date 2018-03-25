namespace WindowsApplication1
{
    partial class ReceivePO
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReceivePO));
            this.RcvUppick = new System.Windows.Forms.DateTimePicker();
            this.RcvFrmpick = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.RcvNouptxt = new System.Windows.Forms.TextBox();
            this.RcvNofrmtxt = new System.Windows.Forms.TextBox();
            this.RcvDatebtn = new System.Windows.Forms.RadioButton();
            this.POCancelbtn = new System.Windows.Forms.Button();
            this.POViewbtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.RcvViewrbtn = new System.Windows.Forms.RadioButton();
            this.RcvNobtn = new System.Windows.Forms.RadioButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // RcvUppick
            // 
            this.RcvUppick.Enabled = false;
            this.RcvUppick.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RcvUppick.Location = new System.Drawing.Point(105, 266);
            this.RcvUppick.Name = "RcvUppick";
            this.RcvUppick.Size = new System.Drawing.Size(230, 22);
            this.RcvUppick.TabIndex = 59;
            // 
            // RcvFrmpick
            // 
            this.RcvFrmpick.Enabled = false;
            this.RcvFrmpick.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RcvFrmpick.Location = new System.Drawing.Point(105, 238);
            this.RcvFrmpick.Name = "RcvFrmpick";
            this.RcvFrmpick.Size = new System.Drawing.Size(230, 22);
            this.RcvFrmpick.TabIndex = 58;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(59, 272);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 16);
            this.label4.TabIndex = 57;
            this.label4.Text = "Up to";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(59, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 16);
            this.label5.TabIndex = 56;
            this.label5.Text = "From";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(57, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 16);
            this.label3.TabIndex = 55;
            this.label3.Text = "Up to";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(57, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 16);
            this.label2.TabIndex = 54;
            this.label2.Text = "From";
            // 
            // RcvNouptxt
            // 
            this.RcvNouptxt.Enabled = false;
            this.RcvNouptxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RcvNouptxt.Location = new System.Drawing.Point(105, 177);
            this.RcvNouptxt.Name = "RcvNouptxt";
            this.RcvNouptxt.Size = new System.Drawing.Size(100, 22);
            this.RcvNouptxt.TabIndex = 53;
            this.RcvNouptxt.TextChanged += new System.EventHandler(this.RcvNouptxt_TextChanged);
            // 
            // RcvNofrmtxt
            // 
            this.RcvNofrmtxt.Enabled = false;
            this.RcvNofrmtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RcvNofrmtxt.Location = new System.Drawing.Point(105, 145);
            this.RcvNofrmtxt.Name = "RcvNofrmtxt";
            this.RcvNofrmtxt.Size = new System.Drawing.Size(100, 22);
            this.RcvNofrmtxt.TabIndex = 52;
            this.RcvNofrmtxt.TextChanged += new System.EventHandler(this.RcvNofrmtxt_TextChanged);
            // 
            // RcvDatebtn
            // 
            this.RcvDatebtn.AutoSize = true;
            this.RcvDatebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RcvDatebtn.Location = new System.Drawing.Point(39, 203);
            this.RcvDatebtn.Name = "RcvDatebtn";
            this.RcvDatebtn.Size = new System.Drawing.Size(117, 20);
            this.RcvDatebtn.TabIndex = 51;
            this.RcvDatebtn.Text = "Date Received";
            this.RcvDatebtn.UseVisualStyleBackColor = true;
            this.RcvDatebtn.CheckedChanged += new System.EventHandler(this.RcvDatebtn_CheckedChanged);
            // 
            // POCancelbtn
            // 
            this.POCancelbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.POCancelbtn.Location = new System.Drawing.Point(191, 303);
            this.POCancelbtn.Name = "POCancelbtn";
            this.POCancelbtn.Size = new System.Drawing.Size(75, 32);
            this.POCancelbtn.TabIndex = 50;
            this.POCancelbtn.Text = "Cancel";
            this.POCancelbtn.UseVisualStyleBackColor = true;
            this.POCancelbtn.Click += new System.EventHandler(this.POCancelbtn_Click);
            // 
            // POViewbtn
            // 
            this.POViewbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.POViewbtn.Location = new System.Drawing.Point(95, 303);
            this.POViewbtn.Name = "POViewbtn";
            this.POViewbtn.Size = new System.Drawing.Size(75, 32);
            this.POViewbtn.TabIndex = 49;
            this.POViewbtn.Text = "View";
            this.POViewbtn.UseVisualStyleBackColor = true;
            this.POViewbtn.Click += new System.EventHandler(this.POViewbtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(72, 72);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 48;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(92, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 18);
            this.label1.TabIndex = 47;
            this.label1.Text = "View Receive by:";
            // 
            // RcvViewrbtn
            // 
            this.RcvViewrbtn.AutoSize = true;
            this.RcvViewrbtn.Checked = true;
            this.RcvViewrbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RcvViewrbtn.Location = new System.Drawing.Point(39, 90);
            this.RcvViewrbtn.Name = "RcvViewrbtn";
            this.RcvViewrbtn.Size = new System.Drawing.Size(73, 20);
            this.RcvViewrbtn.TabIndex = 46;
            this.RcvViewrbtn.TabStop = true;
            this.RcvViewrbtn.Text = "View All";
            this.RcvViewrbtn.UseVisualStyleBackColor = true;
            this.RcvViewrbtn.CheckedChanged += new System.EventHandler(this.RcvViewrbtn_CheckedChanged);
            // 
            // RcvNobtn
            // 
            this.RcvNobtn.AutoSize = true;
            this.RcvNobtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RcvNobtn.Location = new System.Drawing.Point(39, 116);
            this.RcvNobtn.Name = "RcvNobtn";
            this.RcvNobtn.Size = new System.Drawing.Size(93, 20);
            this.RcvNobtn.TabIndex = 45;
            this.RcvNobtn.Text = "Receive ID";
            this.RcvNobtn.UseVisualStyleBackColor = true;
            this.RcvNobtn.CheckedChanged += new System.EventHandler(this.RcvNobtn_CheckedChanged);
            // 
            // ReceivePO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 358);
            this.Controls.Add(this.RcvUppick);
            this.Controls.Add(this.RcvFrmpick);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RcvNouptxt);
            this.Controls.Add(this.RcvNofrmtxt);
            this.Controls.Add(this.RcvDatebtn);
            this.Controls.Add(this.POCancelbtn);
            this.Controls.Add(this.POViewbtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RcvViewrbtn);
            this.Controls.Add(this.RcvNobtn);
            this.Name = "ReceivePO";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReceivePO";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker RcvUppick;
        private System.Windows.Forms.DateTimePicker RcvFrmpick;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox RcvNouptxt;
        private System.Windows.Forms.TextBox RcvNofrmtxt;
        private System.Windows.Forms.RadioButton RcvDatebtn;
        private System.Windows.Forms.Button POCancelbtn;
        private System.Windows.Forms.Button POViewbtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton RcvViewrbtn;
        private System.Windows.Forms.RadioButton RcvNobtn;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}