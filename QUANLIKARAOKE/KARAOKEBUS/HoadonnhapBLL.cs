using ENTITY;
using KARAOKEDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KARAOKEBUS
{
    public class HoadonnhapBLL
    {
        HoadonNhapDAL dal = new HoadonNhapDAL();
        public void themHoaDonNhap(HoaDonNhap mh)
        {
            dal.themHoaDonNhap(mh);
        }
        public void suaHoaDonNhap(HoaDonNhap mh)
        {
            dal.SuaHoaDonNhap(mh);

        }
        public void xoa(HoaDonNhap id)
        {
            /*       var dvt = db.HoaDonNhaps.SingleOrDefault(x => x.ID == id);*/
            dal.xoa(id);

        }
        public List<HoaDonNhap> Timkiem(string mh)
        {
            return dal.Timkiem(mh);
        }
    }
}
