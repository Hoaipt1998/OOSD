using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien1.Builder
{
    class NhanVienBuiderDirectory
    {
        public controllerNhanVien Construct(NhanVienBuilder builder ,string MaNhanVien, string TaiKhoan, string MatKhau, string TenNhanVien, string DiaChi, string GioiTinh)
        {
            builder.setMaNV(MaNhanVien);
            builder.SetTaiKhoan(TaiKhoan);
            builder.SetMatKhau(MatKhau);
            builder.setDiaChi(DiaChi);
            builder.SetTenNhanVien(TenNhanVien);
            builder.setGioiTinh(GioiTinh);
            controllerNhanVien nhanvien = builder.GetNhanVien();
            return nhanvien;
        }
    }
}
