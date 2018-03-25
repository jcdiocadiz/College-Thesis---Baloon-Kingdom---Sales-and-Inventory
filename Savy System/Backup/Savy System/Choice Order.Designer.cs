namespace WindowsApplication1
{
    partial class Choice_Order
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Choice_Order));
            this.OrDatebtn = new System.Windows.Forms.RadioButton();
            this.OrCancelbtn = new System.Windows.Forms.Button();
            this.OrViewbtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.OrViewrbtn = new System.Windows.Forms.RadioButton();
            this.COFNorbtn = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.OrCOFFrmtxt = new System.Windows.Forms.TextBox();
            this.OrCOFUptxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.OrderFrmpick = new System.Windows.Forms.DateTimePicker();
            this.OrderUppick = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // OrDatebtn
            // 
            this.OrDatebtn.AutoSize = true;
            this.OrDatebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrDatebtn.Location = new System.Drawing.Point(53, 213);
            this.OrDatebtn.Name = "OrDatebtn";
            this.OrDatebtn.Size = new System.Drawing.Size(108, 20);
            this.OrDatebtn.TabIndex = 27;
            this.OrDatebtn.Text = "Date Ordered";
            this.OrDatebtn.UseVisualStyleBackColor = true;
            this.OrDatebtn.CheckedChanged += new System.EventHandler(this.OrDatebtn_CheckedChanged);
            // 
            // OrCancelbtn
            // 
            this.OrCancelbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrCancelbtn.Location = new System.Drawing.Point(174, 310);
            this.OrCancelbtn.Name = "OrCancelbtn";
            this.OrCancelbtn.Size = new System.Drawing.Size(75, 41);
            this.OrCancelbtn.TabIndex = 26;
            this.OrCancelbtn.Text = "Cancel";
            this.OrCancelbtn.UseVisualStyleBackColor = true;
            this.OrCancelbtn.Click += new System.EventHandler(this.OrCancelbtn_Click);
            // 
            // OrViewbtn
            // 
            this.OrViewbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrViewbtn.Location = new System.Drawing.Point(72, 310);
            this.OrViewbtn.Name = "OrViewbtn";
            this.OrViewbtn.Size = new System.Drawing.Size(75, 41);
            this.OrViewbtn.TabIndex = 25;
            this.OrViewbtn.Text = "View";
            this.OrViewbtn.UseVisualStyleBackColor = true;
            this.OrViewbtn.Click += new System.EventHandler(this.OrViewbtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(26, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(72, 72);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(106, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 18);
            this.label1.TabIndex = 23;
            this.label1.Text = "View Order by:";
            // 
            // OrViewrbtn
            // 
            this.OrViewrbtn.AutoSize = true;
            this.OrViewrbtn.Checked = true;
            this.OrViewrbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrViewrbtn.Location = new System.Drawing.Point(53, 103);
            this.OrViewrbtn.Name = "OrViewrbtn";
            this.OrViewrbtn.Size = new System.Drawing.Size(73, 20);
            this.OrViewrbtn.TabIndex = 22;
            this.OrViewrbtn.TabStop = true;
            this.OrViewrbtn.Text = "View All";
            this.OrViewrbtn.UseVisualStyleBackColor = true;
            this.OrViewrbtn.CheckedChanged += new System.EventHandler(this.OrViewrbtn_CheckedChanged);
            // 
            // COFNorbtn
            // 
            this.COFNorbtn.AutoSize = true;
            this.COFNorbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.COFNorbtn.Location = new System.Drawing.Point(53, 139);
            this.COFNorbtn.Name = "COFNorbtn";
            this.COFNorbtn.Size = new System.Drawing.Size(77, 20);
            this.COFNorbtn.TabIndex = 21;
            this.COFNorbtn.Text = "COF No.";
            this.COFNorbtn.UseVisualStyleBackColor = true;
            this.COFNorbtn.CheckedChanged += new System.EventHandler(this.COFNorbtn_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(69, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 16);
            this.label2.TabIndex = 28;
            this.label2.Text = "From";
            // 
            // OrCOFFrmtxt
            // 
            this.OrCOFFrmtxt.Enabled = false;
            this.OrCOFFrmtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrCOFFrmtxt.Location = new System.Drawing.Point(110, 159);
            this.OrCOFFrmtxt.Name = "OrCOFFrmtxt";
            this.OrCOFFrmtxt.Size = new System.Drawing.Size(100, 22);
            this.OrCOFFrmtxt.TabIndex = 29;
            this.OrCOFFrmtxt.TextChanged += new System.EventHandler(this.OrCOFFrmtxt_TextChanged);
            // 
            // OrCOFUptxt
            // 
            this.OrCOFUptxt.Enabled = false;
            this.OrCOFUptxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrCOFUptxt.Location = new System.Drawing.Point(110, 187);
            this.OrCOFUptxt.Name = "OrCOFUptxt";
            this.OrCOFUptxt.Size = new System.Drawing.Size(100, 22);
            this.OrCOFUptxt.TabIndex = 31;
            this.OrCOFUptxt.TextChanged += new System.EventHandler(this.OrCOFUptxt_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(69, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 16);
            this.label3.TabIndex = 30;
            this.label3.Text = "Up to";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(50, 277);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 16);
            this.label4.TabIndex = 34;
            this.label4.Text = "Up to";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(50, 249);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 16);
            this.label5.TabIndex = 32;
            this.label5.Text = "From";
            // 
            // OrderFrmpick
            // 
            this.OrderFrmpick.Enabled = false;
            this.OrderFrmpick.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderFrmpick.Location = new System.Drawing.Point(86, 246);
            this.OrderFrmpick.Name = "OrderFrmpick";
            this.OrderFrmpick.Size = new System.Drawing.Size(221, 22);
            this.OrderFrmpick.TabIndex = 35;
            // 
            // OrderUppick
            // 
            this.OrderUppick.Enabled = false;
            this.OrderUppick.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderUppick.Location = new System.Drawing.Point(86, 272);
            this.OrderUppick.Name = "OrderUppick";
            this.OrderUppick.Size = new System.Drawing.Size(221, 22);
            this.OrderUppick.TabIndex = 36;
            // 
            // Choice_Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 376);
            this.Controls.Add(this.OrderUppick);
            this.Controls.Add(this.OrderFrmpick);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.OrCOFUptxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.OrCOFFrmtxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.OrDatebtn);
            this.Controls.Add(this.OrCancelbtn);
            this.Controls.Add(this.OrViewbtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OrViewrbtn);
            this.Controls.Add(this.COFNorbtn);
            this.MaximizeBox = false;
            this.Name = "Choice_Order";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Choice_Order";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton OrDatebtn;
        private System.Windows.Forms.Button OrCancelbtn;
        private System.Windows.Forms.Button OrViewbtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton OrViewrbtn;
        private System.Windows.Forms.RadioButton COFNorbtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox OrCOFFrmtxt;
        private System.Windows.Forms.TextBox OrCOFUptxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DateTimePicker OrderFrmpick;
        private System.Windows.Forms.DateTimePicker OrderUppick;
    }
}