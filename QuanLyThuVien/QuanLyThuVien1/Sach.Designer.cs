namespace QuanLyThuVien1
{
    partial class Sach
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sach));
            this.label6 = new System.Windows.Forms.Label();
            this.tbTK = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbSL = new System.Windows.Forms.TextBox();
            this.tbTS = new System.Windows.Forms.TextBox();
            this.tbID = new System.Windows.Forms.TextBox();
            this.dgvS = new System.Windows.Forms.DataGridView();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonThoat = new System.Windows.Forms.Button();
            this.buttonXoa = new System.Windows.Forms.Button();
            this.buttonSua = new System.Windows.Forms.Button();
            this.buttonThem = new System.Windows.Forms.Button();
            this.Luu = new System.Windows.Forms.Button();
            this.comboBoxLoaiSach = new System.Windows.Forms.ComboBox();
            this.comboBoxKeSach = new System.Windows.Forms.ComboBox();
            this.radioButtonTenSach = new System.Windows.Forms.RadioButton();
            this.radioButtonLoaiSach = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvS)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Teal;
            this.label6.Location = new System.Drawing.Point(132, 34);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 31);
            this.label6.TabIndex = 30;
            this.label6.Text = "SÁCH";
            // 
            // tbTK
            // 
            this.tbTK.Location = new System.Drawing.Point(417, 40);
            this.tbTK.Margin = new System.Windows.Forms.Padding(5);
            this.tbTK.Multiline = true;
            this.tbTK.Name = "tbTK";
            this.tbTK.Size = new System.Drawing.Size(341, 44);
            this.tbTK.TabIndex = 0;
            this.tbTK.TextChanged += new System.EventHandler(this.tbTK_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(38, 483);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 20);
            this.label5.TabIndex = 24;
            this.label5.Text = "Số lượng:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(43, 406);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 25;
            this.label4.Text = "Kê sách:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 334);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 20);
            this.label3.TabIndex = 26;
            this.label3.Text = "Loại sách:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 265);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 27;
            this.label2.Text = "Tên sách:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 200);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 23;
            this.label1.Text = "Mã sách:";
            // 
            // tbSL
            // 
            this.tbSL.Location = new System.Drawing.Point(158, 483);
            this.tbSL.Margin = new System.Windows.Forms.Padding(5);
            this.tbSL.Multiline = true;
            this.tbSL.Name = "tbSL";
            this.tbSL.Size = new System.Drawing.Size(219, 34);
            this.tbSL.TabIndex = 22;
            // 
            // tbTS
            // 
            this.tbTS.Location = new System.Drawing.Point(158, 265);
            this.tbTS.Margin = new System.Windows.Forms.Padding(5);
            this.tbTS.Multiline = true;
            this.tbTS.Name = "tbTS";
            this.tbTS.Size = new System.Drawing.Size(219, 41);
            this.tbTS.TabIndex = 19;
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(158, 191);
            this.tbID.Margin = new System.Windows.Forms.Padding(5);
            this.tbID.Multiline = true;
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(219, 41);
            this.tbID.TabIndex = 18;
            // 
            // dgvS
            // 
            this.dgvS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvS.BackgroundColor = System.Drawing.Color.White;
            this.dgvS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvS.Location = new System.Drawing.Point(417, 134);
            this.dgvS.Margin = new System.Windows.Forms.Padding(5);
            this.dgvS.Name = "dgvS";
            this.dgvS.ReadOnly = true;
            this.dgvS.Size = new System.Drawing.Size(727, 594);
            this.dgvS.TabIndex = 17;
            this.dgvS.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvS_CellClick);
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonSearch.BackgroundImage")));
            this.buttonSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonSearch.Location = new System.Drawing.Point(863, 34);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(5);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(280, 52);
            this.buttonSearch.TabIndex = 1;
            this.buttonSearch.Text = "Tìm kiếm sách";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonThoat
            // 
            this.buttonThoat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonThoat.BackgroundImage")));
            this.buttonThoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonThoat.Location = new System.Drawing.Point(248, 720);
            this.buttonThoat.Name = "buttonThoat";
            this.buttonThoat.Size = new System.Drawing.Size(130, 49);
            this.buttonThoat.TabIndex = 60;
            this.buttonThoat.Text = "Thoát";
            this.buttonThoat.UseVisualStyleBackColor = true;
            this.buttonThoat.Click += new System.EventHandler(this.buttonThoat_Click);
            // 
            // buttonXoa
            // 
            this.buttonXoa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonXoa.BackgroundImage")));
            this.buttonXoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonXoa.Location = new System.Drawing.Point(73, 646);
            this.buttonXoa.Name = "buttonXoa";
            this.buttonXoa.Size = new System.Drawing.Size(130, 49);
            this.buttonXoa.TabIndex = 61;
            this.buttonXoa.Text = "Xóa";
            this.buttonXoa.UseVisualStyleBackColor = true;
            this.buttonXoa.Click += new System.EventHandler(this.buttonXoa_Click);
            // 
            // buttonSua
            // 
            this.buttonSua.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonSua.BackgroundImage")));
            this.buttonSua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonSua.Location = new System.Drawing.Point(248, 560);
            this.buttonSua.Name = "buttonSua";
            this.buttonSua.Size = new System.Drawing.Size(130, 49);
            this.buttonSua.TabIndex = 62;
            this.buttonSua.Text = "Sửa";
            this.buttonSua.UseVisualStyleBackColor = true;
            this.buttonSua.Click += new System.EventHandler(this.buttonSua_Click);
            // 
            // buttonThem
            // 
            this.buttonThem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonThem.BackgroundImage")));
            this.buttonThem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonThem.Location = new System.Drawing.Point(73, 560);
            this.buttonThem.Name = "buttonThem";
            this.buttonThem.Size = new System.Drawing.Size(130, 49);
            this.buttonThem.TabIndex = 63;
            this.buttonThem.Text = "Thêm";
            this.buttonThem.UseVisualStyleBackColor = true;
            this.buttonThem.Click += new System.EventHandler(this.buttonThem_Click);
            // 
            // Luu
            // 
            this.Luu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Luu.BackgroundImage")));
            this.Luu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Luu.Location = new System.Drawing.Point(248, 646);
            this.Luu.Name = "Luu";
            this.Luu.Size = new System.Drawing.Size(130, 49);
            this.Luu.TabIndex = 60;
            this.Luu.Text = "Lưu";
            this.Luu.UseVisualStyleBackColor = true;
            this.Luu.Click += new System.EventHandler(this.Luu_Click);
            // 
            // comboBoxLoaiSach
            // 
            this.comboBoxLoaiSach.FormattingEnabled = true;
            this.comboBoxLoaiSach.Location = new System.Drawing.Point(158, 334);
            this.comboBoxLoaiSach.Margin = new System.Windows.Forms.Padding(5);
            this.comboBoxLoaiSach.Name = "comboBoxLoaiSach";
            this.comboBoxLoaiSach.Size = new System.Drawing.Size(217, 28);
            this.comboBoxLoaiSach.TabIndex = 64;
            this.comboBoxLoaiSach.SelectedIndexChanged += new System.EventHandler(this.comboBoxLoaiSach_SelectedIndexChanged);
            // 
            // comboBoxKeSach
            // 
            this.comboBoxKeSach.FormattingEnabled = true;
            this.comboBoxKeSach.Location = new System.Drawing.Point(160, 406);
            this.comboBoxKeSach.Margin = new System.Windows.Forms.Padding(5);
            this.comboBoxKeSach.Name = "comboBoxKeSach";
            this.comboBoxKeSach.Size = new System.Drawing.Size(217, 28);
            this.comboBoxKeSach.TabIndex = 64;
            this.comboBoxKeSach.SelectedIndexChanged += new System.EventHandler(this.comboBoxKeSach_SelectedIndexChanged);
            // 
            // radioButtonTenSach
            // 
            this.radioButtonTenSach.AutoSize = true;
            this.radioButtonTenSach.Location = new System.Drawing.Point(417, 92);
            this.radioButtonTenSach.Name = "radioButtonTenSach";
            this.radioButtonTenSach.Size = new System.Drawing.Size(103, 24);
            this.radioButtonTenSach.TabIndex = 65;
            this.radioButtonTenSach.TabStop = true;
            this.radioButtonTenSach.Text = "Tên Sách";
            this.radioButtonTenSach.UseVisualStyleBackColor = true;
            // 
            // radioButtonLoaiSach
            // 
            this.radioButtonLoaiSach.AutoSize = true;
            this.radioButtonLoaiSach.Location = new System.Drawing.Point(651, 92);
            this.radioButtonLoaiSach.Name = "radioButtonLoaiSach";
            this.radioButtonLoaiSach.Size = new System.Drawing.Size(107, 24);
            this.radioButtonLoaiSach.TabIndex = 65;
            this.radioButtonLoaiSach.TabStop = true;
            this.radioButtonLoaiSach.Text = "Loại Sách";
            this.radioButtonLoaiSach.UseVisualStyleBackColor = true;
            // 
            // Sach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1192, 792);
            this.Controls.Add(this.radioButtonLoaiSach);
            this.Controls.Add(this.radioButtonTenSach);
            this.Controls.Add(this.comboBoxKeSach);
            this.Controls.Add(this.comboBoxLoaiSach);
            this.Controls.Add(this.Luu);
            this.Controls.Add(this.buttonThoat);
            this.Controls.Add(this.buttonXoa);
            this.Controls.Add(this.buttonSua);
            this.Controls.Add(this.buttonThem);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbTK);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbSL);
            this.Controls.Add(this.tbTS);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.dgvS);
            this.Controls.Add(this.buttonSearch);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Sach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Sach";
            this.Load += new System.EventHandler(this.Sach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbTK;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbSL;
        private System.Windows.Forms.TextBox tbTS;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.DataGridView dgvS;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonThoat;
        private System.Windows.Forms.Button buttonXoa;
        private System.Windows.Forms.Button buttonSua;
        private System.Windows.Forms.Button buttonThem;
        private System.Windows.Forms.Button Luu;
        private System.Windows.Forms.ComboBox comboBoxLoaiSach;
        private System.Windows.Forms.ComboBox comboBoxKeSach;
        private System.Windows.Forms.RadioButton radioButtonTenSach;
        private System.Windows.Forms.RadioButton radioButtonLoaiSach;
    }
}