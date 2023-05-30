using ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KARAOKEDAL
{
    public class HoadonNhapDAL
    {
        public karaokeDataContext db = new karaokeDataContext();

        public void themHoaDonNhap(HoaDonNhap mh)
        {
            db.HoaDonNhaps.InsertOnSubmit(mh);
            db.SubmitChanges();
        }
        public void SuaHoaDonNhap(HoaDonNhap mh)
        {
            db.HoaDonNhaps.Attach(mh);
            db.SubmitChanges();

        }
        public void xoa(HoaDonNhap id)
        {
            /*       var dvt = db.HoaDonNhaps.SingleOrDefault(x => x.ID == id);*/
            db.HoaDonNhaps.DeleteOnSubmit(id);
            db.SubmitChanges();

        }
        public List<HoaDonNhap> Timkiem(string mh)
        {
            var mt = db.HoaDonNhaps.Where(x => x.NhanVienNhap.Contains(mh)).ToList();
            return mt;
        }
    }
}
