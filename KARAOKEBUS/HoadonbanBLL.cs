using ENTITY;
using KARAOKEDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KARAOKEBUS
{
    public class HoadonbanBLL
    {
        HoadonBanDAL dal = new HoadonBanDAL();
        public void themHoaDonBanHang(HoaDonBanHang mh)
        {
            dal.themHoaDonBanHang(mh);
        }
        public void suaHoaDonBanHang(HoaDonBanHang mh)
        {
            dal.suaHoaDonBanHang(mh);

        }
        public void xoa(HoaDonBanHang id)
        {
            /*       var dvt = db.HoaDonBanHangs.SingleOrDefault(x => x.ID == id);*/
            dal.xoa(id);

        }
        public List<HoaDonBanHang> Timkiem(int mh)
        {
            return dal.Timkiem(mh);
        }
    }
}
