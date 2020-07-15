namespace QuanLyThuVien1
{
    partial class LoaiSach
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoaiSach));
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbTK = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbTLS = new System.Windows.Forms.TextBox();
            this.dgvLS = new System.Windows.Forms.DataGridView();
            this.buttonTiemKiem = new System.Windows.Forms.Button();
            this.buttonThoat = new System.Windows.Forms.Button();
            this.buttonXoa = new System.Windows.Forms.Button();
            this.buttonSua = new System.Windows.Forms.Button();
            this.buttonThem = new System.Windows.Forms.Button();
            this.buttonLuu = new System.Windows.Forms.Button();
            this.tbID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLS)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Teal;
            this.label6.Location = new System.Drawing.Point(62, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 22);
            this.label6.TabIndex = 30;
            this.label6.Text = "LOẠI SÁCH";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(250, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 30);
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // tbTK
            // 
            this.tbTK.Location = new System.Drawing.Point(292, 15);
            this.tbTK.Multiline = true;
            this.tbTK.Name = "tbTK";
            this.tbTK.Size = new System.Drawing.Size(244, 30);
            this.tbTK.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 17);
            this.label2.TabIndex = 27;
            this.label2.Text = "Tên thể loại:";
            // 
            // tbTLS
            // 
            this.tbTLS.Location = new System.Drawing.Point(96, 168);
            this.tbTLS.Multiline = true;
            this.tbTLS.Name = "tbTLS";
            this.tbTLS.Size = new System.Drawing.Size(133, 28);
            this.tbTLS.TabIndex = 19;
            // 
            // dgvLS
            // 
            this.dgvLS.BackgroundColor = System.Drawing.Color.White;
            this.dgvLS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLS.Location = new System.Drawing.Point(250, 87);
            this.dgvLS.Name = "dgvLS";
            this.dgvLS.Size = new System.Drawing.Size(286, 332);
            this.dgvLS.TabIndex = 17;
            this.dgvLS.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLS_CellClick);
            // 
            // buttonTiemKiem
            // 
            this.buttonTiemKiem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonTiemKiem.BackgroundImage")));
            this.buttonTiemKiem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonTiemKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTiemKiem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonTiemKiem.Location = new System.Drawing.Point(292, 51);
            this.buttonTiemKiem.Name = "buttonTiemKiem";
            this.buttonTiemKiem.Size = new System.Drawing.Size(244, 30);
            this.buttonTiemKiem.TabIndex = 15;
            this.buttonTiemKiem.Text = "Tìm kiếm theo tên";
            this.buttonTiemKiem.UseVisualStyleBackColor = true;
            this.buttonTiemKiem.Click += new System.EventHandler(this.buttonTiemKiem_Click);
            // 
            // buttonThoat
            // 
            this.buttonThoat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonThoat.BackgroundImage")));
            this.buttonThoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonThoat.Location = new System.Drawing.Point(57, 332);
            this.buttonThoat.Margin = new System.Windows.Forms.Padding(2);
            this.buttonThoat.Name = "buttonThoat";
            this.buttonThoat.Size = new System.Drawing.Size(131, 32);
            this.buttonThoat.TabIndex = 64;
            this.buttonThoat.Text = "Thoát";
            this.buttonThoat.UseVisualStyleBackColor = true;
            this.buttonThoat.Click += new System.EventHandler(this.buttonThoat_Click);
            // 
            // buttonXoa
            // 
            this.buttonXoa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonXoa.BackgroundImage")));
            this.buttonXoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonXoa.Location = new System.Drawing.Point(26, 286);
            this.buttonXoa.Margin = new System.Windows.Forms.Padding(2);
            this.buttonXoa.Name = "buttonXoa";
            this.buttonXoa.Size = new System.Drawing.Size(78, 32);
            this.buttonXoa.TabIndex = 65;
            this.buttonXoa.Text = "Xóa";
            this.buttonXoa.UseVisualStyleBackColor = true;
            this.buttonXoa.Click += new System.EventHandler(this.buttonXoa_Click);
            // 
            // buttonSua
            // 
            this.buttonSua.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonSua.BackgroundImage")));
            this.buttonSua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonSua.Location = new System.Drawing.Point(131, 230);
            this.buttonSua.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSua.Name = "buttonSua";
            this.buttonSua.Size = new System.Drawing.Size(78, 32);
            this.buttonSua.TabIndex = 66;
            this.buttonSua.Text = "Sửa";
            this.buttonSua.UseVisualStyleBackColor = true;
            this.buttonSua.Click += new System.EventHandler(this.buttonSua_Click);
            // 
            // buttonThem
            // 
            this.buttonThem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonThem.BackgroundImage")));
            this.buttonThem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonThem.Location = new System.Drawing.Point(26, 230);
            this.buttonThem.Margin = new System.Windows.Forms.Padding(2);
            this.buttonThem.Name = "buttonThem";
            this.buttonThem.Size = new System.Drawing.Size(78, 32);
            this.buttonThem.TabIndex = 67;
            this.buttonThem.Text = "Thêm";
            this.buttonThem.UseVisualStyleBackColor = true;
            this.buttonThem.Click += new System.EventHandler(this.buttonThem_Click);
            // 
            // buttonLuu
            // 
            this.buttonLuu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonLuu.BackgroundImage")));
            this.buttonLuu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonLuu.Location = new System.Drawing.Point(131, 286);
            this.buttonLuu.Margin = new System.Windows.Forms.Padding(2);
            this.buttonLuu.Name = "buttonLuu";
            this.buttonLuu.Size = new System.Drawing.Size(78, 32);
            this.buttonLuu.TabIndex = 64;
            this.buttonLuu.Text = "Lưu";
            this.buttonLuu.UseVisualStyleBackColor = true;
            this.buttonLuu.Click += new System.EventHandler(this.buttonLuu_Click);
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(96, 111);
            this.tbID.Multiline = true;
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(133, 28);
            this.tbID.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 27;
            this.label1.Text = "Mã LS:";
            // 
            // LoaiSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(558, 433);
            this.Controls.Add(this.buttonLuu);
            this.Controls.Add(this.buttonThoat);
            this.Controls.Add(this.buttonXoa);
            this.Controls.Add(this.buttonSua);
            this.Controls.Add(this.buttonThem);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tbTK);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.tbTLS);
            this.Controls.Add(this.dgvLS);
            this.Controls.Add(this.buttonTiemKiem);
            this.Name = "LoaiSach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "LoaiSach";
            this.Load += new System.EventHandler(this.LoaiSach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tbTK;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbTLS;
        private System.Windows.Forms.DataGridView dgvLS;
        private System.Windows.Forms.Button buttonTiemKiem;
        private System.Windows.Forms.Button buttonThoat;
        private System.Windows.Forms.Button buttonXoa;
        private System.Windows.Forms.Button buttonSua;
        private System.Windows.Forms.Button buttonThem;
        private System.Windows.Forms.Button buttonLuu;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Label label1;
    }
}