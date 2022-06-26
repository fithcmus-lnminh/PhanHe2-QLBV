namespace QLBV
{
    partial class GDS_GDCSYT_YBS_XemTB
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
            this.dgTB = new System.Windows.Forms.DataGridView();
            this.label18 = new System.Windows.Forms.Label();
            this.colMaHSBADV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaKTV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgTB)).BeginInit();
            this.SuspendLayout();
            // 
            // dgTB
            // 
            this.dgTB.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgTB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTB.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaHSBADV,
            this.colMaDV,
            this.colNgay,
            this.colMaKTV});
            this.dgTB.Location = new System.Drawing.Point(22, 126);
            this.dgTB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgTB.Name = "dgTB";
            this.dgTB.RowHeadersWidth = 51;
            this.dgTB.RowTemplate.Height = 24;
            this.dgTB.Size = new System.Drawing.Size(1245, 446);
            this.dgTB.TabIndex = 36;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label18.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label18.Location = new System.Drawing.Point(441, 48);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(466, 43);
            this.label18.TabIndex = 37;
            this.label18.Text = "XEM THÔNG BÁO ĐÃ GỬI";
            // 
            // colMaHSBADV
            // 
            this.colMaHSBADV.DataPropertyName = "NGAYGIO";
            this.colMaHSBADV.FillWeight = 66.66666F;
            this.colMaHSBADV.HeaderText = "Ngày giờ";
            this.colMaHSBADV.MinimumWidth = 6;
            this.colMaHSBADV.Name = "colMaHSBADV";
            // 
            // colMaDV
            // 
            this.colMaDV.DataPropertyName = "DIADIEM";
            this.colMaDV.FillWeight = 66.66666F;
            this.colMaDV.HeaderText = "Địa điểm";
            this.colMaDV.MinimumWidth = 6;
            this.colMaDV.Name = "colMaDV";
            // 
            // colNgay
            // 
            this.colNgay.DataPropertyName = "GUIDEN";
            this.colNgay.FillWeight = 66.66666F;
            this.colNgay.HeaderText = "Gửi đến";
            this.colNgay.MinimumWidth = 6;
            this.colNgay.Name = "colNgay";
            // 
            // colMaKTV
            // 
            this.colMaKTV.DataPropertyName = "NOIDUNG";
            this.colMaKTV.FillWeight = 200F;
            this.colMaKTV.HeaderText = "Nội dung";
            this.colMaKTV.MinimumWidth = 6;
            this.colMaKTV.Name = "colMaKTV";
            // 
            // GDS_XemTB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1288, 621);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.dgTB);
            this.Name = "GDS_XemTB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xem thông báo đã gửi ";
            ((System.ComponentModel.ISupportInitialize)(this.dgTB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgTB;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaHSBADV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgay;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaKTV;
    }
}