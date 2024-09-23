using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThaiQuynhNhu_Buoinaohongnho
{
    internal class NhanVien : Nguoi
    {
        string msNv;
        string chucVu;
        string luong;

        public string MsNv { get => msNv; set => msNv = value; }
        public string ChucVu { get => chucVu; set => chucVu = value; }
        public string Luong { get => luong; set => luong = value; }

        public NhanVien() :base () { }   
        public NhanVien (string hoTen,string ngaySinh,string gioiTinh ,string msNv, string chucVu, string luong) : base(hoTen, ngaySinh, gioiTinh)
        {
            this.msNv = msNv;
            this.chucVu = chucVu;
            this.luong = luong;
        }
    }

}
