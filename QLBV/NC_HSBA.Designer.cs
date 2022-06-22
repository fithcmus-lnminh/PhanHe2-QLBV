namespace QLBV
{
    partial class NC_HSBA
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnTim = new System.Windows.Forms.Button();
            this.txtTimHSBA = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgDSHSBA = new System.Windows.Forms.DataGridView();
            this.colMaHSBA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgayHSBA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colChanDoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaBS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaKhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaCSYT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colKetLuan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label18 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgDSHSBA)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTim
            // 
            this.btnTim.BackColor = System.Drawing.Color.LightGray;
            this.btnTim.Location = new System.Drawing.Point(1044, 82);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(75, 31);
            this.btnTim.TabIndex = 35;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = false;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // txtTimHSBA
            // 
            this.txtTimHSBA.Location = new System.Drawing.Point(826, 86);
            this.txtTimHSBA.Name = "txtTimHSBA";
            this.txtTimHSBA.Size = new System.Drawing.Size(213, 22);
            this.txtTimHSBA.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(743, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 33;
            this.label1.Text = "Tìm HSBA:";
            // 
            // dgDSHSBA
            // 
            this.dgDSHSBA.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgDSHSBA.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
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
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgDSHSBA.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgDSHSBA.Location = new System.Drawing.Point(23, 128);
            this.dgDSHSBA.Name = "dgDSHSBA";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgDSHSBA.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgDSHSBA.RowHeadersWidth = 51;
            this.dgDSHSBA.RowTemplate.Height = 24;
            this.dgDSHSBA.Size = new System.Drawing.Size(1095, 327);
            this.dgDSHSBA.TabIndex = 32;
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
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label18.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label18.Location = new System.Drawing.Point(464, 28);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(259, 35);
            this.label18.TabIndex = 31;
            this.label18.Text = "HỒ SƠ BỆNH ÁN";
            // 
            // NC_HSBA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1159, 482);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.txtTimHSBA);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgDSHSBA);
            this.Controls.Add(this.label18);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "NC_HSBA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hồ sơ bệnh án";
            this.Load += new System.EventHandler(this.NC_HSBA_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgDSHSBA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.TextBox txtTimHSBA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgDSHSBA;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaHSBA;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayHSBA;
        private System.Windows.Forms.DataGridViewTextBoxColumn colChanDoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaBS;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaKhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaCSYT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKetLuan;
        private System.Windows.Forms.Label label18;
    }
}