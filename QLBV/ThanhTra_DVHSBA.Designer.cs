namespace QLBV
{
    partial class ThanhTra_DVHSBA
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
            this.buttonTim = new System.Windows.Forms.Button();
            this.txbMaHSBA = new System.Windows.Forms.TextBox();
            this.dgvDVHSBA = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDVHSBA)).BeginInit();
            this.SuspendLayout();
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label18.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label18.Location = new System.Drawing.Point(175, 33);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(678, 43);
            this.label18.TabIndex = 29;
            this.label18.Text = "THÔNG TIN DỊCH VỤ HỒ SƠ BỆNH ÁN";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(595, 113);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 33;
            this.label1.Text = "Tìm HSBA:";
            // 
            // buttonTim
            // 
            this.buttonTim.Location = new System.Drawing.Point(864, 102);
            this.buttonTim.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonTim.Name = "buttonTim";
            this.buttonTim.Size = new System.Drawing.Size(112, 35);
            this.buttonTim.TabIndex = 32;
            this.buttonTim.Text = "Tìm";
            this.buttonTim.UseVisualStyleBackColor = true;
            this.buttonTim.Click += new System.EventHandler(this.buttonTim_Click);
            // 
            // txbMaHSBA
            // 
            this.txbMaHSBA.Location = new System.Drawing.Point(690, 107);
            this.txbMaHSBA.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txbMaHSBA.Name = "txbMaHSBA";
            this.txbMaHSBA.Size = new System.Drawing.Size(163, 26);
            this.txbMaHSBA.TabIndex = 31;
            // 
            // dgvDVHSBA
            // 
            this.dgvDVHSBA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDVHSBA.Location = new System.Drawing.Point(39, 147);
            this.dgvDVHSBA.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvDVHSBA.Name = "dgvDVHSBA";
            this.dgvDVHSBA.RowHeadersWidth = 51;
            this.dgvDVHSBA.Size = new System.Drawing.Size(966, 389);
            this.dgvDVHSBA.TabIndex = 30;
            // 
            // ThanhTra_DVHSBA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 579);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonTim);
            this.Controls.Add(this.txbMaHSBA);
            this.Controls.Add(this.dgvDVHSBA);
            this.Controls.Add(this.label18);
            this.Name = "ThanhTra_DVHSBA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dịch vụ hồ sơ bệnh án";
            this.Load += new System.EventHandler(this.ThanhTra_DVHSBA_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDVHSBA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonTim;
        private System.Windows.Forms.TextBox txbMaHSBA;
        private System.Windows.Forms.DataGridView dgvDVHSBA;
    }
}