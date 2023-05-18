using ENTITY;
using KARAOKEDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KARAOKEBUS
{
    public class ThietBiBLL
    {
        ThietBiDAL dal = new ThietBiDAL();
        public void themThietBi(ThietBi mh)
        {
            dal.themThietBi(mh);
        }
        public void suaThietBi(ThietBi mh)
        {
            dal.suaThietBi(mh);
        }
        public void xoa(int mh)
        {
            dal.xoa(mh);
        }
        public IQueryable Timkiem(string mh)
        {
            return dal.Timkiem(mh);
        }
    }
}
