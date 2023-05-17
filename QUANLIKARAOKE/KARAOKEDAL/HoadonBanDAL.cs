using ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KARAOKEDAL
{
    internal class HoadonBanDAL
    {
        public karaokeDataContext db = new karaokeDataContext();

        public void themHoaDonBanHang(HoaDonBanHang mh)
        {
            db.HoaDonBanHangs.InsertOnSubmit(mh);
            db.SubmitChanges();
        }
        public void suaHoaDonBanHang(HoaDonBanHang mh)
        {
            db.HoaDonBanHangs.Attach(mh);
            db.SubmitChanges();

        }
        public void xoa(HoaDonBanHang id)
        {
            /*       var dvt = db.HoaDonBanHangs.SingleOrDefault(x => x.ID == id);*/
            db.HoaDonBanHangs.DeleteOnSubmit(id);
            db.SubmitChanges();

        }
        public List<HoaDonBanHang> Timkiem(int mh)
        {
            var mt = db.HoaDonBanHangs.Where(x => x.IDPhong == mh).ToList();
            return mt;
        }
    }
}
