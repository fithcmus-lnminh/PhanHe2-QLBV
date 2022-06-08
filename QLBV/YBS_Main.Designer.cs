namespace QLBV
{
    partial class YBS_Main
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
            this.btnTTCN = new System.Windows.Forms.Button();
            this.btnTTBN = new System.Windows.Forms.Button();
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.btnHSBA = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(76, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(643, 36);
            this.label1.TabIndex = 3;
            this.label1.Text = "QUẢN LÝ HSBA, DVHSBA VÀ BỆNH NHÂN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnTTCN
            // 
            this.btnTTCN.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnTTCN.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTTCN.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTTCN.Location = new System.Drawing.Point(268, 298);
            this.btnTTCN.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTTCN.Name = "btnTTCN";
            this.btnTTCN.Size = new System.Drawing.Size(265, 53);
            this.btnTTCN.TabIndex = 30;
            this.btnTTCN.Text = "Xem thông tin cá nhân";
            this.btnTTCN.UseVisualStyleBackColor = false;
            this.btnTTCN.Click += new System.EventHandler(this.btnTTCN_Click);
            // 
            // btnTTBN
            // 
            this.btnTTBN.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnTTBN.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTTBN.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTTBN.Location = new System.Drawing.Point(268, 218);
            this.btnTTBN.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTTBN.Name = "btnTTBN";
            this.btnTTBN.Size = new System.Drawing.Size(265, 53);
            this.btnTTBN.TabIndex = 29;
            this.btnTTBN.Text = "Thông tin bệnh nhân";
            this.btnTTBN.UseVisualStyleBackColor = false;
            this.btnTTBN.Click += new System.EventHandler(this.btnTTBN_Click);
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDangXuat.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDangXuat.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDangXuat.Location = new System.Drawing.Point(633, 418);
            this.btnDangXuat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(122, 41);
            this.btnDangXuat.TabIndex = 28;
            this.btnDangXuat.Text = "Đăng xuất";
            this.btnDangXuat.UseVisualStyleBackColor = false;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // btnHSBA
            // 
            this.btnHSBA.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnHSBA.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnHSBA.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnHSBA.Location = new System.Drawing.Point(268, 141);
            this.btnHSBA.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnHSBA.Name = "btnHSBA";
            this.btnHSBA.Size = new System.Drawing.Size(265, 53);
            this.btnHSBA.TabIndex = 27;
            this.btnHSBA.Text = "HSBA và KQDVHSBA";
            this.btnHSBA.UseVisualStyleBackColor = false;
            this.btnHSBA.Click += new System.EventHandler(this.btnHSBA_Click);
            // 
            // YBS_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(791, 489);
            this.Controls.Add(this.btnTTCN);
            this.Controls.Add(this.btnTTBN);
            this.Controls.Add(this.btnDangXuat);
            this.Controls.Add(this.btnHSBA);
            this.Controls.Add(this.label1);
            this.Name = "YBS_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Y sĩ / Bác sĩ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTTCN;
        private System.Windows.Forms.Button btnTTBN;
        private System.Windows.Forms.Button btnDangXuat;
        private System.Windows.Forms.Button btnHSBA;
    }
}