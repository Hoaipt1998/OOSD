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
    public partial class KeSach : Form
    {
        string err = "";
        BLke k = new BLke();
        DataSet ds = null;
        private bool them = false;
        private bool sua = false;
        public KeSach()
        {
            InitializeComponent();
        }

        private void dgvKS_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvKS.CurrentCell.RowIndex;
            tbID.Text = dgvKS.Rows[r].Cells[0].Value.ToString();
            tbTenKe.Text = dgvKS.Rows[r].Cells[1].Value.ToString();
        }
        private void load()
        {
            tbID.Enabled = false;
            tbTenKe.Enabled = false;
            ds = new DataSet();
            ds = k.Layke();
           

            dgvKS.DataSource = ds.Tables[0];
          
            dgvKS.Columns[1].Width = 150;
            //dgvKS.AutoResizeColumns();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        

        private void KeSach_Load(object sender, EventArgs e)
        {
            load();
        }

       
        private void buttonThem_Click(object sender, EventArgs e)
        {
            sua = false;
            tbID.Enabled = true;
            tbTenKe.Enabled = true;
            them = true;
        }

        private void buttonSua_Click(object sender, EventArgs e)
        {
            them = false;
            tbID.Enabled = true;
            tbTenKe.Enabled = true;
            sua = true;
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            DialogResult a = MessageBox.Show("Bạn có muốn xóa kệ sách này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (a == DialogResult.Yes)
            {
                bool h = k.xoake(tbID.Text, ref err);
                if (h == false)
                {
                    MessageBox.Show("Bạn cần xóa những dữ liệu liên quan đến kệ này !!!");
                }
                load();
            }
        }

        private void buttonLuu_Click(object sender, EventArgs e)
        {
            if (tbID.Text == "" || tbTenKe.Text == "")
            {
                MessageBox.Show("Error", "Thieu Thong TIn", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (them)
                {
                    k.themke(tbID.Text, tbTenKe.Text, ref err);
                    them = false;
                    load();
                }
                else if (sua)
                {
                    k.suake(tbID.Text, tbTenKe.Text, ref err);
                    sua = false;
                    load();
                }
                tbID.Enabled = false;
                tbTenKe.Enabled = false;
            }
        }

        private void buttonThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            GiaoDienChinh gd = new GiaoDienChinh();
            gd.ShowDialog();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
