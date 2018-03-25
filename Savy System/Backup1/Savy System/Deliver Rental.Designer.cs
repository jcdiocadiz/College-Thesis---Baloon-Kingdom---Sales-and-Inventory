namespace WindowsApplication1
{
    partial class frmDeliverRental
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.RentDataGrid = new System.Windows.Forms.DataGridView();
            this.CustIDlbl = new System.Windows.Forms.Label();
            this.label269 = new System.Windows.Forms.Label();
            this.COFNumLbl = new System.Windows.Forms.Label();
            this.label264 = new System.Windows.Forms.Label();
            this.DateReleased = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.TimeReleased = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.RentOKBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.RecordedByTxt = new System.Windows.Forms.TextBox();
            this.label141 = new System.Windows.Forms.Label();
            this.PickByTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DeliveredByTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.RentSecurityAmt = new System.Windows.Forms.TextBox();
            this.GetIDChk = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.RentAmtTxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.OverallQtyTxt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label289 = new System.Windows.Forms.Label();
            this.label126 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.Syspasstxt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.RentDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // RentDataGrid
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.RentDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.RentDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.RentDataGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.RentDataGrid.EnableHeadersVisualStyles = false;
            this.RentDataGrid.Location = new System.Drawing.Point(12, 199);
            this.RentDataGrid.MultiSelect = false;
            this.RentDataGrid.Name = "RentDataGrid";
            this.RentDataGrid.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.RentDataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.RentDataGrid.RowHeadersVisible = false;
            this.RentDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.RentDataGrid.Size = new System.Drawing.Size(1067, 381);
            this.RentDataGrid.TabIndex = 0;
            // 
            // CustIDlbl
            // 
            this.CustIDlbl.AutoSize = true;
            this.CustIDlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustIDlbl.Location = new System.Drawing.Point(145, 53);
            this.CustIDlbl.Name = "CustIDlbl";
            this.CustIDlbl.Size = new System.Drawing.Size(41, 16);
            this.CustIDlbl.TabIndex = 16;
            this.CustIDlbl.Text = "None";
            // 
            // label269
            // 
            this.label269.AutoSize = true;
            this.label269.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label269.Location = new System.Drawing.Point(21, 54);
            this.label269.Name = "label269";
            this.label269.Size = new System.Drawing.Size(84, 16);
            this.label269.TabIndex = 15;
            this.label269.Text = "Customer ID:";
            // 
            // COFNumLbl
            // 
            this.COFNumLbl.AutoSize = true;
            this.COFNumLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.COFNumLbl.Location = new System.Drawing.Point(145, 21);
            this.COFNumLbl.Name = "COFNumLbl";
            this.COFNumLbl.Size = new System.Drawing.Size(41, 16);
            this.COFNumLbl.TabIndex = 14;
            this.COFNumLbl.Text = "None";
            // 
            // label264
            // 
            this.label264.AutoSize = true;
            this.label264.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label264.Location = new System.Drawing.Point(21, 22);
            this.label264.Name = "label264";
            this.label264.Size = new System.Drawing.Size(64, 16);
            this.label264.TabIndex = 13;
            this.label264.Text = "COF NO.:";
            // 
            // DateReleased
            // 
            this.DateReleased.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateReleased.Location = new System.Drawing.Point(147, 84);
            this.DateReleased.Name = "DateReleased";
            this.DateReleased.Size = new System.Drawing.Size(229, 24);
            this.DateReleased.TabIndex = 36;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 16);
            this.label3.TabIndex = 35;
            this.label3.Text = "Date Released";
            // 
            // TimeReleased
            // 
            this.TimeReleased.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeReleased.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.TimeReleased.Location = new System.Drawing.Point(147, 127);
            this.TimeReleased.Name = "TimeReleased";
            this.TimeReleased.Size = new System.Drawing.Size(229, 24);
            this.TimeReleased.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 16);
            this.label2.TabIndex = 33;
            this.label2.Text = "Time Released";
            // 
            // RentOKBtn
            // 
            this.RentOKBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RentOKBtn.Location = new System.Drawing.Point(949, 157);
            this.RentOKBtn.Name = "RentOKBtn";
            this.RentOKBtn.Size = new System.Drawing.Size(102, 36);
            this.RentOKBtn.TabIndex = 51;
            this.RentOKBtn.Text = "DONE";
            this.RentOKBtn.UseVisualStyleBackColor = true;
            this.RentOKBtn.Click += new System.EventHandler(this.RentOKBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(416, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 16);
            this.label6.TabIndex = 56;
            this.label6.Text = "Recorded By:";
            // 
            // RecordedByTxt
            // 
            this.RecordedByTxt.Location = new System.Drawing.Point(560, 128);
            this.RecordedByTxt.Name = "RecordedByTxt";
            this.RecordedByTxt.Size = new System.Drawing.Size(172, 20);
            this.RecordedByTxt.TabIndex = 55;
            this.RecordedByTxt.TextChanged += new System.EventHandler(this.RecordedByTxt_TextChanged);
            this.RecordedByTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RecordedByTxt_KeyPress);
            // 
            // label141
            // 
            this.label141.AutoSize = true;
            this.label141.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label141.Location = new System.Drawing.Point(416, 54);
            this.label141.Name = "label141";
            this.label141.Size = new System.Drawing.Size(93, 16);
            this.label141.TabIndex = 54;
            this.label141.Text = "Picked Up By:";
            // 
            // PickByTxt
            // 
            this.PickByTxt.Location = new System.Drawing.Point(560, 50);
            this.PickByTxt.Name = "PickByTxt";
            this.PickByTxt.Size = new System.Drawing.Size(172, 20);
            this.PickByTxt.TabIndex = 53;
            this.PickByTxt.TextChanged += new System.EventHandler(this.PickByTxt_TextChanged);
            this.PickByTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PickByTxt_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(416, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 58;
            this.label1.Text = "Issued By:";
            // 
            // DeliveredByTxt
            // 
            this.DeliveredByTxt.Location = new System.Drawing.Point(560, 90);
            this.DeliveredByTxt.Name = "DeliveredByTxt";
            this.DeliveredByTxt.Size = new System.Drawing.Size(172, 20);
            this.DeliveredByTxt.TabIndex = 57;
            this.DeliveredByTxt.TextChanged += new System.EventHandler(this.DeliveredByTxt_TextChanged);
            this.DeliveredByTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DeliveredByTxt_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(768, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 16);
            this.label4.TabIndex = 60;
            this.label4.Text = "Rent Deposit";
            // 
            // RentSecurityAmt
            // 
            this.RentSecurityAmt.Enabled = false;
            this.RentSecurityAmt.Location = new System.Drawing.Point(912, 123);
            this.RentSecurityAmt.Name = "RentSecurityAmt";
            this.RentSecurityAmt.Size = new System.Drawing.Size(164, 20);
            this.RentSecurityAmt.TabIndex = 59;
            // 
            // GetIDChk
            // 
            this.GetIDChk.AutoSize = true;
            this.GetIDChk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GetIDChk.Location = new System.Drawing.Point(419, 20);
            this.GetIDChk.Name = "GetIDChk";
            this.GetIDChk.Size = new System.Drawing.Size(64, 20);
            this.GetIDChk.TabIndex = 61;
            this.GetIDChk.Text = "Get ID";
            this.GetIDChk.UseVisualStyleBackColor = true;
            this.GetIDChk.CheckedChanged += new System.EventHandler(this.GetIDChk_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(768, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 16);
            this.label5.TabIndex = 63;
            this.label5.Text = "Rent Total Amount";
            // 
            // RentAmtTxt
            // 
            this.RentAmtTxt.Enabled = false;
            this.RentAmtTxt.Location = new System.Drawing.Point(912, 86);
            this.RentAmtTxt.Name = "RentAmtTxt";
            this.RentAmtTxt.Size = new System.Drawing.Size(164, 20);
            this.RentAmtTxt.TabIndex = 62;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(768, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 16);
            this.label7.TabIndex = 65;
            this.label7.Text = "Overall Quantity";
            // 
            // OverallQtyTxt
            // 
            this.OverallQtyTxt.Enabled = false;
            this.OverallQtyTxt.Location = new System.Drawing.Point(912, 49);
            this.OverallQtyTxt.Name = "OverallQtyTxt";
            this.OverallQtyTxt.Size = new System.Drawing.Size(164, 20);
            this.OverallQtyTxt.TabIndex = 64;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 180);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(159, 16);
            this.label8.TabIndex = 66;
            this.label8.Text = "RENTAL ITEM/S LIST";
            // 
            // label289
            // 
            this.label289.AutoSize = true;
            this.label289.BackColor = System.Drawing.SystemColors.Control;
            this.label289.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label289.ForeColor = System.Drawing.Color.DarkOrange;
            this.label289.Location = new System.Drawing.Point(739, 127);
            this.label289.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label289.Name = "label289";
            this.label289.Size = new System.Drawing.Size(18, 24);
            this.label289.TabIndex = 246;
            this.label289.Text = "*";
            // 
            // label126
            // 
            this.label126.AutoSize = true;
            this.label126.BackColor = System.Drawing.SystemColors.Control;
            this.label126.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label126.ForeColor = System.Drawing.Color.DarkOrange;
            this.label126.Location = new System.Drawing.Point(739, 90);
            this.label126.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label126.Name = "label126";
            this.label126.Size = new System.Drawing.Size(18, 24);
            this.label126.TabIndex = 245;
            this.label126.Text = "*";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.Control;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DarkOrange;
            this.label9.Location = new System.Drawing.Point(739, 49);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(18, 24);
            this.label9.TabIndex = 247;
            this.label9.Text = "*";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.Control;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.DarkOrange;
            this.label10.Location = new System.Drawing.Point(383, 125);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(18, 24);
            this.label10.TabIndex = 249;
            this.label10.Text = "*";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.Control;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.DarkOrange;
            this.label11.Location = new System.Drawing.Point(383, 88);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(18, 24);
            this.label11.TabIndex = 248;
            this.label11.Text = "*";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(416, 164);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(119, 16);
            this.label12.TabIndex = 251;
            this.label12.Text = "System Password:";
            // 
            // Syspasstxt
            // 
            this.Syspasstxt.Location = new System.Drawing.Point(560, 159);
            this.Syspasstxt.Name = "Syspasstxt";
            this.Syspasstxt.PasswordChar = '*';
            this.Syspasstxt.Size = new System.Drawing.Size(172, 20);
            this.Syspasstxt.TabIndex = 250;
            // 
            // frmDeliverRental
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1103, 592);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.Syspasstxt);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label289);
            this.Controls.Add(this.label126);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.OverallQtyTxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.RentAmtTxt);
            this.Controls.Add(this.GetIDChk);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.RentSecurityAmt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DeliveredByTxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.RecordedByTxt);
            this.Controls.Add(this.label141);
            this.Controls.Add(this.PickByTxt);
            this.Controls.Add(this.RentOKBtn);
            this.Controls.Add(this.DateReleased);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TimeReleased);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CustIDlbl);
            this.Controls.Add(this.label269);
            this.Controls.Add(this.COFNumLbl);
            this.Controls.Add(this.label264);
            this.Controls.Add(this.RentDataGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDeliverRental";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Deliver_Rental";
            this.Load += new System.EventHandler(this.frmDeliverRental_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RentDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CustIDlbl;
        private System.Windows.Forms.Label label269;
        private System.Windows.Forms.Label COFNumLbl;
        private System.Windows.Forms.Label label264;
        private System.Windows.Forms.DateTimePicker DateReleased;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker TimeReleased;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button RentOKBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox RecordedByTxt;
        private System.Windows.Forms.Label label141;
        private System.Windows.Forms.TextBox PickByTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox DeliveredByTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox RentSecurityAmt;
        private System.Windows.Forms.CheckBox GetIDChk;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox RentAmtTxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox OverallQtyTxt;
        private System.Windows.Forms.Label label8;
        protected System.Windows.Forms.DataGridView RentDataGrid;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label289;
        private System.Windows.Forms.Label label126;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox Syspasstxt;
    }
}