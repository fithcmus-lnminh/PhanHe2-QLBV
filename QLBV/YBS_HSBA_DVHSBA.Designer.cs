namespace QLBV
{
    partial class YBS_HSBA_DVHSBA
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label18 = new System.Windows.Forms.Label();
            this.btnTimHSBA = new System.Windows.Forms.Button();
            this.txtTimMaHSBA = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvDSKQDVHSBA = new System.Windows.Forms.DataGridView();
            this.colMaHSBA_DV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colKetQua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgDSHSBA = new System.Windows.Forms.DataGridView();
            this.colMaHSBA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgayHSBA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colChanDoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaBS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaKhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaCSYT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colKetLuan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSKQDVHSBA)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDSHSBA)).BeginInit();
            this.SuspendLayout();
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label18.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label18.Location = new System.Drawing.Point(300, 37);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(583, 35);
            this.label18.TabIndex = 30;
            this.label18.Text = "HỒ SƠ BỆNH ÁN VÀ KẾT QUẢ DỊCH VỤ";
            // 
            // btnTimHSBA
            // 
            this.btnTimHSBA.BackColor = System.Drawing.Color.LightGray;
            this.btnTimHSBA.Location = new System.Drawing.Point(1057, 101);
            this.btnTimHSBA.Name = "btnTimHSBA";
            this.btnTimHSBA.Size = new System.Drawing.Size(75, 31);
            this.btnTimHSBA.TabIndex = 35;
            this.btnTimHSBA.Text = "Tìm";
            this.btnTimHSBA.UseVisualStyleBackColor = false;
            this.btnTimHSBA.Click += new System.EventHandler(this.btnTimHSBA_Click);
            // 
            // txtTimMaHSBA
            // 
            this.txtTimMaHSBA.Location = new System.Drawing.Point(838, 106);
            this.txtTimMaHSBA.Name = "txtTimMaHSBA";
            this.txtTimMaHSBA.Size = new System.Drawing.Size(213, 22);
            this.txtTimMaHSBA.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(758, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 33;
            this.label1.Text = "Tìm HSBA:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvDSKQDVHSBA);
            this.panel2.Location = new System.Drawing.Point(764, 148);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(396, 493);
            this.panel2.TabIndex = 32;
            // 
            // dgvDSKQDVHSBA
            // 
            this.dgvDSKQDVHSBA.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSKQDVHSBA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSKQDVHSBA.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaHSBA_DV,
            this.colKetQua});
            this.dgvDSKQDVHSBA.Location = new System.Drawing.Point(11, 12);
            this.dgvDSKQDVHSBA.Name = "dgvDSKQDVHSBA";
            this.dgvDSKQDVHSBA.RowHeadersWidth = 51;
            this.dgvDSKQDVHSBA.RowTemplate.Height = 24;
            this.dgvDSKQDVHSBA.Size = new System.Drawing.Size(357, 460);
            this.dgvDSKQDVHSBA.TabIndex = 5;
            // 
            // colMaHSBA_DV
            // 
            this.colMaHSBA_DV.DataPropertyName = "MAHSBA";
            this.colMaHSBA_DV.HeaderText = "Mã HSBA";
            this.colMaHSBA_DV.MinimumWidth = 6;
            this.colMaHSBA_DV.Name = "colMaHSBA_DV";
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
            this.panel1.Controls.Add(this.dgDSHSBA);
            this.panel1.Location = new System.Drawing.Point(30, 148);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(727, 493);
            this.panel1.TabIndex = 31;
            // 
            // dgDSHSBA
            // 
            this.dgDSHSBA.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgDSHSBA.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgDSHSBA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDSHSBA.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaHSBA,
            this.colMaBN,
            this.colNgayHSBA,
            this.colChanDoan,
            this.colMaBS,
            this.colMaKhoa,
            this.colMaCSYT,
            this.colKetLuan});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgDSHSBA.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgDSHSBA.Location = new System.Drawing.Point(8, 12);
            this.dgDSHSBA.Name = "dgDSHSBA";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgDSHSBA.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgDSHSBA.RowHeadersWidth = 51;
            this.dgDSHSBA.RowTemplate.Height = 24;
            this.dgDSHSBA.Size = new System.Drawing.Size(710, 460);
            this.dgDSHSBA.TabIndex = 4;
            // 
            // colMaHSBA
            // 
            this.colMaHSBA.DataPropertyName = "MAHSBA";
            this.colMaHSBA.HeaderText = "Mã HSBA";
            this.colMaHSBA.MinimumWidth = 6;
            this.colMaHSBA.Name = "colMaHSBA";
            // 
            // colMaBN
            // 
            this.colMaBN.DataPropertyName = "MABN";
            this.colMaBN.HeaderText = "Mã BN";
            this.colMaBN.MinimumWidth = 6;
            this.colMaBN.Name = "colMaBN";
            // 
            // colNgayHSBA
            // 
            this.colNgayHSBA.DataPropertyName = "NGAY";
            this.colNgayHSBA.HeaderText = "Ngày";
            this.colNgayHSBA.MinimumWidth = 6;
            this.colNgayHSBA.Name = "colNgayHSBA";
            // 
            // colChanDoan
            // 
            this.colChanDoan.DataPropertyName = "CHUANDOAN";
            this.colChanDoan.HeaderText = "Chẩn đoán";
            this.colChanDoan.MinimumWidth = 6;
            this.colChanDoan.Name = "colChanDoan";
            // 
            // colMaBS
            // 
            this.colMaBS.DataPropertyName = "MABS";
            this.colMaBS.HeaderText = "Mã BS";
            this.colMaBS.MinimumWidth = 6;
            this.colMaBS.Name = "colMaBS";
            // 
            // colMaKhoa
            // 
            this.colMaKhoa.DataPropertyName = "MAKHOA";
            this.colMaKhoa.HeaderText = "Mã khoa";
            this.colMaKhoa.MinimumWidth = 6;
            this.colMaKhoa.Name = "colMaKhoa";
            // 
            // colMaCSYT
            // 
            this.colMaCSYT.DataPropertyName = "MACSYT";
            this.colMaCSYT.HeaderText = "Mã CSYT";
            this.colMaCSYT.MinimumWidth = 6;
            this.colMaCSYT.Name = "colMaCSYT";
            // 
            // colKetLuan
            // 
            this.colKetLuan.DataPropertyName = "KETLUAN";
            this.colKetLuan.HeaderText = "Kết luận";
            this.colKetLuan.MinimumWidth = 6;
            this.colKetLuan.Name = "colKetLuan";
            // 
            // YBS_HSBA_DVHSBA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1170, 662);
            this.Controls.Add(this.btnTimHSBA);
            this.Controls.Add(this.txtTimMaHSBA);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label18);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "YBS_HSBA_DVHSBA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "YBS_HSBA_DVHSBA";
            this.Load += new System.EventHandler(this.YBS_HSBA_DVHSBA_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSKQDVHSBA)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgDSHSBA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button btnTimHSBA;
        private System.Windows.Forms.TextBox txtTimMaHSBA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvDSKQDVHSBA;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaHSBA_DV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKetQua;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgDSHSBA;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaHSBA;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayHSBA;
        private System.Windows.Forms.DataGridViewTextBoxColumn colChanDoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaBS;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaKhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaCSYT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKetLuan;
    }
}