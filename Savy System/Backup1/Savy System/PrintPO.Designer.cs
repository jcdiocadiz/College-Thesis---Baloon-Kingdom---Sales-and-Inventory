namespace WindowsApplication1
{
    partial class PrintPO
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrintPO));
            this.label2 = new System.Windows.Forms.Label();
            this.PrintPOFtxt = new System.Windows.Forms.TextBox();
            this.PrintCancelbtn = new System.Windows.Forms.Button();
            this.POPrintbtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(55, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 41;
            this.label2.Text = "POF No.:";
            // 
            // PrintPOFtxt
            // 
            this.PrintPOFtxt.Location = new System.Drawing.Point(123, 125);
            this.PrintPOFtxt.Name = "PrintPOFtxt";
            this.PrintPOFtxt.Size = new System.Drawing.Size(100, 20);
            this.PrintPOFtxt.TabIndex = 40;
            this.PrintPOFtxt.TextChanged += new System.EventHandler(this.PrintPOFtxt_TextChanged);
            // 
            // PrintCancelbtn
            // 
            this.PrintCancelbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrintCancelbtn.Location = new System.Drawing.Point(171, 211);
            this.PrintCancelbtn.Name = "PrintCancelbtn";
            this.PrintCancelbtn.Size = new System.Drawing.Size(75, 39);
            this.PrintCancelbtn.TabIndex = 39;
            this.PrintCancelbtn.Text = "Cancel";
            this.PrintCancelbtn.UseVisualStyleBackColor = true;
            this.PrintCancelbtn.Click += new System.EventHandler(this.PrintCancelbtn_Click);
            // 
            // POPrintbtn
            // 
            this.POPrintbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.POPrintbtn.Location = new System.Drawing.Point(69, 211);
            this.POPrintbtn.Name = "POPrintbtn";
            this.POPrintbtn.Size = new System.Drawing.Size(75, 39);
            this.POPrintbtn.TabIndex = 38;
            this.POPrintbtn.Text = "Print";
            this.POPrintbtn.UseVisualStyleBackColor = true;
            this.POPrintbtn.Click += new System.EventHandler(this.POPrintbtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(39, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(62, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(107, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 18);
            this.label1.TabIndex = 36;
            this.label1.Text = "Print POF:";
            // 
            // PrintPO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PrintPOFtxt);
            this.Controls.Add(this.PrintCancelbtn);
            this.Controls.Add(this.POPrintbtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "PrintPO";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PrintPO";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PrintPOFtxt;
        private System.Windows.Forms.Button PrintCancelbtn;
        private System.Windows.Forms.Button POPrintbtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}