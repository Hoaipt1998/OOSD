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
using System.Windows.Forms.VisualStyles;

namespace QuanLyThuVien1
{
    public partial class DocGia : Form
    {
        DataTable dt = null;
        BLdocgia dg = new BLdocgia();
        DataSet ds = null;
        public string err;
        private bool them = false;
        private bool sua = false;
        public DocGia()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(them)
            {
                dg.themdocgia(tbID.Text, tbTDG.Text, tbGT.Text, tbDC.Text, ref err);
                them = false;
                load();
            }  
            else if(sua)
            {
                dg.suadocgia(tbID.Text, tbTDG.Text, tbGT.Text, tbDC.Text, ref err);
                sua = false;
                load();
            }
            tbDC.Enabled = false;
            tbGT.Enabled = false;
            tbID.Enabled = false;
            tbTDG.Enabled = false;
            tbTK.Enabled = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void load()
        {
            tbDC.Enabled = false;
            tbGT.Enabled = false;
            tbID.Enabled = false; 
            tbTDG.Enabled = false;
            tbTK.Enabled = true;
            ds = new DataSet();
            ds = dg.Laydocgia();
            dgvDG.DataSource = ds.Tables[0];
            dgvDG.AutoResizeColumns();
            dgvDG.Columns[1].Width = 200;
            dgvDG.Columns[3].Width = 200;
        }

        private void dgvDG_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvDG.CurrentCell.RowIndex;
            tbID.Text = dgvDG.Rows[r].Cells[0].Value.ToString();
            tbTDG.Text = dgvDG.Rows[r].Cells[1].Value.ToString();
            tbGT.Text = dgvDG.Rows[r].Cells[2].Value.ToString();
            tbDC.Text = dgvDG.Rows[r].Cells[3].Value.ToString();
        }

        private void DocGia_Load(object sender, EventArgs e)
        {
            load();
        }

       
     

        private void button4_Click_1(object sender, EventArgs e)
        {
          
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            tbDC.Enabled = true;
            tbGT.Enabled = true;
            tbID.Enabled = true;
            tbTDG.Enabled = true;
            tbTK.Enabled = true;
            them = true;
            sua = false;
        }

        private void buttonSua_Click(object sender, EventArgs e)
        {
            tbDC.Enabled = true;
            tbGT.Enabled = true;
            tbTDG.Enabled = true;
            tbID.Enabled = false;
            tbTK.Enabled = true;
            sua = true;
            them = false;
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            DialogResult a = MessageBox.Show("Bạn có muốn xóa độc giả này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (a == DialogResult.Yes)
            {
                bool h = dg.xoadocgia(tbID.Text, ref err);
                if (h == false)
                {
                    MessageBox.Show("Bạn cần xóa những dữ liệu liên quan đến độc giả này !!!");
                }
                load();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (tbID.Text == "" || tbTDG.Text == "" || tbGT.Text == "" || tbDC.Text == "")
            {
                MessageBox.Show("Error", "Thieu Thong TIn", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (them)
                {
                    dg.themdocgia(tbID.Text, tbTDG.Text, tbGT.Text, tbDC.Text, ref err);
                    them = false;
                    load();
                }
                else if (sua)
                {
                    dg.suadocgia(tbID.Text, tbTDG.Text, tbGT.Text, tbDC.Text, ref err);
                    sua = false;
                    load();
                }
                tbID.Enabled = false;
                tbTDG.Enabled = false;
                tbGT.Enabled = false;
                tbDC.Enabled = false;
            }
        }

        private void buttonThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            GiaoDienChinh gd = new GiaoDienChinh();
            gd.ShowDialog();
            this.Close();
        }

        private void btnTK_Click(object sender, EventArgs e)
        {
            dt = new DataTable();
            dt.Clear();
            dt = dg.timkiemdg(tbTK.Text);
            dgvDG.DataSource = dt;
            dgvDG.AutoResizeColumns();
        }
    }
}
