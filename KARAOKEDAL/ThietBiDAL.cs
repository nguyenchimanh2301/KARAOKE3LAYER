using ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KARAOKEDAL
{
    public class ThietBiDAL
    {
        public karaokeDataContext db = new karaokeDataContext();

        public void themThietBi(ThietBi mh)
        {
            db.ThietBis.InsertOnSubmit(mh);
            db.SubmitChanges();
        }
        public void suaThietBi(ThietBi mh)
        {
            db.ThietBis.Attach(mh);
            db.SubmitChanges();

        }
        public void xoa(int id)
        {
            var dvt = db.ThietBis.SingleOrDefault(x => x.ID == id);
            db.ThietBis.DeleteOnSubmit(dvt);
            db.SubmitChanges();

        }
        public IQueryable Timkiem(string mh)
        {
            var mt = from tb in db.ThietBis.Where(x => x.TenThietBi.Contains(mh))
                     join h in db.LoaiThietBis on tb.IDLoaiTB equals h.ID
                     select new
                     {
                         tb.ID,
                         h.TenLoaiTB,
                         tb.TenThietBi,
                         tb.Mausac,
                         tb.Kichthuoc,
                         tb.DonGia

                     };
            return mt;
        }
    }
}
