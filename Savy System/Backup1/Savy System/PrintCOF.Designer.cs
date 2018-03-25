namespace WindowsApplication1
{
    partial class PrintCOF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrintCOF));
            this.PrintCOFtxt = new System.Windows.Forms.TextBox();
            this.PrintCancelbtn = new System.Windows.Forms.Button();
            this.RefundViewbtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PrintCOFtxt
            // 
            this.PrintCOFtxt.Location = new System.Drawing.Point(113, 124);
            this.PrintCOFtxt.Name = "PrintCOFtxt";
            this.PrintCOFtxt.Size = new System.Drawing.Size(100, 20);
            this.PrintCOFtxt.TabIndex = 34;
            this.PrintCOFtxt.TextChanged += new System.EventHandler(this.PrintCOFtxt_TextChanged);
            // 
            // PrintCancelbtn
            // 
            this.PrintCancelbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrintCancelbtn.Location = new System.Drawing.Point(161, 210);
            this.PrintCancelbtn.Name = "PrintCancelbtn";
            this.PrintCancelbtn.Size = new System.Drawing.Size(75, 39);
            this.PrintCancelbtn.TabIndex = 33;
            this.PrintCancelbtn.Text = "Cancel";
            this.PrintCancelbtn.UseVisualStyleBackColor = true;
            this.PrintCancelbtn.Click += new System.EventHandler(this.PrintCancelbtn_Click);
            // 
            // RefundViewbtn
            // 
            this.RefundViewbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RefundViewbtn.Location = new System.Drawing.Point(59, 210);
            this.RefundViewbtn.Name = "RefundViewbtn";
            this.RefundViewbtn.Size = new System.Drawing.Size(75, 39);
            this.RefundViewbtn.TabIndex = 32;
            this.RefundViewbtn.Text = "Print";
            this.RefundViewbtn.UseVisualStyleBackColor = true;
            this.RefundViewbtn.Click += new System.EventHandler(this.RefundViewbtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(29, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(62, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(97, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 18);
            this.label1.TabIndex = 30;
            this.label1.Text = "Print COF:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 35;
            this.label2.Text = "COF No.:";
            // 
            // PrintCOF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PrintCOFtxt);
            this.Controls.Add(this.PrintCancelbtn);
            this.Controls.Add(this.RefundViewbtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "PrintCOF";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PrintCOF";
            this.Load += new System.EventHandler(this.PrintCOF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PrintCOFtxt;
        private System.Windows.Forms.Button PrintCancelbtn;
        private System.Windows.Forms.Button RefundViewbtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}