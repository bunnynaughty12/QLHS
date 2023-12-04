using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLHS
{
    class BOHocSinh
    {
        DAOHocSinh hs = new DAOHocSinh();
        public DataTable LayDSHocSinh()
        {
            return hs.LayDSHocSinh();
        }

        public DataTable LayDSHocSinh(string sMalop)
        {
            return hs.LayDSHocSinh(sMalop);
        }

        public void Insert(HocSinhInfo hsInfo)
        {
            hs.insert(hsInfo);
        }
        public void Delete(string maHS)
        {
            hs.delete(maHS);
        }

        public void Update(string maHS, string tenHS, string lop, string diaChi, string sdt)
        {
            hs.update(maHS, tenHS, lop, diaChi, sdt);
        }
    }
}
