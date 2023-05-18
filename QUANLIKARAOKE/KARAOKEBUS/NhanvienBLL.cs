using ENTITY;
using KARAOKEDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KARAOKEBUS
{
    public  class NhanvienBLL
    {
        NccDAL dal = new NccDAL();
        public void themNhaCungCap(NhaCungCap mh)
        {
            dal.themNhaCungCap(mh);
        }
        public void suaNhaCungCap(NhaCungCap mh)
        {
            dal.suaNhaCungCap(mh);

        }
        public void xoa(NhaCungCap id)
        {
            /*       var dvt = db.NhaCungCaps.SingleOrDefault(x => x.ID == id);*/
            dal.xoa(id);

        }
        public List<NhaCungCap> Timkiem(string mh)
        {
            return dal.Timkiem(mh);
        }
    }
}
