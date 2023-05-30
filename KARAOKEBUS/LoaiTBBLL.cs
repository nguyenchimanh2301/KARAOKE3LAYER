using ENTITY;
using KARAOKEDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KARAOKEBUS
{
    public class LoaiTBBLL
    {
        LoaiTBDAL dal = new LoaiTBDAL();
        public void themLoaiThietBi(LoaiThietBi mh)
        {
            dal.themLoaiThietBi(mh);
        }
        public void suaLoaiThietBi(LoaiThietBi mh)
        {
            dal.suaLoaiThietBi(mh);
        }
        public void xoa(int mh)
        {
            dal.xoa(mh);
        }
        public List<LoaiThietBi> Timkiem(string mh)
        {
            return dal.Timkiem(mh);
        }
    }
}
