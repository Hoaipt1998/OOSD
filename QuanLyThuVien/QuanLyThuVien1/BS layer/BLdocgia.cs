using QuanLyThuVien1.DB_layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVien1.BS_layer
{
    class BLdocgia
    {
        DBMain db = null;
        public BLdocgia()
        {
            db = new DBMain();
        }
        public DataSet Laydocgia()
        {
            string laydocgia = @"exec dbo.thongtinfulldocgia";
            return db.ExecuteQueryDataSet(laydocgia, CommandType.Text);
        }
        public bool xoadocgia(string madocgia,ref string err)
        {
            string xoadocgia = @"exec dbo.xoadocgia N'" + madocgia + "'";
            return db.MyExecuteNonQuery(xoadocgia, CommandType.Text,ref err);
        }
        public bool themdocgia(string madocgia,string tendocgia,string gioitinh,string diachi ,ref string err)
        {
            string ktdocgia = @"exec dbo.kiemtradocgia N'"+madocgia+"'";
            string themdocgia = @"exec dbo.themdocgia N'" + madocgia + "',N'" + tendocgia + "',N'" + gioitinh + "',N'" + diachi + "'";
            DataTable dt = db.ExecuteQueryDataTable(ktdocgia, CommandType.Text);
            if (dt.Rows.Count>0)
            {
                MessageBox.Show("Da co ID nay roi", " Da Ton Tai");
                return false;
            }
            else return db.MyExecuteNonQuery(themdocgia, CommandType.Text, ref err);
        }
        public bool suadocgia(string madocgia, string tendocgia, string gioitinh, string diachi, ref string err)
        {
            string suadocgia=@"exec dbo.suadocgia N'"+ madocgia + "',N'" + tendocgia + "',N'" + gioitinh + "',N'" + diachi + "'";
            return db.MyExecuteNonQuery(suadocgia, CommandType.Text, ref err);
        }
        public DataTable timkiemdg(string tendg)
        {
            string timkiem = @"exec dbo.timkiemdocgia N'" + tendg + "'";
            return db.ExecuteQueryDataTable(timkiem, CommandType.Text);
        }
        public DataSet laydocgiaId(string madocgia)
        {
            string laydocgiaId = @"exec dbo.kiemtradocgia  N'" + madocgia + "'";
            return db.ExecuteQueryDataSet(laydocgiaId, CommandType.Text);
        }
    }
}
