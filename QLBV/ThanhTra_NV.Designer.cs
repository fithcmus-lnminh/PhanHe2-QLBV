namespace QLBV
{
    partial class ThanhTra_NV
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
            this.label18 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTimNV = new System.Windows.Forms.Button();
            this.txbMaNV = new System.Windows.Forms.TextBox();
            this.dgvHSNV = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHSNV)).BeginInit();
            this.SuspendLayout();
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label18.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label18.Location = new System.Drawing.Point(322, 44);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(425, 43);
            this.label18.TabIndex = 31;
            this.label18.Text = "THÔNG TIN NHÂN VIÊN";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(636, 136);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 35;
            this.label1.Text = "Tìm NV:";
            // 
            // btnTimNV
            // 
            this.btnTimNV.Location = new System.Drawing.Point(868, 128);
            this.btnTimNV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTimNV.Name = "btnTimNV";
            this.btnTimNV.Size = new System.Drawing.Size(112, 35);
            this.btnTimNV.TabIndex = 34;
            this.btnTimNV.Text = "Tìm";
            this.btnTimNV.UseVisualStyleBackColor = true;
            this.btnTimNV.Click += new System.EventHandler(this.btnTimNV_Click);
            // 
            // txbMaNV
            // 
            this.txbMaNV.Location = new System.Drawing.Point(708, 133);
            this.txbMaNV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txbMaNV.Name = "txbMaNV";
            this.txbMaNV.Size = new System.Drawing.Size(148, 26);
            this.txbMaNV.TabIndex = 33;
            // 
            // dgvHSNV
            // 
            this.dgvHSNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHSNV.Location = new System.Drawing.Point(65, 173);
            this.dgvHSNV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvHSNV.Name = "dgvHSNV";
            this.dgvHSNV.RowHeadersWidth = 51;
            this.dgvHSNV.Size = new System.Drawing.Size(915, 389);
            this.dgvHSNV.TabIndex = 32;
            // 
            // ThanhTra_NV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 602);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTimNV);
            this.Controls.Add(this.txbMaNV);
            this.Controls.Add(this.dgvHSNV);
            this.Controls.Add(this.label18);
            this.Name = "ThanhTra_NV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin Nhân viên";
            this.Load += new System.EventHandler(this.ThanhTra_NV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHSNV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTimNV;
        private System.Windows.Forms.TextBox txbMaNV;
        private System.Windows.Forms.DataGridView dgvHSNV;
    }
}