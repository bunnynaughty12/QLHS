using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLHS
{
    class BOLop
    {
        DAOLop lop = new DAOLop();

        public DataTable LayDSLop()
        {
            return lop.LayDSLop();
        }

        public void Insert(LopInfo lopInfo)
        {
            lop.Insert(lopInfo);
        }

        public void Delete(string maLop)
        {
            lop.Delete(maLop);
        }

        public void Update(string maLop, string tenLop)
        {
            lop.Update(maLop, tenLop);
        }
    }

}
