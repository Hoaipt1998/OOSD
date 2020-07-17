using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien1.BS_layer
{
    interface ISearchAlgorithm
    {
        DataTable search(string str);

    }
}
