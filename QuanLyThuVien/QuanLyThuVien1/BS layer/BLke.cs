using QuanLyThuVien1.DB_layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien1.BS_layer
{
    class BLke
    {
        DBMain db=null;
        public BLke()
        {
            db = new DBMain();
        }
        public DataSet Layke()
        {
            string layke = @"exec dbo.thongtinke";
            return db.ExecuteQueryDataSet(layke, CommandType.Text);
        }
        public bool xoake(string make, ref string err)
        {
            string xoake = @"exec dbo.xoake N'" + make + "'";
            return db.MyExecuteNonQuery(xoake, CommandType.Text, ref err);
        }
        public bool themke(string make, string tenke, ref string err)
        {
            string kiemtrake = @"exec dbo.kiemtrake N'" + make + "'";
            string themke = @"exec dbo.themke N'" + make + "',N'" + tenke +"'";

            DataTable dt = db.ExecuteQueryDataTable(kiemtrake, CommandType.Text);
            if (dt.Rows.Count > 0)
            {
                return false;
            }
            else return db.MyExecuteNonQuery(themke, CommandType.Text, ref err);
        }
        public bool suake(string make, string tenke,ref string err)
        {
            string suake = @"exec dbo.suake N'" + make + "',N'" + tenke+ "'";
            return db.MyExecuteNonQuery(suake, CommandType.Text, ref err);
        }
        public DataSet laykesach(string make)
        {
            string laykeID = @"exec dbo.kiemtrake";
            return db.ExecuteQueryDataSet(laykeID, CommandType.Text);
        }
    }
}
