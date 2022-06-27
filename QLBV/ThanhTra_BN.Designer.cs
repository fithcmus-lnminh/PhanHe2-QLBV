namespace QLBV
{
    partial class ThanhTra_BN
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
            this.btnTimBN = new System.Windows.Forms.Button();
            this.tbxMaBN = new System.Windows.Forms.TextBox();
            this.dgvTTBN = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTTBN)).BeginInit();
            this.SuspendLayout();
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label18.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label18.Location = new System.Drawing.Point(295, 42);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(444, 43);
            this.label18.TabIndex = 30;
            this.label18.Text = "THÔNG TIN BỆNH NHÂN";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(613, 123);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 34;
            this.label1.Text = "Tìm mã BN:";
            // 
            // btnTimBN
            // 
            this.btnTimBN.Location = new System.Drawing.Point(871, 115);
            this.btnTimBN.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTimBN.Name = "btnTimBN";
            this.btnTimBN.Size = new System.Drawing.Size(112, 35);
            this.btnTimBN.TabIndex = 33;
            this.btnTimBN.Text = "Tìm";
            this.btnTimBN.UseVisualStyleBackColor = true;
            this.btnTimBN.Click += new System.EventHandler(this.btnTimBN_Click);
            // 
            // tbxMaBN
            // 
            this.tbxMaBN.Location = new System.Drawing.Point(711, 120);
            this.tbxMaBN.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbxMaBN.Name = "tbxMaBN";
            this.tbxMaBN.Size = new System.Drawing.Size(148, 26);
            this.tbxMaBN.TabIndex = 32;
            // 
            // dgvTTBN
            // 
            this.dgvTTBN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTTBN.Location = new System.Drawing.Point(68, 160);
            this.dgvTTBN.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvTTBN.Name = "dgvTTBN";
            this.dgvTTBN.RowHeadersWidth = 51;
            this.dgvTTBN.Size = new System.Drawing.Size(915, 389);
            this.dgvTTBN.TabIndex = 31;
            // 
            // ThanhTra_BN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 589);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTimBN);
            this.Controls.Add(this.tbxMaBN);
            this.Controls.Add(this.dgvTTBN);
            this.Controls.Add(this.label18);
            this.Name = "ThanhTra_BN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin bệnh nhân";
            this.Load += new System.EventHandler(this.ThanhTra_BN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTTBN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTimBN;
        private System.Windows.Forms.TextBox tbxMaBN;
        private System.Windows.Forms.DataGridView dgvTTBN;
    }
}