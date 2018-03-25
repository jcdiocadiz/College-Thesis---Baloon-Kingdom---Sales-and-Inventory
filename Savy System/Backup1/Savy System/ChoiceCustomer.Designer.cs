namespace WindowsApplication1
{
    partial class ChoiceCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChoiceCustomer));
            this.CustIDrbtn = new System.Windows.Forms.RadioButton();
            this.Custidbtn = new System.Windows.Forms.RadioButton();
            this.Lnamebtn = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CustViewbtn = new System.Windows.Forms.Button();
            this.Cancelbtn = new System.Windows.Forms.Button();
            this.CustLasFrmtxt = new System.Windows.Forms.TextBox();
            this.CustLasUptxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CustIDuptxt = new System.Windows.Forms.TextBox();
            this.CustIDfrmtxt = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // CustIDrbtn
            // 
            this.CustIDrbtn.AutoSize = true;
            this.CustIDrbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustIDrbtn.Location = new System.Drawing.Point(83, 66);
            this.CustIDrbtn.Name = "CustIDrbtn";
            this.CustIDrbtn.Size = new System.Drawing.Size(73, 20);
            this.CustIDrbtn.TabIndex = 0;
            this.CustIDrbtn.TabStop = true;
            this.CustIDrbtn.Text = "View All";
            this.CustIDrbtn.UseVisualStyleBackColor = true;
            // 
            // Custidbtn
            // 
            this.Custidbtn.AutoSize = true;
            this.Custidbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Custidbtn.Location = new System.Drawing.Point(83, 99);
            this.Custidbtn.Name = "Custidbtn";
            this.Custidbtn.Size = new System.Drawing.Size(96, 20);
            this.Custidbtn.TabIndex = 1;
            this.Custidbtn.TabStop = true;
            this.Custidbtn.Text = "CustomerID";
            this.Custidbtn.UseVisualStyleBackColor = true;
            this.Custidbtn.CheckedChanged += new System.EventHandler(this.Custidbtn_CheckedChanged);
            // 
            // Lnamebtn
            // 
            this.Lnamebtn.AutoSize = true;
            this.Lnamebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lnamebtn.Location = new System.Drawing.Point(83, 176);
            this.Lnamebtn.Name = "Lnamebtn";
            this.Lnamebtn.Size = new System.Drawing.Size(85, 20);
            this.Lnamebtn.TabIndex = 2;
            this.Lnamebtn.TabStop = true;
            this.Lnamebtn.Text = "Lastname";
            this.Lnamebtn.UseVisualStyleBackColor = true;
            this.Lnamebtn.CheckedChanged += new System.EventHandler(this.Lnamebtn_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(80, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "View Customer by:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(62, 50);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // CustViewbtn
            // 
            this.CustViewbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustViewbtn.Location = new System.Drawing.Point(65, 272);
            this.CustViewbtn.Name = "CustViewbtn";
            this.CustViewbtn.Size = new System.Drawing.Size(75, 39);
            this.CustViewbtn.TabIndex = 5;
            this.CustViewbtn.Text = "View";
            this.CustViewbtn.UseVisualStyleBackColor = true;
            this.CustViewbtn.Click += new System.EventHandler(this.CustViewbtn_Click);
            // 
            // Cancelbtn
            // 
            this.Cancelbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancelbtn.Location = new System.Drawing.Point(167, 272);
            this.Cancelbtn.Name = "Cancelbtn";
            this.Cancelbtn.Size = new System.Drawing.Size(75, 39);
            this.Cancelbtn.TabIndex = 6;
            this.Cancelbtn.Text = "Cancel";
            this.Cancelbtn.UseVisualStyleBackColor = true;
            this.Cancelbtn.Click += new System.EventHandler(this.Cancelbtn_Click_1);
            // 
            // CustLasFrmtxt
            // 
            this.CustLasFrmtxt.Enabled = false;
            this.CustLasFrmtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustLasFrmtxt.Location = new System.Drawing.Point(142, 202);
            this.CustLasFrmtxt.Name = "CustLasFrmtxt";
            this.CustLasFrmtxt.Size = new System.Drawing.Size(100, 22);
            this.CustLasFrmtxt.TabIndex = 7;
            this.CustLasFrmtxt.TextChanged += new System.EventHandler(this.CustLasFrmtxt_TextChanged);
            this.CustLasFrmtxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CustLasFrmtxt_KeyPress);
            // 
            // CustLasUptxt
            // 
            this.CustLasUptxt.Enabled = false;
            this.CustLasUptxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustLasUptxt.Location = new System.Drawing.Point(142, 228);
            this.CustLasUptxt.Name = "CustLasUptxt";
            this.CustLasUptxt.Size = new System.Drawing.Size(100, 22);
            this.CustLasUptxt.TabIndex = 8;
            this.CustLasUptxt.TextChanged += new System.EventHandler(this.CustLasUptxt_TextChanged);
            this.CustLasUptxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CustLasUptxt_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(101, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "From";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(101, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Up to";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(101, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "Up to";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(101, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "From";
            // 
            // CustIDuptxt
            // 
            this.CustIDuptxt.Enabled = false;
            this.CustIDuptxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustIDuptxt.Location = new System.Drawing.Point(142, 151);
            this.CustIDuptxt.Name = "CustIDuptxt";
            this.CustIDuptxt.Size = new System.Drawing.Size(100, 22);
            this.CustIDuptxt.TabIndex = 12;
            this.CustIDuptxt.TextChanged += new System.EventHandler(this.CustIDuptxt_TextChanged);
            // 
            // CustIDfrmtxt
            // 
            this.CustIDfrmtxt.Enabled = false;
            this.CustIDfrmtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustIDfrmtxt.Location = new System.Drawing.Point(142, 125);
            this.CustIDfrmtxt.Name = "CustIDfrmtxt";
            this.CustIDfrmtxt.Size = new System.Drawing.Size(100, 22);
            this.CustIDfrmtxt.TabIndex = 11;
            this.CustIDfrmtxt.TextChanged += new System.EventHandler(this.CustIDfrmtxt_TextChanged);
            // 
            // ChoiceCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 339);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CustIDuptxt);
            this.Controls.Add(this.CustIDfrmtxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CustLasUptxt);
            this.Controls.Add(this.CustLasFrmtxt);
            this.Controls.Add(this.Cancelbtn);
            this.Controls.Add(this.CustViewbtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Lnamebtn);
            this.Controls.Add(this.Custidbtn);
            this.Controls.Add(this.CustIDrbtn);
            this.MaximizeBox = false;
            this.Name = "ChoiceCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChoiceCustomer";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton CustIDrbtn;
        private System.Windows.Forms.RadioButton Custidbtn;
        private System.Windows.Forms.RadioButton Lnamebtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button CustViewbtn;
        private System.Windows.Forms.Button Cancelbtn;
        private System.Windows.Forms.TextBox CustLasFrmtxt;
        private System.Windows.Forms.TextBox CustLasUptxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox CustIDuptxt;
        private System.Windows.Forms.TextBox CustIDfrmtxt;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}