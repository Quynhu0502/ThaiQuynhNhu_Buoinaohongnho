namespace ThaiQuynhNhu_Buoinaohongnho
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<SinhVien> li_sv = new List<SinhVien>();
        List<NhanVien> li_nv = new List<NhanVien>();


        private void btn_nhanvien_Click(object sender, EventArgs e)
        {
            NhanVien li = new NhanVien(txt_hoten.Text, txt_ngaysinh.Text, txt_gioitinh.Text, txt_msnv.Text, txt_chucvu.Text, txt_luong.Text);

            li_nv.Add(li);
            dataGridViewNV.DataSource = null;
            dataGridViewNV.DataSource = li_nv;

        }

        private void btn_sinhvien_Click(object sender, EventArgs e)
        {
            SinhVien li = new SinhVien(txt_hoten2.Text, txt_ngaysinh2.Text, txt_gioitinh2.Text, txt_mssv.Text, txt_nganhhoc.Text, txt_diemTB.Text);

            li_sv.Add(li);
            dataGridViewSV.DataSource = null;
            dataGridViewSV.DataSource = li_sv;
        }

        private void btn_suaNV_Click(object sender, EventArgs e)
        {
            foreach (NhanVien i in li_nv)
            {
                if (i.MsNv == txt_msnv.Text)
                {
                    i.HoTen = txt_hoten.Text;


                }
            }
            dataGridViewNV.DataSource = null;
            dataGridViewNV.DataSource = li_nv;

        }

        private void btn_xoaNV_Click(object sender, EventArgs e)
        {

            foreach (NhanVien i in li_nv)
            {
                if (i.MsNv == txt_msnv.Text)
                {
                   li_nv.Remove(i);
                break;


                }
            }
            dataGridViewNV.DataSource = null;
            dataGridViewNV.DataSource = li_nv;

        }
    }
    }
