using QuanLyThuVien1.BS_layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVien1
{
    public partial class PhieuMuon : Form
    {
        string err = "";
        DataSet ds = null;
        BLphieumuon pm = new BLphieumuon();
        BLdocgia dg = new BLdocgia();
        BLnhanvien nv = new BLnhanvien();
   
        private bool them = false;
        private bool sua = false;
        
        public PhieuMuon()
        {
            InitializeComponent();
        }

        private void PhieuMuon_Load(object sender, EventArgs e)
        {
            load();
        }
        private void load()
        {
            tbTT.Enabled = false;
            tbID.Enabled = false;
            comboBoxNguoiLap.Enabled = false;
            comboBoxSach.Enabled = false;
            comboBoxNguoiMuon.Enabled = false;
            dateTimePickerTra.Enabled = false;
            dateTimePickerMuon.Enabled = false;
            ds = pm.Layphieumuon();
            dgvPM.DataSource = ds.Tables[0];

            comboBoxSach.DataSource = BLsach.Instance.Laysach().Tables[0];
            comboBoxSach.DisplayMember = "tensach";
            comboBoxSach.ValueMember = "masach";
            comboBoxSach.SelectedItem = 1;

            comboBoxNguoiLap.DataSource = nv.Laynhanvien().Tables[0];
            comboBoxNguoiLap.DisplayMember = "tennhanvien";
            comboBoxNguoiLap.ValueMember = "manhanvien";
            comboBoxNguoiLap.SelectedItem = 1;

            comboBoxNguoiMuon.DataSource = dg.Laydocgia().Tables[0];
            comboBoxNguoiMuon.DisplayMember = "tendocgia";
            comboBoxNguoiMuon.ValueMember = "madocgia";
            comboBoxNguoiMuon.SelectedItem = 1;
            




        }

        private void dgvPM_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvPM.CurrentCell.RowIndex;
            tbID.Text = dgvPM.Rows[r].Cells[0].Value.ToString();
            comboBoxNguoiMuon.Text = dgvPM.Rows[r].Cells[6].Value.ToString();
            comboBoxSach.Text = dgvPM.Rows[r].Cells[4].Value.ToString();
            comboBoxNguoiLap.Text = dgvPM.Rows[r].Cells[3].Value.ToString();
            dateTimePickerTra.Text =(dgvPM.Rows[r].Cells[2].Value).ToString();
            dateTimePickerMuon.Text = dgvPM.Rows[r].Cells[1].Value.ToString();
            tbTT.Text = dgvPM.Rows[r].Cells[7].Value.ToString();
            comboBoxNguoiLap.Enabled = false;
            comboBoxSach.Enabled = false;
            comboBoxNguoiMuon.Enabled = false;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
           
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            load();
            them = true;
            sua = false;
            tbTT.Enabled = true;
            tbID.Enabled = true;
            comboBoxNguoiLap.Enabled = true;
            comboBoxSach.Enabled = true;
            comboBoxNguoiMuon.Enabled = true;
            dateTimePickerMuon.Value = DateTime.Now;
            dateTimePickerTra.Enabled = true;
            dateTimePickerMuon.Value = DateTime.Now;
            

        }

        private void buttonSua_Click(object sender, EventArgs e)
        {
            if (sua == true)
            {
                MessageBox.Show("Chọn rồi mà!!! Chọn hoài vậy !!!");
            }
            else
            {
                string masach = comboBoxSach.Text;
                string manhanvien = comboBoxNguoiLap.Text;
                string madocgia = comboBoxNguoiMuon.Text;
                DataTable table = new DataTable();
                DataTable table1 = new DataTable();
                DataTable table2 = new DataTable();
                table = BLsach.Instance.laysachId(masach).Tables[0];
                table1 = nv.laynhanvienId(manhanvien).Tables[0];
                table2 = dg.laydocgiaId(madocgia).Tables[0];
                if (tbID.Text == "" || table.Rows.Count < 1 || table1.Rows.Count < 1 || table2.Rows.Count < 1)
                {
                    MessageBox.Show("Bạn cần chọn phiếu mượn muốn sửa để thực hiện thao tác này !!!");
                }
                else
                {
                    sua = true;
                    them = false;
                    tbTT.Enabled = true;
                    tbID.Enabled = false;
                    comboBoxNguoiMuon.Enabled = true;
                    comboBoxSach.Enabled = true;
                    comboBoxNguoiLap.Enabled = true;
                    dateTimePickerTra.Enabled = true;
                    comboBoxSach.Text = table.Rows[0]["tensach"].ToString();
                    comboBoxNguoiLap.Text = table1.Rows[0]["tennhanvien"].ToString();
                    comboBoxNguoiMuon.Text = table2.Rows[0]["tendocgia"].ToString();
                }
            }




        }
        

        private void buttonLuu_Click(object sender, EventArgs e)
        {
            BLphieumuon bLphieumuon = new BLphieumuon();
            if (tbID.Text == "" || comboBoxNguoiMuon.Text == "" || comboBoxSach.Text == "" || comboBoxNguoiLap.Text == "" || tbTT.Text == "")
            {
                MessageBox.Show("Error", "Thieu Thong TIn", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (them)
                {
                    bLphieumuon.themphieumuon1(tbID.Text, dateTimePickerMuon.Value, dateTimePickerTra.Value, comboBoxNguoiLap.SelectedValue.ToString(), comboBoxSach.SelectedValue.ToString(), comboBoxNguoiMuon.SelectedValue.ToString(), 1, tbTT.Text);
                    them = false;
                    load();
                }
                else if (sua)
                {
                    bLphieumuon.suaphieumuon(tbID.Text, dateTimePickerMuon.Value, dateTimePickerTra.Value, comboBoxNguoiLap.SelectedValue.ToString(), comboBoxSach.SelectedValue.ToString(), comboBoxNguoiMuon.SelectedValue.ToString(), 1, tbTT.Text);
                    sua = false;
                    load();
                }
                tbTT.Enabled = false;
                tbID.Enabled = false;
                comboBoxNguoiMuon.Enabled = false;
                comboBoxSach.Enabled = false;
                comboBoxNguoiLap.Enabled = false;

                dateTimePickerTra.Enabled = false;
            }
        }

        private void buttonThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            GiaoDienChinh gd = new GiaoDienChinh();
            gd.ShowDialog();
            this.Close();
        }

        private void comboBoxSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string masach = Convert.ToString(comboBoxSach.SelectedValue);
                DataTable table = new DataTable();
                table = BLsach.Instance.laysachId(masach).Tables[0];

            }
            catch
            {

            }
        }

        private void comboBoxNguoiMuon_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string madocgia = Convert.ToString(comboBoxNguoiMuon.SelectedValue);
                DataTable table = new DataTable();
                table = dg.laydocgiaId(madocgia).Tables[0];

            }
            catch
            {

            }
        }

        private void comboBoxNguoiLap_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string manhanvien = Convert.ToString(comboBoxSach.SelectedValue);
                DataTable table = new DataTable();
                table = nv.laynhanvienId(manhanvien).Tables[0];

            }
            catch
            {

            }
        }

        private void buttonxoa_Click(object sender, EventArgs e)
        {
            DialogResult a = MessageBox.Show("Bạn có muốn xóa phiếu mượn này", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (a == DialogResult.Yes)
            {
                bool h = pm.xoa(tbID.Text, ref err);
                if (h == false)
                {
                    MessageBox.Show("Bạn cần xóa những dữ liệu liên quan đến sách này !!!");
                }
                load();
            }
        }

        private void dgvPM_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonTimKiemPM_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Clear();
            dt = pm.timkiempm(tbTK.Text);
            dgvPM.DataSource = dt;
            dgvPM.AutoResizeColumns();
        }
    }
}
