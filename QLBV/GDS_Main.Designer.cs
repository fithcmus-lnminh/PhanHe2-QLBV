namespace QLBV
{
    partial class GDS_Main
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
            this.btnDVHSBA = new System.Windows.Forms.Button();
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDVHSBA
            // 
            this.btnDVHSBA.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnDVHSBA.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDVHSBA.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDVHSBA.Location = new System.Drawing.Point(202, 152);
            this.btnDVHSBA.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDVHSBA.Name = "btnDVHSBA";
            this.btnDVHSBA.Size = new System.Drawing.Size(265, 53);
            this.btnDVHSBA.TabIndex = 30;
            this.btnDVHSBA.Text = "Xem thông báo đã gửi";
            this.btnDVHSBA.UseVisualStyleBackColor = false;
            this.btnDVHSBA.Click += new System.EventHandler(this.btnDVHSBA_Click);
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDangXuat.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDangXuat.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDangXuat.Location = new System.Drawing.Point(504, 273);
            this.btnDangXuat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(122, 41);
            this.btnDangXuat.TabIndex = 29;
            this.btnDangXuat.Text = "Đăng xuất";
            this.btnDangXuat.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(173, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 36);
            this.label1.TabIndex = 27;
            this.label1.Text = "GIÁM ĐỐC SỞ Y TẾ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GDS_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 345);
            this.Controls.Add(this.btnDVHSBA);
            this.Controls.Add(this.btnDangXuat);
            this.Controls.Add(this.label1);
            this.Name = "GDS_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giám đốc sở";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnDVHSBA;
        private System.Windows.Forms.Button btnDangXuat;
        private System.Windows.Forms.Label label1;
    }
}