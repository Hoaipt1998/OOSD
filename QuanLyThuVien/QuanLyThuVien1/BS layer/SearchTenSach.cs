using QuanLyThuVien1.DB_layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien1.BS_layer
{
    class SearchTenSach: ISearchAlgorithm
    {
        public DataTable search(string name)
        {
            string str = " Select * from sach where tensach LIKE '"+ name+"%'";
            DBMain dB = new DBMain();
            DataTable table = dB.ExecuteQueryDataTable(str, CommandType.Text);
            return table;
        }
    }
}
