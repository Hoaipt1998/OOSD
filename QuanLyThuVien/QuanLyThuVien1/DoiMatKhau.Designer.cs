namespace QuanLyThuVien1
{
    partial class DoiMatKhau
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoiMatKhau));
            this.label2 = new System.Windows.Forms.Label();
            this.tbRMK = new System.Windows.Forms.TextBox();
            this.buttonThoat = new System.Windows.Forms.Button();
            this.buttonXacNhan = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbMK = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(177, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 17);
            this.label2.TabIndex = 86;
            this.label2.Text = "Nhập lại mật khẩu:";
            // 
            // tbRMK
            // 
            this.tbRMK.Location = new System.Drawing.Point(352, 236);
            this.tbRMK.Multiline = true;
            this.tbRMK.Name = "tbRMK";
            this.tbRMK.Size = new System.Drawing.Size(182, 28);
            this.tbRMK.TabIndex = 85;
            // 
            // buttonThoat
            // 
            this.buttonThoat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonThoat.BackgroundImage")));
            this.buttonThoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonThoat.ForeColor = System.Drawing.Color.Teal;
            this.buttonThoat.Location = new System.Drawing.Point(211, 285);
            this.buttonThoat.Name = "buttonThoat";
            this.buttonThoat.Size = new System.Drawing.Size(90, 31);
            this.buttonThoat.TabIndex = 83;
            this.buttonThoat.Text = "Thoát";
            this.buttonThoat.UseVisualStyleBackColor = true;
            this.buttonThoat.Click += new System.EventHandler(this.buttonThoat_Click);
            // 
            // buttonXacNhan
            // 
            this.buttonXacNhan.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonXacNhan.BackgroundImage")));
            this.buttonXacNhan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonXacNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonXacNhan.ForeColor = System.Drawing.Color.Teal;
            this.buttonXacNhan.Location = new System.Drawing.Point(375, 285);
            this.buttonXacNhan.Name = "buttonXacNhan";
            this.buttonXacNhan.Size = new System.Drawing.Size(90, 31);
            this.buttonXacNhan.TabIndex = 84;
            this.buttonXacNhan.Text = "Xác nhận";
            this.buttonXacNhan.UseVisualStyleBackColor = true;
            this.buttonXacNhan.Click += new System.EventHandler(this.buttonXacNhan_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(168, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 22);
            this.label6.TabIndex = 82;
            this.label6.Text = "ĐỔI MẬT KHẨU";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(169, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 17);
            this.label1.TabIndex = 81;
            this.label1.Text = "Nhập mật khẩu mới:";
            // 
            // tbMK
            // 
            this.tbMK.Location = new System.Drawing.Point(352, 135);
            this.tbMK.Multiline = true;
            this.tbMK.Name = "tbMK";
            this.tbMK.Size = new System.Drawing.Size(182, 28);
            this.tbMK.TabIndex = 80;
            // 
            // DoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(674, 377);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbRMK);
            this.Controls.Add(this.buttonThoat);
            this.Controls.Add(this.buttonXacNhan);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbMK);
            this.Name = "DoiMatKhau";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DoiMatkhau";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbRMK;
        private System.Windows.Forms.Button buttonThoat;
        private System.Windows.Forms.Button buttonXacNhan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbMK;
    }
}