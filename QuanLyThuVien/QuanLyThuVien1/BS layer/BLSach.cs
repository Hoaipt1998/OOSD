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
    class BLsach
    {
        DBMain db = null;
        private static BLsach instance;
        private ISearchAlgorithm _Search;

        public static BLsach Instance
        {
            get
            {
                if (instance == null) instance = new BLsach();
                return instance;
            }

            set
            {
                instance = value;
            }
        }

        public BLsach()
        {
            db = new DBMain();
        }
        public BLsach(ISearchAlgorithm searchAlgorithm)
        {
            this._Search = searchAlgorithm;
        }
        public void SetSearchAlgorithm(ISearchAlgorithm searchAlgorithm)
        {
            this._Search = searchAlgorithm;

        }

        public DataSet Laysach()
        {
            string laysach = @"exec dbo.thongtinsach";
            return db.ExecuteQueryDataSet(laysach, CommandType.Text);
        }
        public bool xoasach(string masach, ref string err)
        {
            string xoasach = @"exec dbo.xoasach N'" + masach + "'";
            return db.MyExecuteNonQuery(xoasach, CommandType.Text, ref err);
        }
        public bool themsach(string masach, string tensach,string tenloaisach, int soluong, string make, ref string err)
        {

            string kiemtrasach = @"exec dbo.kiemtrasach N'" + masach + "'";
            string themsach = @"exec dbo.themsach N'" + masach + "',N'" + tensach + "',N'" + tenloaisach + "',N'" + soluong + "',N'" + make + "'";

            DataTable dt = db.ExecuteQueryDataTable(kiemtrasach, CommandType.Text);
            if (dt.Rows.Count >0)
            {
                MessageBox.Show("Da co ID nay roi", " Da Ton Tai");
                return false;
            }
            else return db.MyExecuteNonQuery(themsach, CommandType.Text, ref err);
        }
        public bool suasach(string masach, string tensach,string tenloaisach, int soluong, string make, ref string err)
        {
            string suasach = @"exec dbo.suasach N'" + masach + "',N'" + tensach + "',N'" + tenloaisach + "',N'" + soluong + "',N'" + make + "'";
            return db.MyExecuteNonQuery(suasach, CommandType.Text, ref err);
        }
        public DataTable timkiem2(string tensach)
        {
            string timkiem = @"exec dbo.timkiemsach2 N'" + tensach + "'";
            return db.ExecuteQueryDataTable(timkiem, CommandType.Text);
        }
        public DataTable timkiem1(string masach)
        {
            string timkiem = @"exec dbo.timkiemsach1 N'" + masach + "'";
            return db.ExecuteQueryDataTable(timkiem, CommandType.Text);
        }
        public DataTable timsach(string tensach)
        {
            return _Search.search(tensach);
        }
        public DataSet laysachId(string masach)
        {
            string laysachID = @"exec dbo.kiemtrasach N'" + masach + "'";
            return db.ExecuteQueryDataSet(laysachID, CommandType.Text);
        }
    }
}
