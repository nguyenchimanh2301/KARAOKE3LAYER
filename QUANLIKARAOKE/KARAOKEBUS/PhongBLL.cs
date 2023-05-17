using ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KARAOKEDAL;
namespace KARAOKEBUS
{
    public class PhongBLL
    {
        PhongDAL dal = new PhongDAL();
        public void themPhong(Phong mh)
        {
            dal.themPhong(mh);
        }
        public void suaPhong(Phong mh)
        {
            dal.suaPhong(mh);

        }
        public void xoa(Phong id)
        {
            /*       var dvt = db.Phongs.SingleOrDefault(x => x.ID == id);*/
            dal.xoa(id);

        }
        public List<Phong> Timkiem(string mh)
        {
           return dal.Timkiem(mh);
        }
    }
}
