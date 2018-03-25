namespace WindowsApplication1
{
    partial class UpdatQty
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
            this.addbtn = new System.Windows.Forms.RadioButton();
            this.subbtn = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.qtytxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.okbtn = new System.Windows.Forms.Button();
            this.canbtn = new System.Windows.Forms.Button();
            this.label103 = new System.Windows.Forms.Label();
            this.idlbl = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.reasontxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.donebytxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Syspasstxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addbtn
            // 
            this.addbtn.AutoSize = true;
            this.addbtn.Checked = true;
            this.addbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addbtn.Location = new System.Drawing.Point(289, 139);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(51, 20);
            this.addbtn.TabIndex = 0;
            this.addbtn.TabStop = true;
            this.addbtn.Text = "Add";
            this.addbtn.UseVisualStyleBackColor = true;
            // 
            // subbtn
            // 
            this.subbtn.AutoSize = true;
            this.subbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subbtn.Location = new System.Drawing.Point(425, 139);
            this.subbtn.Name = "subbtn";
            this.subbtn.Size = new System.Drawing.Size(75, 20);
            this.subbtn.TabIndex = 1;
            this.subbtn.TabStop = true;
            this.subbtn.Text = "Subtract";
            this.subbtn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(225, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Update Inventory Item Quantity";
            // 
            // qtytxt
            // 
            this.qtytxt.Location = new System.Drawing.Point(289, 176);
            this.qtytxt.Name = "qtytxt";
            this.qtytxt.Size = new System.Drawing.Size(236, 20);
            this.qtytxt.TabIndex = 3;
            this.qtytxt.TextChanged += new System.EventHandler(this.qtytxt_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(117, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Quantity";
            // 
            // okbtn
            // 
            this.okbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.okbtn.Location = new System.Drawing.Point(289, 330);
            this.okbtn.Name = "okbtn";
            this.okbtn.Size = new System.Drawing.Size(75, 39);
            this.okbtn.TabIndex = 5;
            this.okbtn.Text = "OK";
            this.okbtn.UseVisualStyleBackColor = true;
            this.okbtn.Click += new System.EventHandler(this.okbtn_Click);
            // 
            // canbtn
            // 
            this.canbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.canbtn.Location = new System.Drawing.Point(382, 330);
            this.canbtn.Name = "canbtn";
            this.canbtn.Size = new System.Drawing.Size(75, 39);
            this.canbtn.TabIndex = 6;
            this.canbtn.Text = "Cancel";
            this.canbtn.UseVisualStyleBackColor = true;
            this.canbtn.Click += new System.EventHandler(this.canbtn_Click);
            // 
            // label103
            // 
            this.label103.AutoSize = true;
            this.label103.BackColor = System.Drawing.SystemColors.Control;
            this.label103.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label103.ForeColor = System.Drawing.Color.DarkOrange;
            this.label103.Location = new System.Drawing.Point(532, 180);
            this.label103.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label103.Name = "label103";
            this.label103.Size = new System.Drawing.Size(18, 24);
            this.label103.TabIndex = 207;
            this.label103.Text = "*";
            // 
            // idlbl
            // 
            this.idlbl.AutoSize = true;
            this.idlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idlbl.Location = new System.Drawing.Point(290, 79);
            this.idlbl.Name = "idlbl";
            this.idlbl.Size = new System.Drawing.Size(41, 16);
            this.idlbl.TabIndex = 209;
            this.idlbl.Text = "None";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(117, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 16);
            this.label4.TabIndex = 211;
            this.label4.Text = "Reason";
            // 
            // reasontxt
            // 
            this.reasontxt.Location = new System.Drawing.Point(289, 202);
            this.reasontxt.Multiline = true;
            this.reasontxt.Name = "reasontxt";
            this.reasontxt.Size = new System.Drawing.Size(236, 49);
            this.reasontxt.TabIndex = 210;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(117, 261);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 16);
            this.label5.TabIndex = 213;
            this.label5.Text = "Transaction done by:";
            // 
            // donebytxt
            // 
            this.donebytxt.Location = new System.Drawing.Point(289, 260);
            this.donebytxt.Name = "donebytxt";
            this.donebytxt.Size = new System.Drawing.Size(236, 20);
            this.donebytxt.TabIndex = 212;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(117, 287);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 16);
            this.label6.TabIndex = 215;
            this.label6.Text = "System Password";
            // 
            // Syspasstxt
            // 
            this.Syspasstxt.Location = new System.Drawing.Point(289, 286);
            this.Syspasstxt.Name = "Syspasstxt";
            this.Syspasstxt.PasswordChar = '*';
            this.Syspasstxt.Size = new System.Drawing.Size(236, 20);
            this.Syspasstxt.TabIndex = 214;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(115, 144);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 16);
            this.label7.TabIndex = 216;
            this.label7.Text = "Type of Transaction:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(117, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 16);
            this.label3.TabIndex = 217;
            this.label3.Text = "Item ID";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(117, 110);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 16);
            this.label8.TabIndex = 218;
            this.label8.Text = "Item Name";
            // 
            // txtname
            // 
            this.txtname.AutoSize = true;
            this.txtname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtname.Location = new System.Drawing.Point(290, 110);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(41, 16);
            this.txtname.TabIndex = 219;
            this.txtname.Text = "None";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.Control;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.DarkOrange;
            this.label10.Location = new System.Drawing.Point(532, 214);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(18, 24);
            this.label10.TabIndex = 220;
            this.label10.Text = "*";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.Control;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.DarkOrange;
            this.label11.Location = new System.Drawing.Point(532, 261);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(18, 24);
            this.label11.TabIndex = 221;
            this.label11.Text = "*";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.Control;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.DarkOrange;
            this.label12.Location = new System.Drawing.Point(532, 287);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(18, 24);
            this.label12.TabIndex = 222;
            this.label12.Text = "*";
            // 
            // UpdatQty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 381);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Syspasstxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.donebytxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.reasontxt);
            this.Controls.Add(this.idlbl);
            this.Controls.Add(this.label103);
            this.Controls.Add(this.canbtn);
            this.Controls.Add(this.okbtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.qtytxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.subbtn);
            this.Controls.Add(this.addbtn);
            this.MaximizeBox = false;
            this.Name = "UpdatQty";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventory";
            this.Load += new System.EventHandler(this.UpdatQty_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton addbtn;
        private System.Windows.Forms.RadioButton subbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox qtytxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button okbtn;
        private System.Windows.Forms.Button canbtn;
        private System.Windows.Forms.Label label103;
        private System.Windows.Forms.Label idlbl;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox reasontxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox donebytxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Syspasstxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label txtname;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
    }
}