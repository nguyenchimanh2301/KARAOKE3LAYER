using ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KARAOKEDAL;

namespace KARAOKEBUS
{
    public class LoaiPhongBLLcs
    {
        LoaiPhongDAL dal = new LoaiPhongDAL();
        public void themLoaiPhong(LoaiPhong mh)
        {
           dal.themLoaiPhong(mh);
        }
        public void suaLoaiPhong(LoaiPhong mh)
        {
            dal.suaLoaiPhong(mh);
        }
        public void xoa(int id)
        {
            dal.xoa(id);
            /*       var dvt = db.LoaiPhongs.SingleOrDefault(x => x.ID == id);*/
        }
        public List<LoaiPhong> Timkiem(string mh)
        {
            return dal.Timkiem(mh);
        }
    }
}
