using QuanLyThuVien1.DB_layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

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
        public bool themphieumuon(string maphieumuon, DateTime ngaymuon, DateTime hanngaytra, string manhanvien, string masach, string madocgia, string trangthai, ref string err)
        {
            string ktphieumuon = @"exec dbo.kiemtraphieumuon N'" + maphieumuon + "'";
            string themphieumuon = @"exec dbo.themphieumuon N'" + maphieumuon + "'," + ngaymuon + "," + hanngaytra + ",N'" + manhanvien + "',N'" + masach + "',N'" + madocgia + "',N'" + trangthai + "'";
            DataTable dt = db.ExecuteQueryDataTable(ktphieumuon, CommandType.Text);
            if (dt.Rows.Count> 0)
            {
                return false;
            }
            else return db.MyExecuteNonQuery(themphieumuon, CommandType.Text, ref err);
        }
        public bool themphieumuon1(string maphieumuon, DateTime ngaymuon, DateTime hanngaytra, string manhanvien, string masach, string madocgia, int soluong ,string trangthai)
        {
            string ktphieumuon = @"exec dbo.kiemtraphieumuon N'" + maphieumuon + "'";
            DataTable dt = db.ExecuteQueryDataTable(ktphieumuon, CommandType.Text);
            if (dt.Rows.Count > 0)
            {
                
                MessageBox.Show("Da co ID nay roi", " Da Ton Tai");
                return false;
            }
            else
            {
                SqlCommand command = new SqlCommand("insert into phieumuon values(@maphieumuon, @ngaymuon, @hanngaytra, @manhanvien, @masach,@soluong,@madocgia,@trangthai)", db.GetConnection);

                command.Parameters.Add("@maphieumuon", SqlDbType.VarChar).Value = maphieumuon;
                command.Parameters.Add("@ngaymuon", SqlDbType.Date).Value = ngaymuon;
                command.Parameters.Add("@hanngaytra", SqlDbType.Date).Value = hanngaytra;
                command.Parameters.Add("@manhanvien", SqlDbType.VarChar).Value = manhanvien;
                command.Parameters.Add("@masach", SqlDbType.VarChar).Value = masach;
                command.Parameters.Add("@madocgia", SqlDbType.VarChar).Value = madocgia;
                command.Parameters.Add("@soluong", SqlDbType.Int).Value = soluong;
                command.Parameters.Add("@trangthai", SqlDbType.VarChar).Value = trangthai;



                db.openconection();
                if ((command.ExecuteNonQuery() == 1))
                {
                    db.closeconnection();
                    return true;

                }
                else
                {
                    db.closeconnection();
                    return false;
                }
            }

        }
        public bool suaphieumuon(string maphieumuon, DateTime ngaymuon, DateTime hanngaytra, string manhanvien, string masach, string madocgia, int soluong, string trangthai)
        {
          
                SqlCommand command = new SqlCommand("UPDATE phieumuon set ngaymuon= @ngaymuon,hanngaytra = @hanngaytra, manhanvien = @manhanvien, masach = @masach, madocgia = @madocgia, trangthai = @trangthai where maphieumuon=@maphieumuon", db.GetConnection);

                command.Parameters.Add("@maphieumuon", SqlDbType.VarChar).Value = maphieumuon;
                command.Parameters.Add("@ngaymuon", SqlDbType.Date).Value = ngaymuon;
                command.Parameters.Add("@hanngaytra", SqlDbType.Date).Value = hanngaytra;
                command.Parameters.Add("@manhanvien", SqlDbType.VarChar).Value = manhanvien;
                command.Parameters.Add("@masach", SqlDbType.VarChar).Value = masach;
                command.Parameters.Add("@madocgia", SqlDbType.VarChar).Value = madocgia;
                command.Parameters.Add("@soluong", SqlDbType.Int).Value = soluong;
                command.Parameters.Add("@trangthai", SqlDbType.VarChar).Value = trangthai;

                db.openconection();
                if ((command.ExecuteNonQuery() == 1))
                {
                    db.closeconnection();
                    return true;

                }
                else
                {
                    db.closeconnection();
                    return false;
                }
            
        }
        
        public DataSet thongke (string dau,string sau)
        {
            string thongke = @"exec dbo.thongke N'" + dau + "',N'" + sau + "'";
            return db.ExecuteQueryDataSet(thongke,CommandType.Text);
        }
        public bool xoa(string mapm, ref string err)
        {
            string xoa = @"exec dbo.xoaphieumuon N'" + mapm + "'";
            return db.MyExecuteNonQuery(xoa, CommandType.Text, ref err);


        }
        public DataTable timkiempm(string mapm)
        {
            string timkiempm = @"exec dbo.timkiemphieumuon N'" + mapm + "'";
            return db.ExecuteQueryDataTable(timkiempm, CommandType.Text);
        }
    }
}
