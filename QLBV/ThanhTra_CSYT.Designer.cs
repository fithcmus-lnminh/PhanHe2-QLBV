namespace QLBV
{
    partial class ThanhTra_CSYT
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
            this.btnTimCSYT = new System.Windows.Forms.Button();
            this.txbMaCSYT = new System.Windows.Forms.TextBox();
            this.dgvCSYT = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCSYT)).BeginInit();
            this.SuspendLayout();
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label18.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label18.Location = new System.Drawing.Point(258, 43);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(438, 43);
            this.label18.TabIndex = 30;
            this.label18.Text = "THÔNG TIN CƠ SỞ Y TẾ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(584, 107);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 34;
            this.label1.Text = "Tìm CSYT:";
            // 
            // btnTimCSYT
            // 
            this.btnTimCSYT.Location = new System.Drawing.Point(836, 99);
            this.btnTimCSYT.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTimCSYT.Name = "btnTimCSYT";
            this.btnTimCSYT.Size = new System.Drawing.Size(112, 35);
            this.btnTimCSYT.TabIndex = 33;
            this.btnTimCSYT.Text = "Tìm";
            this.btnTimCSYT.UseVisualStyleBackColor = true;
            this.btnTimCSYT.Click += new System.EventHandler(this.btnTimCSYT_Click);
            // 
            // txbMaCSYT
            // 
            this.txbMaCSYT.Location = new System.Drawing.Point(676, 104);
            this.txbMaCSYT.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txbMaCSYT.Name = "txbMaCSYT";
            this.txbMaCSYT.Size = new System.Drawing.Size(148, 26);
            this.txbMaCSYT.TabIndex = 32;
            // 
            // dgvCSYT
            // 
            this.dgvCSYT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCSYT.Location = new System.Drawing.Point(33, 144);
            this.dgvCSYT.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvCSYT.Name = "dgvCSYT";
            this.dgvCSYT.RowHeadersWidth = 62;
            this.dgvCSYT.Size = new System.Drawing.Size(915, 389);
            this.dgvCSYT.TabIndex = 31;
            // 
            // ThanhTra_CSYT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 572);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTimCSYT);
            this.Controls.Add(this.txbMaCSYT);
            this.Controls.Add(this.dgvCSYT);
            this.Controls.Add(this.label18);
            this.Name = "ThanhTra_CSYT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cơ sở y tế";
            this.Load += new System.EventHandler(this.ThanhTra_CSYT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCSYT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTimCSYT;
        private System.Windows.Forms.TextBox txbMaCSYT;
        private System.Windows.Forms.DataGridView dgvCSYT;
    }
}