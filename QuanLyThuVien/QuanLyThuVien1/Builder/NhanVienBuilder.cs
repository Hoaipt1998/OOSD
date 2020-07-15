using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien1.Builder
{
    public interface NhanVienBuilder
    {
        void setMaNV(string MaNhanVien);
        void SetTaiKhoan(string TaiKhoan);
        void SetMatKhau(string MatKhau);
        void SetTenNhanVien(string TenNhanVien);
        void setDiaChi(string DiaChi);
        void setGioiTinh(string GioiTInh);
        controllerNhanVien GetNhanVien();
       
    }
}
