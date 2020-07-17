using QuanLyThuVien1.DB_layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien1.BS_layer
{
    class SearchLoaiSach: ISearchAlgorithm
    {
        public DataTable search(string name)
        {
            string str = "select a.masach, a.tensach, ls.maloaisach, a.soluong, a.make from sach as a, loaisach as ls where ls.tenloaisach = N'"+name+ "' and  ls.maloaisach = a.maloaisach";
            DBMain dB = new DBMain();
            DataTable table = dB.ExecuteQuery(str);
            return table;
        }
    }
}
