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
        DataSet ds = null;
        BLphieumuon pm = new BLphieumuon();
        BLdocgia dg = new BLdocgia();
        string err = "";
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
            tbNM.Enabled = false;
            tbSM.Enabled = false;
            tbNL.Enabled = false;
            tbGTT.Enabled = false;
            tbTG.Enabled = false;
            ds = pm.Layphieumuon();
            dgvPM.DataSource = ds.Tables[0];

         


        }

        private void dgvPM_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvPM.CurrentCell.RowIndex;
            tbID.Text = dgvPM.Rows[r].Cells[0].Value.ToString();
            tbNM.Text = dgvPM.Rows[r].Cells[6].Value.ToString();
            tbSM.Text = dgvPM.Rows[r].Cells[4].Value.ToString();
            tbNL.Text = dgvPM.Rows[r].Cells[3].Value.ToString();
            tbGTT.Text = dgvPM.Rows[r].Cells[2].Value.ToString();
            tbTG.Text = dgvPM.Rows[r].Cells[1].Value.ToString();
            tbTT.Text = dgvPM.Rows[r].Cells[7].Value.ToString();
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
            them = true;
            sua = false;
            tbTT.Enabled = true;
            tbID.Enabled = true;
            tbNM.Enabled = true;
            tbSM.Enabled = true;
            tbNL.Enabled = true;
            tbGTT.Enabled = true;
            tbTG.Enabled = true;
        }

        private void buttonSua_Click(object sender, EventArgs e)
        {
            sua = true;
            them = false;
            tbTT.Enabled = true;
            tbID.Enabled = false;
            tbNM.Enabled = true;
            tbSM.Enabled = true;
            tbNL.Enabled = true;
            tbGTT.Enabled = true;
            tbTG.Enabled = true;
        }

        private void buttonLuu_Click(object sender, EventArgs e)
        {
            if(them)
            {
                pm.themphieumuon(tbID.Text, tbTG.Text, tbGTT.Text, tbNL.Text, tbSM.Text, tbNM.Text, tbTT.Text, ref err);
                them = false;
                load();
            }
            else if (sua)
            {
                pm.suaphieumuon(tbID.Text, tbTG.Text, tbGTT.Text, tbNL.Text, tbSM.Text, tbNM.Text, tbTT.Text, ref err);
                sua = false;
                load();
            }
            tbTT.Enabled = false;
            tbID.Enabled = false;
            tbNM.Enabled = false;
            tbSM.Enabled = false;
            tbNL.Enabled = false;
            tbGTT.Enabled = false;
            tbTG.Enabled = false;
        }

        private void buttonThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            GiaoDienChinh gd = new GiaoDienChinh();
            gd.ShowDialog();
            this.Close();
        }
    }
}
