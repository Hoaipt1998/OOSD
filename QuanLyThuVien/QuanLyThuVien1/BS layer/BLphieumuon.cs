using QuanLyThuVien1.DB_layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien1.BS_layer
{
    class BLphieumuon
    {
        DBMain db = null;
        public BLphieumuon()
        {
            db = new DBMain();
        }
        public DataSet Layphieumuon()
        {
            string layphieumuon = @"exec dbo.thongtinphieumuon";
            return db.ExecuteQueryDataSet(layphieumuon, CommandType.Text);
        }
        public bool themphieumuon(string maphieumuon, string ngaymuon, string hanngaytra, string manhanvien, string masach, string madocgia, string trangthai, ref string err)
        {
            string ktphieumuon = @"exec dbo.kiemtraphieumuon N'" + maphieumuon + "'";
            string themphieumuon = @"exec dbo.themphieumuon N'" + maphieumuon + "',N'" + ngaymuon + "',N'" + hanngaytra + "',N'" + manhanvien + "',N'" + masach + "',N'" + madocgia + "',N'" + trangthai + "'";
            DataTable dt = db.ExecuteQueryDataTable(ktphieumuon, CommandType.Text);
            if (dt.Rows.Count> 0)
            {
                return false;
            }
            else return db.MyExecuteNonQuery(themphieumuon, CommandType.Text, ref err);
        }
        public bool suaphieumuon(string maphieumuon, string ngaymuon, string hanngaytra, string manhanvien, string masach, string madocgia, string trangthai, ref string err)
        {
            string suaphieumuon = @"exec dbo.suaphieumuon N'" + maphieumuon + "',N'" + ngaymuon + "',N'" + hanngaytra + "',N'" + manhanvien + "',N'" + masach + "',N'" + madocgia + "',N'" + trangthai + "'";
            return db.MyExecuteNonQuery(suaphieumuon, CommandType.Text, ref err);
        }
        public DataSet thongke (string dau,string sau)
        {
            string thongke = @"exec dbo.thongke N'" + dau + "',N'" + sau + "'";
            return db.ExecuteQueryDataSet(thongke,CommandType.Text);
        }
    }
}
