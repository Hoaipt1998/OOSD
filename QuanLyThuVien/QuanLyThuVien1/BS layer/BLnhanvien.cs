using QuanLyThuVien1.DB_layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyThuVien1.Builder;

namespace QuanLyThuVien1.BS_layer
{
    class BLnhanvien
    {
        DBMain db = null;
        public BLnhanvien()
        {
            db = new DBMain();
        }
        public DataSet Laynhanvien()
        {
            string laynhanvien = @"exec dbo.thongtinnv";
            return db.ExecuteQueryDataSet(laynhanvien, CommandType.Text);
        }
        public bool xoanhanvien(string manv, ref string err)
        {
            string xoanv = @"exec dbo.xoanv N'" + manv + "'";
            return db.MyExecuteNonQuery(xoanv, CommandType.Text, ref err);
        }
        //public bool themnvn(string manv, string tk, string mk, string loai,string tennv,string diachi,string sex, ref string err)
        //{
        //    string ktnv = @"exec dbo.kiemtranv N'" + manv + "'";
        //    string themnv = @"exec dbo.themnv N'" + manv + "',N'" + tk + "',N'" +mk + "',N'" + loai + "',N'" + tennv + "',N'" + diachi + "',N'" + sex + "'";
        //    DataTable dt = db.ExecuteQueryDataTable(ktnv, CommandType.Text);
        //    if (dt.Rows.Count == 0)
        //    {
        //        return db.MyExecuteNonQuery(themnv, CommandType.Text, ref err);
        //    }
        //    else return false;
        //}
        public bool themnvn(controllerNhanVien ctnhanvien, ref string err)
        {
            string ktnv = @"exec dbo.kiemtranv N'" + ctnhanvien.MaNhanVien + "'";
            string themnv = @"exec dbo.themnv N'" + ctnhanvien.MaNhanVien + "',N'" + ctnhanvien.TaiKhoan + "',N'" + ctnhanvien.MatKhau + "',N'" + ctnhanvien.Loai + "',N'" + ctnhanvien.TenNhanVien + "',N'" + ctnhanvien.DiaChi + "',N'" + ctnhanvien.GioiTinh + "'";
            DataTable dt = db.ExecuteQueryDataTable(ktnv, CommandType.Text);
            if (dt.Rows.Count >0 )
            {
                MessageBox.Show("Da co ID nay roi", " Da Ton Tai");
                return false;
               
            }
            else return db.MyExecuteNonQuery(themnv, CommandType.Text, ref err);
        }
        public bool suanv(string manv,string loai, string tennv, string diachi,string sex, ref string err)
        {
            string suanv = @"exec dbo.suanv N'" + manv + "',N'" + loai + "',N'" + tennv + "',N'" + diachi + "',N'"+ sex + "'";
            return db.MyExecuteNonQuery(suanv, CommandType.Text, ref err);
        }
        public int Dangnhap(string tk, string mk,ref string m)
        {
            string kttk = @"exec dbo.dangnhap N'" + tk + "',N'" + mk + "'";
            try
            {
                DataTable dt = db.ExecuteQueryDataTable(kttk, CommandType.Text);
                if (dt.Rows.Count >0)
                {
                   
                    string h = dt.Rows[0]["loai"].ToString();
                    m = dt.Rows[0]["manhanvien"].ToString();
                    if (h == "1")
                    { return 1; }
                    else if (h == "2")
                    { return 2; }
                    else
                    { return 3; }
                }
                else
                {
                    MessageBox.Show("Đăng nhập bị lỗi rồi, mời đăng nhập lại !!!");
                    return 0;
                }
            }
            catch
            {
                MessageBox.Show("Lỗi đăng nhập rồi, mời bạn nhập lại");
                return 0;
            }
        }
        public DataSet timnhanvien(string ten)
        {
            string tim = @"exec dbo.thongtinvid N'" + ten + "'";
            return db.ExecuteQueryDataSet(tim, CommandType.Text);
        }
        public bool doimatkhau(string mk,string m,ref string err)
        {
            string doimatkhau = @"exec dbo.doimatkhau N'" + m + "',N'" + mk + "'";
            return db.MyExecuteNonQuery(doimatkhau, CommandType.Text,ref err);
        }
        public DataSet laynhanvienId(string manhanvien)
        {
            string laynhanvienId = @"exec dbo.kiemtranv  N'" + manhanvien + "'";
            return db.ExecuteQueryDataSet(laynhanvienId, CommandType.Text);
        }
    }
}
