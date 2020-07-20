using QuanLyThuVien1.DB_layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVien1.BS_layer
{
    class BLloaisach
    {
        DBMain db = null;
        public BLloaisach()
        {
            db = new DBMain();
        }
        public DataSet Layloaisach()
        {
            string layloaisach = @"exec dbo.thongtinloaisach";
            return db.ExecuteQueryDataSet(layloaisach, CommandType.Text);
        }
        public bool xoaloaisach(string tenloaisach, ref string err)
        {
            string xoaloaisach = @"exec dbo.xoaloaisach N'" + tenloaisach + "'";
            return db.MyExecuteNonQuery(xoaloaisach, CommandType.Text, ref err);
        }
        public bool themloaisach(string maloaisach,string tenloaisach, ref string err)
        {
            string kiemtraloaisach = @"exec dbo.kiemtraloaisach N'" + maloaisach+ "'";
            string themloaisach = @"exec dbo.themloaisach N'" + maloaisach+ "',N'" + tenloaisach + "'";

            DataTable dt = db.ExecuteQueryDataTable(kiemtraloaisach, CommandType.Text);
            if (dt.Rows.Count>0)
            {
                MessageBox.Show("Da co ID nay roi", " Da Ton Tai");
                return false;
            }
            else return db.MyExecuteNonQuery(themloaisach, CommandType.Text, ref err);
        }
        public bool sualoaisach(string maloaisach,string tenloaisach, ref string err)
        {
            string sualoaisach = @"exec dbo.sualoaisach N'" + maloaisach + "',N'" + tenloaisach + "'";
            return db.MyExecuteNonQuery(sualoaisach, CommandType.Text, ref err);
        }
        public DataSet timkiem(string maloaisach)
        {
            string timkiem = @"exec dbo.timkiem N'" + maloaisach + "'";
            return db.ExecuteQueryDataSet(timkiem, CommandType.Text);
        }
        public DataSet layloaisachId(string maloaisach)
        {
            string layloaisachId = @"exec dbo.kiemtraloaisach  N'" + maloaisach + "'";
            return db.ExecuteQueryDataSet(layloaisachId, CommandType.Text);
        }
    }
}
