using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTITY;
namespace KARAOKEDAL
{
   public class MatHangDAL
    {
        public karaokeDataContext db = new karaokeDataContext();

        public void themMathang(MatHang mh)
        {
            db.MatHangs.InsertOnSubmit(mh);
            db.SubmitChanges();
        }
        public void suaMathang(MatHang mh)
        {
            db.MatHangs.Attach(mh);
            db.SubmitChanges();

        }
        public void xoa(int id)
        {
            var dvt = db.MatHangs.SingleOrDefault(x => x.ID == id);
            db.MatHangs.DeleteOnSubmit(dvt);
            db.SubmitChanges();

        }
        public IQueryable Timkiem(string mh)
        {
             var mt = from h in db.MatHangs.Where(x => x.TenMatHang.Contains(mh))
                     join d in db.DonViTinhs
                     on h.DVT equals d.ID
                     select new
                     {
                         h.ID,
                         h.TenMatHang,
                         d.TenDVT,
                         h.DonGiaBan
                     };
            return mt;
        }
    }
}
