namespace QLBV
{
    partial class NC_DVHSBA
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
            this.dgDSHSBA_DV = new System.Windows.Forms.DataGridView();
            this.colMaHSBADV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaKTV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colKetQua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnTim = new System.Windows.Forms.Button();
            this.txtTimHSBA = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgDSHSBA_DV)).BeginInit();
            this.SuspendLayout();
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
            this.dgDSHSBA_DV.Location = new System.Drawing.Point(20, 134);
            this.dgDSHSBA_DV.Name = "dgDSHSBA_DV";
            this.dgDSHSBA_DV.RowHeadersWidth = 51;
            this.dgDSHSBA_DV.RowTemplate.Height = 24;
            this.dgDSHSBA_DV.Size = new System.Drawing.Size(1107, 329);
            this.dgDSHSBA_DV.TabIndex = 40;
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
            // btnTim
            // 
            this.btnTim.BackColor = System.Drawing.Color.LightGray;
            this.btnTim.Location = new System.Drawing.Point(1060, 81);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(75, 31);
            this.btnTim.TabIndex = 39;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = false;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // txtTimHSBA
            // 
            this.txtTimHSBA.Location = new System.Drawing.Point(843, 86);
            this.txtTimHSBA.Name = "txtTimHSBA";
            this.txtTimHSBA.Size = new System.Drawing.Size(213, 22);
            this.txtTimHSBA.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(760, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 37;
            this.label1.Text = "Tìm HSBA:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label18.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label18.Location = new System.Drawing.Point(373, 26);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(391, 35);
            this.label18.TabIndex = 36;
            this.label18.Text = "DỊCH VỤ HỒ SƠ BỆNH ÁN";
            // 
            // NC_DVHSBA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1147, 486);
            this.Controls.Add(this.dgDSHSBA_DV);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.txtTimHSBA);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label18);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "NC_DVHSBA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dịch vụ hồ sơ bệnh án";
            this.Load += new System.EventHandler(this.NC_DVHSBA_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgDSHSBA_DV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgDSHSBA_DV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaHSBADV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgay;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaKTV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKetQua;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.TextBox txtTimHSBA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label18;
    }
}