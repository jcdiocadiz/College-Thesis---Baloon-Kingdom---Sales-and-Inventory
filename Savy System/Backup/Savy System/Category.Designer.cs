namespace WindowsApplication1
{
    partial class Category
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
            this.ItemCatCombo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SubCatCombo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SpecCatCombo = new System.Windows.Forms.ComboBox();
            this.AddBtn = new System.Windows.Forms.Button();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.Clrbtn = new System.Windows.Forms.Button();
            this.label114 = new System.Windows.Forms.Label();
            this.label103 = new System.Windows.Forms.Label();
            this.label86 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SpecificCatTxt = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.SubComboBox = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.CatNameCombo1 = new System.Windows.Forms.ComboBox();
            this.FROMGrpBox = new System.Windows.Forms.GroupBox();
            this.TOGrpBox = new System.Windows.Forms.GroupBox();
            this.headerLbl = new System.Windows.Forms.Label();
            this.closeBtn = new System.Windows.Forms.Button();
            this.passtxt = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.FROMGrpBox.SuspendLayout();
            this.TOGrpBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ItemCatCombo
            // 
            this.ItemCatCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ItemCatCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemCatCombo.FormattingEnabled = true;
            this.ItemCatCombo.Location = new System.Drawing.Point(136, 26);
            this.ItemCatCombo.Name = "ItemCatCombo";
            this.ItemCatCombo.Size = new System.Drawing.Size(223, 24);
            this.ItemCatCombo.TabIndex = 0;
            this.ItemCatCombo.SelectedIndexChanged += new System.EventHandler(this.ItemCatCombo_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Category Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sub Category";
            // 
            // SubCatCombo
            // 
            this.SubCatCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubCatCombo.FormattingEnabled = true;
            this.SubCatCombo.Location = new System.Drawing.Point(136, 76);
            this.SubCatCombo.Name = "SubCatCombo";
            this.SubCatCombo.Size = new System.Drawing.Size(223, 24);
            this.SubCatCombo.TabIndex = 2;
            this.SubCatCombo.SelectedIndexChanged += new System.EventHandler(this.SubCatCombo_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Specific Category";
            // 
            // SpecCatCombo
            // 
            this.SpecCatCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SpecCatCombo.FormattingEnabled = true;
            this.SpecCatCombo.Location = new System.Drawing.Point(136, 124);
            this.SpecCatCombo.Name = "SpecCatCombo";
            this.SpecCatCombo.Size = new System.Drawing.Size(223, 24);
            this.SpecCatCombo.TabIndex = 4;
            // 
            // AddBtn
            // 
            this.AddBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBtn.Location = new System.Drawing.Point(248, 350);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(80, 38);
            this.AddBtn.TabIndex = 6;
            this.AddBtn.Text = "Add";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateBtn.Location = new System.Drawing.Point(354, 350);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(80, 38);
            this.UpdateBtn.TabIndex = 7;
            this.UpdateBtn.Text = "Update";
            this.UpdateBtn.UseVisualStyleBackColor = true;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(268, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(484, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Category/Sub Category and Specific Category Maintenance";
            // 
            // Clrbtn
            // 
            this.Clrbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clrbtn.Location = new System.Drawing.Point(556, 350);
            this.Clrbtn.Name = "Clrbtn";
            this.Clrbtn.Size = new System.Drawing.Size(80, 38);
            this.Clrbtn.TabIndex = 9;
            this.Clrbtn.Text = "Clear";
            this.Clrbtn.UseVisualStyleBackColor = true;
            this.Clrbtn.Click += new System.EventHandler(this.Clrbtn_Click);
            // 
            // label114
            // 
            this.label114.AutoSize = true;
            this.label114.BackColor = System.Drawing.SystemColors.Control;
            this.label114.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label114.ForeColor = System.Drawing.Color.DarkOrange;
            this.label114.Location = new System.Drawing.Point(379, 127);
            this.label114.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label114.Name = "label114";
            this.label114.Size = new System.Drawing.Size(18, 24);
            this.label114.TabIndex = 210;
            this.label114.Text = "*";
            // 
            // label103
            // 
            this.label103.AutoSize = true;
            this.label103.BackColor = System.Drawing.SystemColors.Control;
            this.label103.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label103.ForeColor = System.Drawing.Color.DarkOrange;
            this.label103.Location = new System.Drawing.Point(379, 79);
            this.label103.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label103.Name = "label103";
            this.label103.Size = new System.Drawing.Size(18, 24);
            this.label103.TabIndex = 209;
            this.label103.Text = "*";
            // 
            // label86
            // 
            this.label86.AutoSize = true;
            this.label86.BackColor = System.Drawing.SystemColors.Control;
            this.label86.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label86.ForeColor = System.Drawing.Color.DarkOrange;
            this.label86.Location = new System.Drawing.Point(379, 29);
            this.label86.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label86.Name = "label86";
            this.label86.Size = new System.Drawing.Size(18, 24);
            this.label86.TabIndex = 208;
            this.label86.Text = "*";
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(454, 350);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(80, 38);
            this.btnSave.TabIndex = 211;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkOrange;
            this.label5.Location = new System.Drawing.Point(396, 129);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 24);
            this.label5.TabIndex = 220;
            this.label5.Text = "*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Control;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkOrange;
            this.label6.Location = new System.Drawing.Point(396, 81);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 24);
            this.label6.TabIndex = 219;
            this.label6.Text = "*";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.Control;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkOrange;
            this.label7.Location = new System.Drawing.Point(396, 31);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 24);
            this.label7.TabIndex = 218;
            this.label7.Text = "*";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(32, 129);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 17);
            this.label8.TabIndex = 217;
            this.label8.Text = "Specific Category";
            // 
            // SpecificCatTxt
            // 
            this.SpecificCatTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SpecificCatTxt.FormattingEnabled = true;
            this.SpecificCatTxt.Location = new System.Drawing.Point(153, 126);
            this.SpecificCatTxt.Name = "SpecificCatTxt";
            this.SpecificCatTxt.Size = new System.Drawing.Size(223, 24);
            this.SpecificCatTxt.TabIndex = 216;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(32, 81);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 17);
            this.label9.TabIndex = 215;
            this.label9.Text = "Sub Category";
            // 
            // SubComboBox
            // 
            this.SubComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubComboBox.FormattingEnabled = true;
            this.SubComboBox.Location = new System.Drawing.Point(153, 78);
            this.SubComboBox.Name = "SubComboBox";
            this.SubComboBox.Size = new System.Drawing.Size(223, 24);
            this.SubComboBox.TabIndex = 214;
            this.SubComboBox.SelectedIndexChanged += new System.EventHandler(this.SubComboBox_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(32, 31);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(106, 17);
            this.label10.TabIndex = 213;
            this.label10.Text = "Category Name";
            // 
            // CatNameCombo1
            // 
            this.CatNameCombo1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CatNameCombo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CatNameCombo1.FormattingEnabled = true;
            this.CatNameCombo1.Location = new System.Drawing.Point(153, 28);
            this.CatNameCombo1.Name = "CatNameCombo1";
            this.CatNameCombo1.Size = new System.Drawing.Size(223, 24);
            this.CatNameCombo1.TabIndex = 212;
            this.CatNameCombo1.SelectedIndexChanged += new System.EventHandler(this.CatNameCombo1_SelectedIndexChanged);
            // 
            // FROMGrpBox
            // 
            this.FROMGrpBox.Controls.Add(this.SpecCatCombo);
            this.FROMGrpBox.Controls.Add(this.ItemCatCombo);
            this.FROMGrpBox.Controls.Add(this.label1);
            this.FROMGrpBox.Controls.Add(this.SubCatCombo);
            this.FROMGrpBox.Controls.Add(this.label2);
            this.FROMGrpBox.Controls.Add(this.label3);
            this.FROMGrpBox.Controls.Add(this.label86);
            this.FROMGrpBox.Controls.Add(this.label103);
            this.FROMGrpBox.Controls.Add(this.label114);
            this.FROMGrpBox.Enabled = false;
            this.FROMGrpBox.Location = new System.Drawing.Point(59, 98);
            this.FROMGrpBox.Name = "FROMGrpBox";
            this.FROMGrpBox.Size = new System.Drawing.Size(427, 179);
            this.FROMGrpBox.TabIndex = 221;
            this.FROMGrpBox.TabStop = false;
            // 
            // TOGrpBox
            // 
            this.TOGrpBox.Controls.Add(this.label8);
            this.TOGrpBox.Controls.Add(this.CatNameCombo1);
            this.TOGrpBox.Controls.Add(this.label5);
            this.TOGrpBox.Controls.Add(this.label10);
            this.TOGrpBox.Controls.Add(this.label6);
            this.TOGrpBox.Controls.Add(this.SubComboBox);
            this.TOGrpBox.Controls.Add(this.label7);
            this.TOGrpBox.Controls.Add(this.label9);
            this.TOGrpBox.Controls.Add(this.SpecificCatTxt);
            this.TOGrpBox.Enabled = false;
            this.TOGrpBox.Location = new System.Drawing.Point(506, 98);
            this.TOGrpBox.Name = "TOGrpBox";
            this.TOGrpBox.Size = new System.Drawing.Size(416, 179);
            this.TOGrpBox.TabIndex = 222;
            this.TOGrpBox.TabStop = false;
            // 
            // headerLbl
            // 
            this.headerLbl.AutoSize = true;
            this.headerLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLbl.Location = new System.Drawing.Point(456, 68);
            this.headerLbl.Name = "headerLbl";
            this.headerLbl.Size = new System.Drawing.Size(0, 17);
            this.headerLbl.TabIndex = 221;
            // 
            // closeBtn
            // 
            this.closeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeBtn.Location = new System.Drawing.Point(654, 350);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(80, 38);
            this.closeBtn.TabIndex = 223;
            this.closeBtn.Text = "Close";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // passtxt
            // 
            this.passtxt.Location = new System.Drawing.Point(420, 305);
            this.passtxt.Name = "passtxt";
            this.passtxt.PasswordChar = '*';
            this.passtxt.Size = new System.Drawing.Size(236, 20);
            this.passtxt.TabIndex = 224;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(306, 308);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(90, 13);
            this.label11.TabIndex = 225;
            this.label11.Text = "System Password";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.Control;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.DarkOrange;
            this.label12.Location = new System.Drawing.Point(663, 305);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(18, 24);
            this.label12.TabIndex = 221;
            this.label12.Text = "*";
            // 
            // Category
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 427);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.passtxt);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.headerLbl);
            this.Controls.Add(this.TOGrpBox);
            this.Controls.Add(this.FROMGrpBox);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.Clrbtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.AddBtn);
            this.MaximizeBox = false;
            this.Name = "Category";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Category";
            this.Load += new System.EventHandler(this.Category_Load);
            this.FROMGrpBox.ResumeLayout(false);
            this.FROMGrpBox.PerformLayout();
            this.TOGrpBox.ResumeLayout(false);
            this.TOGrpBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ItemCatCombo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox SubCatCombo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox SpecCatCombo;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Clrbtn;
        private System.Windows.Forms.Label label114;
        private System.Windows.Forms.Label label103;
        private System.Windows.Forms.Label label86;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox SpecificCatTxt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox SubComboBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox CatNameCombo1;
        private System.Windows.Forms.GroupBox FROMGrpBox;
        private System.Windows.Forms.GroupBox TOGrpBox;
        private System.Windows.Forms.Label headerLbl;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.TextBox passtxt;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
    }
}