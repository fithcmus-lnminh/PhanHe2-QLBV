namespace QLBV
{
    partial class ThanhTra_HSBA
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
            this.label1 = new System.Windows.Forms.Label();
            this.buttonTim = new System.Windows.Forms.Button();
            this.txtMaHSBA = new System.Windows.Forms.TextBox();
            this.dgvHSBA = new System.Windows.Forms.DataGridView();
            this.label18 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHSBA)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(591, 92);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 27;
            this.label1.Text = "Tìm HSBA:";
            // 
            // buttonTim
            // 
            this.buttonTim.Location = new System.Drawing.Point(871, 85);
            this.buttonTim.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonTim.Name = "buttonTim";
            this.buttonTim.Size = new System.Drawing.Size(112, 35);
            this.buttonTim.TabIndex = 26;
            this.buttonTim.Text = "Tìm";
            this.buttonTim.UseVisualStyleBackColor = true;
            // 
            // txtMaHSBA
            // 
            this.txtMaHSBA.Location = new System.Drawing.Point(689, 89);
            this.txtMaHSBA.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMaHSBA.Name = "txtMaHSBA";
            this.txtMaHSBA.Size = new System.Drawing.Size(174, 26);
            this.txtMaHSBA.TabIndex = 25;
            // 
            // dgvHSBA
            // 
            this.dgvHSBA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHSBA.Location = new System.Drawing.Point(68, 132);
            this.dgvHSBA.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvHSBA.Name = "dgvHSBA";
            this.dgvHSBA.RowHeadersWidth = 51;
            this.dgvHSBA.Size = new System.Drawing.Size(915, 389);
            this.dgvHSBA.TabIndex = 24;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label18.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label18.Location = new System.Drawing.Point(273, 28);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(521, 43);
            this.label18.TabIndex = 28;
            this.label18.Text = "THÔNG TIN HỒ SƠ BỆNH ÁN";
            // 
            // ThanhTra_HSBA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 566);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonTim);
            this.Controls.Add(this.txtMaHSBA);
            this.Controls.Add(this.dgvHSBA);
            this.Name = "ThanhTra_HSBA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hồ sơ bệnh án";
            ((System.ComponentModel.ISupportInitialize)(this.dgvHSBA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonTim;
        private System.Windows.Forms.TextBox txtMaHSBA;
        private System.Windows.Forms.DataGridView dgvHSBA;
        private System.Windows.Forms.Label label18;
    }
}