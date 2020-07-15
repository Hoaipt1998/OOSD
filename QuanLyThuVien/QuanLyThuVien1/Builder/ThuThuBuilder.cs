using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien1.Builder
{
    class ThuThuBuilder:NhanVienBuilder
    {
        private controllerNhanVien nhanVien;

        public ThuThuBuilder()
        {
            nhanVien = new controllerNhanVien();
            nhanVien.Loai = "2";
        }

        public void setDiaChi(string DiaChi)
        {

            nhanVien.DiaChi = DiaChi;
        }

        public void setGioiTinh(string GioiTInh)
        {
            nhanVien.GioiTinh = GioiTInh;
        }

        public void setMaNV(string MaNhanVien)
        {
            nhanVien.MaNhanVien = MaNhanVien;
        }

        public void SetMatKhau(string MatKhau)
        {
            nhanVien.MatKhau = MatKhau;
        }

        public void SetTaiKhoan(string TaiKhoan)
        {
            nhanVien.TaiKhoan = TaiKhoan;
        }

        public void SetTenNhanVien(string TenNhanVien)
        {
            nhanVien.TenNhanVien = TenNhanVien;
        }
        public controllerNhanVien GetNhanVien()
        {
            return this.nhanVien;
        }
    }
}

