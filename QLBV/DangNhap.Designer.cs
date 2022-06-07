namespace QLBV
{
    partial class DangNhap
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
            this.Textbox_Pw = new System.Windows.Forms.TextBox();
            this.Button_Login = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TextBox_Usrname = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(55, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(693, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "HỆ THỐNG QUẢN LÝ THÔNG TIN BỆNH VIỆN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Textbox_Pw
            // 
            this.Textbox_Pw.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Textbox_Pw.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Textbox_Pw.Location = new System.Drawing.Point(371, 193);
            this.Textbox_Pw.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Textbox_Pw.Name = "Textbox_Pw";
            this.Textbox_Pw.Size = new System.Drawing.Size(232, 26);
            this.Textbox_Pw.TabIndex = 14;
            this.Textbox_Pw.UseSystemPasswordChar = true;
            // 
            // Button_Login
            // 
            this.Button_Login.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Button_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Button_Login.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Button_Login.Location = new System.Drawing.Point(324, 258);
            this.Button_Login.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Button_Login.Name = "Button_Login";
            this.Button_Login.Size = new System.Drawing.Size(167, 49);
            this.Button_Login.TabIndex = 13;
            this.Button_Login.Text = "Đăng nhập";
            this.Button_Login.UseVisualStyleBackColor = false;
            this.Button_Login.Click += new System.EventHandler(this.Button_Login_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(252, 193);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 23);
            this.label2.TabIndex = 12;
            this.label2.Text = "Mật khẩu:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(203, 130);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 23);
            this.label3.TabIndex = 11;
            this.label3.Text = "Tên đăng nhập:";
            // 
            // TextBox_Usrname
            // 
            this.TextBox_Usrname.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.TextBox_Usrname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBox_Usrname.Location = new System.Drawing.Point(371, 130);
            this.TextBox_Usrname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TextBox_Usrname.Name = "TextBox_Usrname";
            this.TextBox_Usrname.Size = new System.Drawing.Size(232, 26);
            this.TextBox_Usrname.TabIndex = 15;
            // 
            // DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(824, 350);
            this.Controls.Add(this.TextBox_Usrname);
            this.Controls.Add(this.Textbox_Pw);
            this.Controls.Add(this.Button_Login);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "DangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Textbox_Pw;
        private System.Windows.Forms.Button Button_Login;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TextBox_Usrname;
    }
}

