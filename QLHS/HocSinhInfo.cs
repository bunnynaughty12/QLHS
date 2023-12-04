using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLHS
{
    class HocSinhInfo
    {
        string mahs;
        public string Mahs

        {
            get { return mahs; } 
            set
            {
                if (value == null || value == "")
                    throw new Exception("Mã học sinh khong được rỗng");
                mahs = value;
            }
        }
        string hoten;
        public string Hoten
        {
            get { return hoten; }
            set
            {
                if (value == null || value == "")
                    throw new Exception("Tên học sinh không được rỗng");
                hoten = value;
            }
        }

        bool gioitinh;
        public bool Gioitinh
        {
            get { return gioitinh; }
            set { gioitinh = value; }
        }

        DateTime ngaysinh;
        public DateTime Ngaysinh
        {
            get { return ngaysinh; }
            set { ngaysinh = value; }
        }

        string diachi;
        public string Diachi
        {
            get { return diachi; }
            set { diachi  = value; }    
        }

        float diemtb;
        public float Diemtb
        {
            get { return diemtb; }
            set {
                if (value < 0 || value > 10)
                    throw new Exception("Điểm tb phải >= 0 va <= 10");
                diemtb = value;
            }
        }
        private LopInfo lophoc;
        internal LopInfo Lophoc
        {
            get { return lophoc; }
            set { lophoc = value; }
        }
    }
}
