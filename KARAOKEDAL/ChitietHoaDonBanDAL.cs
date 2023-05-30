using ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KARAOKEDAL
{
    internal class ChitietHoaDonBanDAL
    {
        public karaokeDataContext db = new karaokeDataContext();

        public void themChiTietHoaDonBan(ChiTietHoaDonBan mh)
        {
            db.ChiTietHoaDonBans.InsertOnSubmit(mh);
            db.SubmitChanges();
        }
        public void suaChiTietHoaDonBan(ChiTietHoaDonBan mh)
        {
            db.ChiTietHoaDonBans.Attach(mh);
            db.SubmitChanges();

        }
        public void xoa(ChiTietHoaDonBan id)
        {
            /*       var dvt = db.ChiTietHoaDonBans.SingleOrDefault(x => x.ID == id);*/
            db.ChiTietHoaDonBans.DeleteOnSubmit(id);
            db.SubmitChanges();

        }
        public List<ChiTietHoaDonBan> Timkiem(int mh)
        {
            var mt = db.ChiTietHoaDonBans.Where(x => x.IDHoaDon == mh).ToList();
            return mt;
        }
    }
}
