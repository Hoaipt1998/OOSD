namespace QuanLyThuVien1
{
    partial class KeSach
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KeSach));
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbTK = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbID = new System.Windows.Forms.TextBox();
            this.dgvKS = new System.Windows.Forms.DataGridView();
            this.buttonTimkiem = new System.Windows.Forms.Button();
            this.tbTenKe = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonThoat = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.buttonThem = new System.Windows.Forms.Button();
            this.buttonSua = new System.Windows.Forms.Button();
            this.buttonXoa = new System.Windows.Forms.Button();
            this.buttonLuu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKS)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Teal;
            this.label6.Location = new System.Drawing.Point(67, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 22);
            this.label6.TabIndex = 39;
            this.label6.Text = "KỆ SÁCH";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(255, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 30);
            this.pictureBox1.TabIndex = 38;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // tbTK
            // 
            this.tbTK.Location = new System.Drawing.Point(297, 24);
            this.tbTK.Multiline = true;
            this.tbTK.Name = "tbTK";
            this.tbTK.Size = new System.Drawing.Size(253, 30);
            this.tbTK.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Yellow;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 35;
            this.label1.Text = "Mã kệ:";
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(100, 133);
            this.tbID.Multiline = true;
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(133, 28);
            this.tbID.TabIndex = 33;
            // 
            // dgvKS
            // 
            this.dgvKS.BackgroundColor = System.Drawing.Color.White;
            this.dgvKS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKS.Location = new System.Drawing.Point(255, 96);
            this.dgvKS.Name = "dgvKS";
            this.dgvKS.Size = new System.Drawing.Size(295, 309);
            this.dgvKS.TabIndex = 32;
            this.dgvKS.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKS_CellClick);
            // 
            // buttonTimkiem
            // 
            this.buttonTimkiem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonTimkiem.BackgroundImage")));
            this.buttonTimkiem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonTimkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTimkiem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonTimkiem.Location = new System.Drawing.Point(297, 60);
            this.buttonTimkiem.Name = "buttonTimkiem";
            this.buttonTimkiem.Size = new System.Drawing.Size(253, 30);
            this.buttonTimkiem.TabIndex = 31;
            this.buttonTimkiem.Text = "Tìm kiếm theo tên";
            this.buttonTimkiem.UseVisualStyleBackColor = true;
            // 
            // tbTenKe
            // 
            this.tbTenKe.Location = new System.Drawing.Point(100, 181);
            this.tbTenKe.Multiline = true;
            this.tbTenKe.Name = "tbTenKe";
            this.tbTenKe.Size = new System.Drawing.Size(133, 28);
            this.tbTenKe.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Yellow;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 36;
            this.label2.Text = "Tên kệ:";
            // 
            // buttonThoat
            // 
            this.buttonThoat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonThoat.BackgroundImage")));
            this.buttonThoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonThoat.Location = new System.Drawing.Point(58, 352);
            this.buttonThoat.Margin = new System.Windows.Forms.Padding(2);
            this.buttonThoat.Name = "buttonThoat";
            this.buttonThoat.Size = new System.Drawing.Size(122, 32);
            this.buttonThoat.TabIndex = 60;
            this.buttonThoat.Text = "Thoát";
            this.buttonThoat.UseVisualStyleBackColor = true;
            this.buttonThoat.Click += new System.EventHandler(this.buttonThoat_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(31, 302);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(78, 32);
            this.button3.TabIndex = 61;
            this.button3.Text = "Xóa";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(136, 251);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 32);
            this.button1.TabIndex = 62;
            this.button1.Text = "Sửa";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(31, 251);
            this.button5.Margin = new System.Windows.Forms.Padding(2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(78, 32);
            this.button5.TabIndex = 63;
            this.button5.Text = "Thêm";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // buttonThem
            // 
            this.buttonThem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonThem.BackgroundImage")));
            this.buttonThem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonThem.Location = new System.Drawing.Point(31, 251);
            this.buttonThem.Margin = new System.Windows.Forms.Padding(2);
            this.buttonThem.Name = "buttonThem";
            this.buttonThem.Size = new System.Drawing.Size(78, 32);
            this.buttonThem.TabIndex = 63;
            this.buttonThem.Text = "Thêm";
            this.buttonThem.UseVisualStyleBackColor = true;
            this.buttonThem.Click += new System.EventHandler(this.buttonThem_Click);
            // 
            // buttonSua
            // 
            this.buttonSua.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonSua.BackgroundImage")));
            this.buttonSua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonSua.Location = new System.Drawing.Point(136, 251);
            this.buttonSua.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSua.Name = "buttonSua";
            this.buttonSua.Size = new System.Drawing.Size(78, 32);
            this.buttonSua.TabIndex = 62;
            this.buttonSua.Text = "Sửa";
            this.buttonSua.UseVisualStyleBackColor = true;
            this.buttonSua.Click += new System.EventHandler(this.buttonSua_Click);
            // 
            // buttonXoa
            // 
            this.buttonXoa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonXoa.BackgroundImage")));
            this.buttonXoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonXoa.Location = new System.Drawing.Point(31, 302);
            this.buttonXoa.Margin = new System.Windows.Forms.Padding(2);
            this.buttonXoa.Name = "buttonXoa";
            this.buttonXoa.Size = new System.Drawing.Size(78, 32);
            this.buttonXoa.TabIndex = 61;
            this.buttonXoa.Text = "Xóa";
            this.buttonXoa.UseVisualStyleBackColor = true;
            this.buttonXoa.Click += new System.EventHandler(this.buttonXoa_Click);
            // 
            // buttonLuu
            // 
            this.buttonLuu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonLuu.BackgroundImage")));
            this.buttonLuu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonLuu.Location = new System.Drawing.Point(136, 302);
            this.buttonLuu.Margin = new System.Windows.Forms.Padding(2);
            this.buttonLuu.Name = "buttonLuu";
            this.buttonLuu.Size = new System.Drawing.Size(78, 32);
            this.buttonLuu.TabIndex = 60;
            this.buttonLuu.Text = "Lưu";
            this.buttonLuu.UseVisualStyleBackColor = true;
            this.buttonLuu.Click += new System.EventHandler(this.buttonLuu_Click);
            // 
            // KeSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(566, 412);
            this.Controls.Add(this.buttonLuu);
            this.Controls.Add(this.buttonXoa);
            this.Controls.Add(this.buttonThoat);
            this.Controls.Add(this.buttonSua);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.buttonThem);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tbTK);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbTenKe);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.dgvKS);
            this.Controls.Add(this.buttonTimkiem);
            this.Name = "KeSach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "KeSach";
            this.Load += new System.EventHandler(this.KeSach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tbTK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.DataGridView dgvKS;
        private System.Windows.Forms.Button buttonTimkiem;
        private System.Windows.Forms.TextBox tbTenKe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonThoat;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button buttonThem;
        private System.Windows.Forms.Button buttonSua;
        private System.Windows.Forms.Button buttonXoa;
        private System.Windows.Forms.Button buttonLuu;
    }
}