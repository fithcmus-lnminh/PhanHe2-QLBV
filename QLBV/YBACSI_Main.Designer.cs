namespace QLBV
{
    partial class YBACSI_Main
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
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.btnTTBN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDangXuat.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDangXuat.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDangXuat.Location = new System.Drawing.Point(552, 257);
            this.btnDangXuat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(122, 41);
            this.btnDangXuat.TabIndex = 36;
            this.btnDangXuat.Text = "Đăng xuất";
            this.btnDangXuat.UseVisualStyleBackColor = false;
            // 
            // btnTTBN
            // 
            this.btnTTBN.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnTTBN.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTTBN.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTTBN.Location = new System.Drawing.Point(225, 141);
            this.btnTTBN.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTTBN.Name = "btnTTBN";
            this.btnTTBN.Size = new System.Drawing.Size(265, 53);
            this.btnTTBN.TabIndex = 35;
            this.btnTTBN.Text = "Xem thông báo từ sở";
            this.btnTTBN.UseVisualStyleBackColor = false;
            this.btnTTBN.Click += new System.EventHandler(this.btnTTBN_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(153, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(421, 36);
            this.label1.TabIndex = 34;
            this.label1.Text = "THÔNG BÁO CỦA Y BÁC SĨ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // YBACSI_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 321);
            this.Controls.Add(this.btnDangXuat);
            this.Controls.Add(this.btnTTBN);
            this.Controls.Add(this.label1);
            this.Name = "YBACSI_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông báo Y Bác sĩ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDangXuat;
        private System.Windows.Forms.Button btnTTBN;
        private System.Windows.Forms.Label label1;
    }
}