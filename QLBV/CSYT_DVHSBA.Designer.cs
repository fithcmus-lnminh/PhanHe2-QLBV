namespace QLBV
{
    partial class CSYT_DVHSBA
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
            this.btnTim = new System.Windows.Forms.Button();
            this.txtTimHSBA = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.dgDSHSBA_DV = new System.Windows.Forms.DataGridView();
            this.colMaHSBADV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaKTV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colKetQua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtpNgay = new System.Windows.Forms.DateTimePicker();
            this.txtKetQua = new System.Windows.Forms.TextBox();
            this.txtMaKTV = new System.Windows.Forms.TextBox();
            this.txtMaDV = new System.Windows.Forms.TextBox();
            this.txtMaHSBADV = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnXoa = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgDSHSBA_DV)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTim
            // 
            this.btnTim.BackColor = System.Drawing.Color.LightGray;
            this.btnTim.Location = new System.Drawing.Point(1184, 27);
            this.btnTim.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(84, 39);
            this.btnTim.TabIndex = 34;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = false;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // txtTimHSBA
            // 
            this.txtTimHSBA.Location = new System.Drawing.Point(939, 33);
            this.txtTimHSBA.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTimHSBA.Name = "txtTimHSBA";
            this.txtTimHSBA.Size = new System.Drawing.Size(239, 26);
            this.txtTimHSBA.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(846, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 32;
            this.label1.Text = "Tìm HSBA:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label18.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label18.Location = new System.Drawing.Point(232, 23);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(418, 43);
            this.label18.TabIndex = 31;
            this.label18.Text = "DỊCH VỤ TRONG HSBA";
            // 
            // dgDSHSBA_DV
            // 
            this.dgDSHSBA_DV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgDSHSBA_DV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDSHSBA_DV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaHSBADV,
            this.colMaDV,
            this.colNgay,
            this.colMaKTV,
            this.colKetQua});
            this.dgDSHSBA_DV.Location = new System.Drawing.Point(26, 92);
            this.dgDSHSBA_DV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgDSHSBA_DV.Name = "dgDSHSBA_DV";
            this.dgDSHSBA_DV.RowHeadersWidth = 51;
            this.dgDSHSBA_DV.RowTemplate.Height = 24;
            this.dgDSHSBA_DV.Size = new System.Drawing.Size(1245, 345);
            this.dgDSHSBA_DV.TabIndex = 35;
            // 
            // colMaHSBADV
            // 
            this.colMaHSBADV.DataPropertyName = "MAHSBA";
            this.colMaHSBADV.HeaderText = "Mã HSBA";
            this.colMaHSBADV.MinimumWidth = 6;
            this.colMaHSBADV.Name = "colMaHSBADV";
            // 
            // colMaDV
            // 
            this.colMaDV.DataPropertyName = "MADV";
            this.colMaDV.HeaderText = "Mã DV";
            this.colMaDV.MinimumWidth = 6;
            this.colMaDV.Name = "colMaDV";
            // 
            // colNgay
            // 
            this.colNgay.DataPropertyName = "NGAY";
            this.colNgay.HeaderText = "Ngày";
            this.colNgay.MinimumWidth = 6;
            this.colNgay.Name = "colNgay";
            // 
            // colMaKTV
            // 
            this.colMaKTV.DataPropertyName = "MAKTV";
            this.colMaKTV.HeaderText = "Mã KTV";
            this.colMaKTV.MinimumWidth = 6;
            this.colMaKTV.Name = "colMaKTV";
            // 
            // colKetQua
            // 
            this.colKetQua.DataPropertyName = "KETQUA";
            this.colKetQua.HeaderText = "Kết quả";
            this.colKetQua.MinimumWidth = 6;
            this.colKetQua.Name = "colKetQua";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dtpNgay);
            this.panel1.Controls.Add(this.txtKetQua);
            this.panel1.Controls.Add(this.txtMaKTV);
            this.panel1.Controls.Add(this.txtMaDV);
            this.panel1.Controls.Add(this.txtMaHSBADV);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(23, 474);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1245, 216);
            this.panel1.TabIndex = 36;
            // 
            // dtpNgay
            // 
            this.dtpNgay.Location = new System.Drawing.Point(135, 96);
            this.dtpNgay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpNgay.Name = "dtpNgay";
            this.dtpNgay.Size = new System.Drawing.Size(419, 26);
            this.dtpNgay.TabIndex = 18;
            // 
            // txtKetQua
            // 
            this.txtKetQua.Location = new System.Drawing.Point(754, 96);
            this.txtKetQua.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtKetQua.Name = "txtKetQua";
            this.txtKetQua.Size = new System.Drawing.Size(439, 26);
            this.txtKetQua.TabIndex = 17;
            // 
            // txtMaKTV
            // 
            this.txtMaKTV.Location = new System.Drawing.Point(915, 35);
            this.txtMaKTV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaKTV.Name = "txtMaKTV";
            this.txtMaKTV.Size = new System.Drawing.Size(278, 26);
            this.txtMaKTV.TabIndex = 14;
            // 
            // txtMaDV
            // 
            this.txtMaDV.Location = new System.Drawing.Point(530, 38);
            this.txtMaDV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaDV.Name = "txtMaDV";
            this.txtMaDV.Size = new System.Drawing.Size(240, 26);
            this.txtMaDV.TabIndex = 11;
            // 
            // txtMaHSBADV
            // 
            this.txtMaHSBADV.Location = new System.Drawing.Point(135, 34);
            this.txtMaHSBADV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaHSBADV.Name = "txtMaHSBADV";
            this.txtMaHSBADV.Size = new System.Drawing.Size(228, 26);
            this.txtMaHSBADV.TabIndex = 10;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.LimeGreen;
            this.btnThem.Location = new System.Drawing.Point(530, 152);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(154, 41);
            this.btnThem.TabIndex = 8;
            this.btnThem.Text = "Thêm dịch vụ";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(668, 99);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 20);
            this.label9.TabIndex = 7;
            this.label9.Text = "Kết quả:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(840, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Mã KTV:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Ngày:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(447, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mã DV:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã HSBA:";
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.OrangeRed;
            this.btnXoa.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnXoa.Location = new System.Drawing.Point(1070, 14);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(148, 41);
            this.btnXoa.TabIndex = 9;
            this.btnXoa.Text = "Xóa dịch vụ";
            this.btnXoa.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(69, 459);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 24);
            this.label5.TabIndex = 35;
            this.label5.Text = "THÊM DỊCH VỤ";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.dateTimePicker1);
            this.panel2.Controls.Add(this.btnXoa);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(26, 724);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1242, 72);
            this.panel2.TabIndex = 37;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(777, 21);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(266, 26);
            this.dateTimePicker1.TabIndex = 24;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(448, 21);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(184, 26);
            this.textBox1.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(24, 24);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 20);
            this.label10.TabIndex = 19;
            this.label10.Text = "Mã HSBA:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(118, 21);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(179, 26);
            this.textBox2.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(372, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 20);
            this.label8.TabIndex = 20;
            this.label8.Text = "Mã DV:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(706, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 20);
            this.label7.TabIndex = 21;
            this.label7.Text = "Ngày:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label11.Location = new System.Drawing.Point(69, 707);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(137, 24);
            this.label11.TabIndex = 38;
            this.label11.Text = "XÓA DỊCH VỤ";
            // 
            // CSYT_DVHSBA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1300, 808);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgDSHSBA_DV);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.txtTimHSBA);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label18);
            this.Name = "CSYT_DVHSBA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dịch vụ hồ sơ bệnh án";
            this.Load += new System.EventHandler(this.CSYT_DVHSBA_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgDSHSBA_DV)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.TextBox txtTimHSBA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.DataGridView dgDSHSBA_DV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaHSBADV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgay;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaKTV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKetQua;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dtpNgay;
        private System.Windows.Forms.TextBox txtKetQua;
        private System.Windows.Forms.TextBox txtMaKTV;
        private System.Windows.Forms.TextBox txtMaDV;
        private System.Windows.Forms.TextBox txtMaHSBADV;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
    }
}