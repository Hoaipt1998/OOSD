using QuanLyThuVien1.DB_layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien1.BS_layer
{
    class BLsach
    {
        DBMain db = null;
        public BLsach()
        {
            db = new DBMain();
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
       
    }
}
