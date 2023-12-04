using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLHS
{
    class LopInfo
    {
        public LopInfo()
        {
        }

        public LopInfo(string ma, string ten)
        {
            malop = ma;
            tenlop = ten;
        }

        string malop;
        public string Malop
        {
            get { return malop; }
            set
            {
                if (value == null || value == "")
                    throw new Exception("Mã lớp không được rỗng");
                malop = value;
            }
        }

        string tenlop;
        public string Tenlop
        {
            get { return tenlop; }
            set
            {
                if (value == null || value == "")
                    throw new Exception("Tên lớp không được rỗng");
                tenlop = value;
            }
        }
    }
}

