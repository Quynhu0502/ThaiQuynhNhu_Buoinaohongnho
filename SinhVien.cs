using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThaiQuynhNhu_Buoinaohongnho
{
    internal class SinhVien :Nguoi
    {
        string msSV;
        string nganhHoc;
        string diemTb;

        public string MsSV { get => msSV; set => msSV = value; }
        public string NganhHoc { get => nganhHoc; set => nganhHoc = value; }
        public string DiemTb { get => diemTb; set => diemTb = value; }

        public SinhVien(): base() { }
        public SinhVien(string hoTen, string ngaySinh, string gioiTinh, string msSv, string nganhHoc, string diemTb) : base(hoTen, ngaySinh, gioiTinh)
        {
            this.msSV = msSv;
            this.nganhHoc = nganhHoc;
            this.diemTb = diemTb;
        }
    }
}
