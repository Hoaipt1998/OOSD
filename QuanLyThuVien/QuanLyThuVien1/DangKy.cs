using QuanLyThuVien1.BS_layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyThuVien1.Builder;

namespace QuanLyThuVien1
{
    public partial class DangKy : Form
    {
        string err;
        BLnhanvien nv = new BLnhanvien();
        
        public DangKy()
        {
            InitializeComponent();
        }


        private void buttonThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonDangKy_Click(object sender, EventArgs e)
        {
            
            if (tbSEX.Text == "" || tbDC.Text == "" || tbID.Text == "" || tbMK.Text == "" || tbNV.Text == "" || tbTK.Text == "")
                MessageBox.Show("Xin hãy điền đầy đủ thông tin!!!");
            else
            {
                try
                {
                    if (comboBoxLoaiTK.Text == "admin")
                    {
                        //nv.themnvn(tbID.Text, tbTK.Text, tbMK.Text, tbLTK.Text, tbNV.Text, tbDC.Text, tbSEX.Text, ref err);
                        NhanVienBuiderDirectory buiderDirectory = new NhanVienBuiderDirectory();
                        AdminBuilder adminBuilder = new AdminBuilder();
                        controllerNhanVien adminnhanvien = buiderDirectory.Construct(adminBuilder, tbID.Text, tbTK.Text, tbMK.Text, tbNV.Text, tbDC.Text, tbSEX.Text);
                        if (nv.themnvn(adminnhanvien, ref err))
                        {
                            MessageBox.Show("Đã thêm xong rồi nè, hihi");
                        }
                    }
                    else if (comboBoxLoaiTK.Text == "thuthu")
                    {
                        //nv.themnvn(tbID.Text, tbTK.Text, tbMK.Text, tbLTK.Text, tbNV.Text, tbDC.Text, tbSEX.Text, ref err);
                        NhanVienBuiderDirectory buiderDirectory = new NhanVienBuiderDirectory();
                        ThuThuBuilder thuThuBuilder = new ThuThuBuilder();
                        controllerNhanVien thuthunhanvien = buiderDirectory.Construct(thuThuBuilder, tbID.Text, tbTK.Text, tbMK.Text, tbNV.Text, tbDC.Text, tbSEX.Text);
                        if (nv.themnvn(thuthunhanvien, ref err))
                        {
                            MessageBox.Show("Đã thêm xong rồi nè, hihi");
                        }
                    }
                    else if (comboBoxLoaiTK.Text == "docgia")
                    {
                        //nv.themnvn(tbID.Text, tbTK.Text, tbMK.Text, tbLTK.Text, tbNV.Text, tbDC.Text, tbSEX.Text, ref err);
                        NhanVienBuiderDirectory buiderDirectory = new NhanVienBuiderDirectory();
                        DocGiaBuilder docGiaBuilder = new DocGiaBuilder();
                        controllerNhanVien docgianhanvien = buiderDirectory.Construct(docGiaBuilder, tbID.Text, tbTK.Text, tbMK.Text, tbNV.Text, tbDC.Text, tbSEX.Text);
                        if (nv.themnvn(docgianhanvien, ref err))
                        {
                            MessageBox.Show("Đã thêm xong rồi nè, hihi");
                        }
                    }
                }
                catch (SqlException)
                {
                    MessageBox.Show("Bị lỗi khi thêm rồi !!!");
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DangKy_Load(object sender, EventArgs e)
        {
            comboBoxLoaiTK.Items.Add("admin");
            comboBoxLoaiTK.Items.Add("thuthu");
            comboBoxLoaiTK.Items.Add("docgia");
        }
    }
}
