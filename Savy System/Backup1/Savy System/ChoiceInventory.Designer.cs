namespace WindowsApplication1
{
    partial class ChoiceInventory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChoiceInventory));
            this.InvCancelbtn = new System.Windows.Forms.Button();
            this.InvViewbtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Itemnmebtn = new System.Windows.Forms.RadioButton();
            this.ItemIDbtn = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.InvUptxt = new System.Windows.Forms.TextBox();
            this.InvFrmtxt = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // InvCancelbtn
            // 
            this.InvCancelbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InvCancelbtn.Location = new System.Drawing.Point(166, 267);
            this.InvCancelbtn.Name = "InvCancelbtn";
            this.InvCancelbtn.Size = new System.Drawing.Size(75, 36);
            this.InvCancelbtn.TabIndex = 19;
            this.InvCancelbtn.Text = "Cancel";
            this.InvCancelbtn.UseVisualStyleBackColor = true;
            this.InvCancelbtn.Click += new System.EventHandler(this.InvCancelbtn_Click);
            // 
            // InvViewbtn
            // 
            this.InvViewbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InvViewbtn.Location = new System.Drawing.Point(64, 267);
            this.InvViewbtn.Name = "InvViewbtn";
            this.InvViewbtn.Size = new System.Drawing.Size(75, 36);
            this.InvViewbtn.TabIndex = 18;
            this.InvViewbtn.Text = "View";
            this.InvViewbtn.UseVisualStyleBackColor = true;
            this.InvViewbtn.Click += new System.EventHandler(this.InvViewbtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(21, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(79, 62);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(101, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 18);
            this.label1.TabIndex = 16;
            this.label1.Text = "View Inventory by:";
            // 
            // Itemnmebtn
            // 
            this.Itemnmebtn.AutoSize = true;
            this.Itemnmebtn.Checked = true;
            this.Itemnmebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Itemnmebtn.Location = new System.Drawing.Point(103, 181);
            this.Itemnmebtn.Name = "Itemnmebtn";
            this.Itemnmebtn.Size = new System.Drawing.Size(91, 20);
            this.Itemnmebtn.TabIndex = 15;
            this.Itemnmebtn.TabStop = true;
            this.Itemnmebtn.Text = "Item Name";
            this.Itemnmebtn.UseVisualStyleBackColor = true;
            this.Itemnmebtn.CheckedChanged += new System.EventHandler(this.Itemnmebtn_CheckedChanged);
            // 
            // ItemIDbtn
            // 
            this.ItemIDbtn.AutoSize = true;
            this.ItemIDbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemIDbtn.Location = new System.Drawing.Point(103, 84);
            this.ItemIDbtn.Name = "ItemIDbtn";
            this.ItemIDbtn.Size = new System.Drawing.Size(67, 20);
            this.ItemIDbtn.TabIndex = 14;
            this.ItemIDbtn.TabStop = true;
            this.ItemIDbtn.Text = "Item ID";
            this.ItemIDbtn.UseVisualStyleBackColor = true;
            this.ItemIDbtn.CheckedChanged += new System.EventHandler(this.ItemIDbtn_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(103, 227);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(63, 20);
            this.radioButton1.TabIndex = 20;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Status";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(124, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 16);
            this.label4.TabIndex = 24;
            this.label4.Text = "Up to";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(124, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 16);
            this.label5.TabIndex = 23;
            this.label5.Text = "From";
            // 
            // InvUptxt
            // 
            this.InvUptxt.Enabled = false;
            this.InvUptxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InvUptxt.Location = new System.Drawing.Point(165, 145);
            this.InvUptxt.Name = "InvUptxt";
            this.InvUptxt.Size = new System.Drawing.Size(100, 22);
            this.InvUptxt.TabIndex = 22;
            this.InvUptxt.TextChanged += new System.EventHandler(this.InvUptxt_TextChanged_1);
            // 
            // InvFrmtxt
            // 
            this.InvFrmtxt.Enabled = false;
            this.InvFrmtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InvFrmtxt.Location = new System.Drawing.Point(165, 119);
            this.InvFrmtxt.Name = "InvFrmtxt";
            this.InvFrmtxt.Size = new System.Drawing.Size(100, 22);
            this.InvFrmtxt.TabIndex = 21;
            this.InvFrmtxt.TextChanged += new System.EventHandler(this.InvFrmtxt_TextChanged);
            // 
            // ChoiceInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 339);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.InvUptxt);
            this.Controls.Add(this.InvFrmtxt);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.InvCancelbtn);
            this.Controls.Add(this.InvViewbtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Itemnmebtn);
            this.Controls.Add(this.ItemIDbtn);
            this.MaximizeBox = false;
            this.Name = "ChoiceInventory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChoiceInventory";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button InvCancelbtn;
        private System.Windows.Forms.Button InvViewbtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton Itemnmebtn;
        private System.Windows.Forms.RadioButton ItemIDbtn;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox InvUptxt;
        private System.Windows.Forms.TextBox InvFrmtxt;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}