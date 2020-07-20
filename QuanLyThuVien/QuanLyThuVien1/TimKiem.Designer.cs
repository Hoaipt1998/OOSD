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
            ((System.ComponentModel.ISupportInitialize)(this.dgvTK)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonTimKiemMa
            // 
            this.buttonTimKiemMa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonTimKiemMa.BackgroundImage")));
            this.buttonTimKiemMa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonTimKiemMa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTimKiemMa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonTimKiemMa.Location = new System.Drawing.Point(797, 85);
            this.buttonTimKiemMa.Margin = new System.Windows.Forms.Padding(5);
            this.buttonTimKiemMa.Name = "buttonTimKiemMa";
            this.buttonTimKiemMa.Size = new System.Drawing.Size(280, 46);
            this.buttonTimKiemMa.TabIndex = 1;
            this.buttonTimKiemMa.Text = "Tìm kiếm theo loại sách";
            this.buttonTimKiemMa.UseVisualStyleBackColor = true;
            this.buttonTimKiemMa.Click += new System.EventHandler(this.buttonTimKiemMa_Click);
            // 
            // buttonTimKiemTen
            // 
            this.buttonTimKiemTen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonTimKiemTen.BackgroundImage")));
            this.buttonTimKiemTen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonTimKiemTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTimKiemTen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonTimKiemTen.Location = new System.Drawing.Point(797, 29);
            this.buttonTimKiemTen.Margin = new System.Windows.Forms.Padding(5);
            this.buttonTimKiemTen.Name = "buttonTimKiemTen";
            this.buttonTimKiemTen.Size = new System.Drawing.Size(280, 46);
            this.buttonTimKiemTen.TabIndex = 2;
            this.buttonTimKiemTen.Text = "Tìm kiếm theo tên sách";
            this.buttonTimKiemTen.UseVisualStyleBackColor = true;
            this.buttonTimKiemTen.Click += new System.EventHandler(this.buttonTimKiemTen_Click);
            // 
            // dgvTK
            // 
            this.dgvTK.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTK.BackgroundColor = System.Drawing.Color.White;
            this.dgvTK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTK.Location = new System.Drawing.Point(398, 141);
            this.dgvTK.Margin = new System.Windows.Forms.Padding(5);
            this.dgvTK.Name = "dgvTK";
            this.dgvTK.ReadOnly = true;
            this.dgvTK.Size = new System.Drawing.Size(679, 502);
            this.dgvTK.TabIndex = 3;
            this.dgvTK.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTK_CellClick);
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(140, 189);
            this.tbID.Margin = new System.Windows.Forms.Padding(5);
            this.tbID.Multiline = true;
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(219, 41);
            this.tbID.TabIndex = 4;
            // 
            // tbTS
            // 
            this.tbTS.Location = new System.Drawing.Point(140, 263);
            this.tbTS.Margin = new System.Windows.Forms.Padding(5);
            this.tbTS.Multiline = true;
            this.tbTS.Name = "tbTS";
            this.tbTS.Size = new System.Drawing.Size(219, 41);
            this.tbTS.TabIndex = 5;
            // 
            // tbLS
            // 
            this.tbLS.Location = new System.Drawing.Point(140, 332);
            this.tbLS.Margin = new System.Windows.Forms.Padding(5);
            this.tbLS.Multiline = true;
            this.tbLS.Name = "tbLS";
            this.tbLS.Size = new System.Drawing.Size(219, 41);
            this.tbLS.TabIndex = 6;
            // 
            // tbKS
            // 
            this.tbKS.Location = new System.Drawing.Point(140, 405);
            this.tbKS.Margin = new System.Windows.Forms.Padding(5);
            this.tbKS.Multiline = true;
            this.tbKS.Name = "tbKS";
            this.tbKS.Size = new System.Drawing.Size(219, 41);
            this.tbKS.TabIndex = 7;
            // 
            // tbSL
            // 
            this.tbSL.Location = new System.Drawing.Point(140, 482);
            this.tbSL.Margin = new System.Windows.Forms.Padding(5);
            this.tbSL.Multiline = true;
            this.tbSL.Name = "tbSL";
            this.tbSL.Size = new System.Drawing.Size(219, 41);
            this.tbSL.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 198);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Mã sách:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 263);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Tên sách:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 332);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Loại sách:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 405);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Kê sách:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 482);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Số lượng:";
            // 
            // tbTK
            // 
            this.tbTK.Location = new System.Drawing.Point(398, 29);
            this.tbTK.Margin = new System.Windows.Forms.Padding(5);
            this.tbTK.Multiline = true;
            this.tbTK.Name = "tbTK";
            this.tbTK.Size = new System.Drawing.Size(341, 44);
            this.tbTK.TabIndex = 12;
            this.tbTK.TextChanged += new System.EventHandler(this.tbTK_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Teal;
            this.label6.Location = new System.Drawing.Point(20, 26);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
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
            this.buttonThoat.Location = new System.Drawing.Point(140, 563);
            this.buttonThoat.Margin = new System.Windows.Forms.Padding(5);
            this.buttonThoat.Name = "buttonThoat";
            this.buttonThoat.Size = new System.Drawing.Size(219, 69);
            this.buttonThoat.TabIndex = 15;
            this.buttonThoat.Text = "Thoát";
            this.buttonThoat.UseVisualStyleBackColor = true;
            this.buttonThoat.Click += new System.EventHandler(this.buttonThoat_Click);
            // 
            // TimKiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1143, 665);
            this.Controls.Add(this.buttonThoat);
            this.Controls.Add(this.label6);
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
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "TimKiem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "TimKiem";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTK)).EndInit();
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
        private System.Windows.Forms.Button buttonThoat;
    }
}