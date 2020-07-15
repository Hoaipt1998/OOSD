namespace QuanLyThuVien1
{
    partial class TaiKhoan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaiKhoan));
            this.buttonThoat = new System.Windows.Forms.Button();
            this.buttonDoiMK = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbTK = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbMK = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonThoat
            // 
            this.buttonThoat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonThoat.BackgroundImage")));
            this.buttonThoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonThoat.ForeColor = System.Drawing.Color.Teal;
            this.buttonThoat.Location = new System.Drawing.Point(87, 221);
            this.buttonThoat.Name = "buttonThoat";
            this.buttonThoat.Size = new System.Drawing.Size(90, 31);
            this.buttonThoat.TabIndex = 76;
            this.buttonThoat.Text = "Thoát";
            this.buttonThoat.UseVisualStyleBackColor = true;
            this.buttonThoat.Click += new System.EventHandler(this.buttonThoat_Click);
            // 
            // buttonDoiMK
            // 
            this.buttonDoiMK.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonDoiMK.BackgroundImage")));
            this.buttonDoiMK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonDoiMK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDoiMK.ForeColor = System.Drawing.Color.Teal;
            this.buttonDoiMK.Location = new System.Drawing.Point(211, 221);
            this.buttonDoiMK.Name = "buttonDoiMK";
            this.buttonDoiMK.Size = new System.Drawing.Size(115, 31);
            this.buttonDoiMK.TabIndex = 77;
            this.buttonDoiMK.Text = "Đổi mật khẩu";
            this.buttonDoiMK.UseVisualStyleBackColor = true;
            this.buttonDoiMK.Click += new System.EventHandler(this.buttonDoiMK_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(150, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 22);
            this.label6.TabIndex = 75;
            this.label6.Text = "TÀI KHOẢN";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(38, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 74;
            this.label1.Text = "Tài khoản:";
            // 
            // tbTK
            // 
            this.tbTK.Location = new System.Drawing.Point(116, 91);
            this.tbTK.Multiline = true;
            this.tbTK.Name = "tbTK";
            this.tbTK.Size = new System.Drawing.Size(182, 28);
            this.tbTK.TabIndex = 73;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(38, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 79;
            this.label2.Text = "Mật khẩu:";
            // 
            // tbMK
            // 
            this.tbMK.Location = new System.Drawing.Point(116, 165);
            this.tbMK.Multiline = true;
            this.tbMK.Name = "tbMK";
            this.tbMK.Size = new System.Drawing.Size(182, 28);
            this.tbMK.TabIndex = 78;
            // 
            // TaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(415, 297);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbMK);
            this.Controls.Add(this.buttonThoat);
            this.Controls.Add(this.buttonDoiMK);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbTK);
            this.Name = "TaiKhoan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "TaiKhoan";
            this.Load += new System.EventHandler(this.TaiKhoan_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonThoat;
        private System.Windows.Forms.Button buttonDoiMK;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbTK;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbMK;
    }
}