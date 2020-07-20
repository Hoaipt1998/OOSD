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
    public partial class TimKiem : Form
    {
        BLsach sach = new BLsach();
        public TimKiem()
        {
            InitializeComponent();
        }

       
        private void dgvTK_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvTK.CurrentCell.RowIndex;
            tbID.Text = dgvTK.Rows[r].Cells[0].Value.ToString();
            tbTS.Text = dgvTK.Rows[r].Cells[1].Value.ToString();
            tbLS.Text = dgvTK.Rows[r].Cells[2].Value.ToString();
            tbKS.Text = dgvTK.Rows[r].Cells[3].Value.ToString();
            tbSL.Text = dgvTK.Rows[r].Cells[4].Value.ToString();
        }

       
        private void tbTK_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonTimKiemTen_Click(object sender, EventArgs e)
        {
            
           
            BLsach.Instance.SetSearchAlgorithm(new SearchTenSach());
            DataTable tb = BLsach.Instance.timsach(tbTK.Text);
            dgvTK.DataSource = tb;
            dgvTK.AutoResizeColumns();
        }

        private void buttonTimKiemMa_Click(object sender, EventArgs e)
        {
            BLsach.Instance.SetSearchAlgorithm(new SearchLoaiSach());
            DataTable tb = BLsach.Instance.timsach(tbTK.Text);
            dgvTK.DataSource = tb;
        }

        private void buttonThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form TC = new TrangChu();
            TC.ShowDialog();
            this.Close();
        }
    }
}
