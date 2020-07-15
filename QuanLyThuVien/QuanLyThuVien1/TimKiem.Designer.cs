namespace QuanLyThuVien1
{
    partial class TimKiem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TimKiem));
            this.buttonTimKiemMa = new System.Windows.Forms.Button();
            this.buttonTimKiemTen = new System.Windows.Forms.Button();
            this.dgvTK = new System.Windows.Forms.DataGridView();
            this.tbID = new System.Windows.Forms.TextBox();
            this.tbTS = new System.Windows.Forms.TextBox();
            this.tbLS = new System.Windows.Forms.TextBox();
            this.tbKS = new System.Windows.Forms.TextBox();
            this.tbSL = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbTK = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonThoat = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonTimKiemMa
            // 
            this.buttonTimKiemMa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonTimKiemMa.BackgroundImage")));
            this.buttonTimKiemMa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonTimKiemMa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTimKiemMa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonTimKiemMa.Location = new System.Drawing.Point(505, 50);
            this.buttonTimKiemMa.Name = "buttonTimKiemMa";
            this.buttonTimKiemMa.Size = new System.Drawing.Size(168, 30);
            this.buttonTimKiemMa.TabIndex = 1;
            this.buttonTimKiemMa.Text = "Tìm kiếm theo mã sách";
            this.buttonTimKiemMa.UseVisualStyleBackColor = true;
            this.buttonTimKiemMa.Click += new System.EventHandler(this.buttonTimKiemMa_Click);
            // 
            // buttonTimKiemTen
            // 
            this.buttonTimKiemTen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonTimKiemTen.BackgroundImage")));
            this.buttonTimKiemTen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonTimKiemTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTimKiemTen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonTimKiemTen.Location = new System.Drawing.Point(505, 19);
            this.buttonTimKiemTen.Name = "buttonTimKiemTen";
            this.buttonTimKiemTen.Size = new System.Drawing.Size(168, 30);
            this.buttonTimKiemTen.TabIndex = 2;
            this.buttonTimKiemTen.Text = "Tìm kiếm theo tên sách";
            this.buttonTimKiemTen.UseVisualStyleBackColor = true;
            this.buttonTimKiemTen.Click += new System.EventHandler(this.buttonTimKiemTen_Click);
            // 
            // dgvTK
            // 
            this.dgvTK.BackgroundColor = System.Drawing.Color.White;
            this.dgvTK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTK.Location = new System.Drawing.Point(239, 86);
            this.dgvTK.Name = "dgvTK";
            this.dgvTK.Size = new System.Drawing.Size(434, 332);
            this.dgvTK.TabIndex = 3;
            this.dgvTK.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTK_CellClick);
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(84, 123);
            this.tbID.Multiline = true;
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(133, 28);
            this.tbID.TabIndex = 4;
            // 
            // tbTS
            // 
            this.tbTS.Location = new System.Drawing.Point(84, 171);
            this.tbTS.Multiline = true;
            this.tbTS.Name = "tbTS";
            this.tbTS.Size = new System.Drawing.Size(133, 28);
            this.tbTS.TabIndex = 5;
            // 
            // tbLS
            // 
            this.tbLS.Location = new System.Drawing.Point(84, 216);
            this.tbLS.Multiline = true;
            this.tbLS.Name = "tbLS";
            this.tbLS.Size = new System.Drawing.Size(133, 28);
            this.tbLS.TabIndex = 6;
            // 
            // tbKS
            // 
            this.tbKS.Location = new System.Drawing.Point(84, 263);
            this.tbKS.Multiline = true;
            this.tbKS.Name = "tbKS";
            this.tbKS.Size = new System.Drawing.Size(133, 28);
            this.tbKS.TabIndex = 7;
            // 
            // tbSL
            // 
            this.tbSL.Location = new System.Drawing.Point(84, 313);
            this.tbSL.Multiline = true;
            this.tbSL.Name = "tbSL";
            this.tbSL.Size = new System.Drawing.Size(133, 28);
            this.tbSL.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Mã sách:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Tên sách:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Loại sách:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 263);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Kê sách:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 313);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Số lượng:";
            // 
            // tbTK
            // 
            this.tbTK.Location = new System.Drawing.Point(281, 19);
            this.tbTK.Multiline = true;
            this.tbTK.Name = "tbTK";
            this.tbTK.Size = new System.Drawing.Size(206, 30);
            this.tbTK.TabIndex = 12;
            this.tbTK.TextChanged += new System.EventHandler(this.tbTK_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Teal;
            this.label6.Location = new System.Drawing.Point(12, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(223, 44);
            this.label6.TabIndex = 14;
            this.label6.Text = "THƯ VIÊN BÁCH KHOA\r\n         TOÀN THƯ";
            // 
            // buttonThoat
            // 
            this.buttonThoat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonThoat.BackgroundImage")));
            this.buttonThoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonThoat.Location = new System.Drawing.Point(55, 373);
            this.buttonThoat.Name = "buttonThoat";
            this.buttonThoat.Size = new System.Drawing.Size(123, 45);
            this.buttonThoat.TabIndex = 15;
            this.buttonThoat.Text = "Thoát";
            this.buttonThoat.UseVisualStyleBackColor = true;
            this.buttonThoat.Click += new System.EventHandler(this.buttonThoat_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(241, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 30);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // TimKiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(686, 432);
            this.Controls.Add(this.buttonThoat);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tbTK);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbSL);
            this.Controls.Add(this.tbKS);
            this.Controls.Add(this.tbLS);
            this.Controls.Add(this.tbTS);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.dgvTK);
            this.Controls.Add(this.buttonTimKiemTen);
            this.Controls.Add(this.buttonTimKiemMa);
            this.Name = "TimKiem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "TimKiem";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonTimKiemMa;
        private System.Windows.Forms.Button buttonTimKiemTen;
        private System.Windows.Forms.DataGridView dgvTK;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.TextBox tbTS;
        private System.Windows.Forms.TextBox tbLS;
        private System.Windows.Forms.TextBox tbKS;
        private System.Windows.Forms.TextBox tbSL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbTK;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonThoat;
    }
}