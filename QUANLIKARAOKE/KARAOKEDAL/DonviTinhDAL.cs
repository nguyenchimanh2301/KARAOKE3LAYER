using ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KARAOKEDAL
{
    public class DonviTinhDAL
    {
        public karaokeDataContext db = new karaokeDataContext();

        public void themDonViTinh(DonViTinh mh)
        {
            db.DonViTinhs.InsertOnSubmit(mh);
            db.SubmitChanges();
        }
        public void suaDonViTinh(DonViTinh mh)
        {
            db.DonViTinhs.Attach(mh);
            db.SubmitChanges();

        }
        public void xoa(DonViTinh id)
        {
            /*       var dvt = db.DonViTinhs.SingleOrDefault(x => x.ID == id);*/
            db.DonViTinhs.DeleteOnSubmit(id);
            db.SubmitChanges();

        }
        public List<DonViTinh> Timkiem(string mh)
        {
            var mt = db.DonViTinhs.Where(x => x.TenDVT.Contains(mh)).ToList();
            return mt;
        }
    }
}
