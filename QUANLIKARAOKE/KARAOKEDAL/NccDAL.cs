using ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KARAOKEDAL
{
    public class NccDAL
    {
        public karaokeDataContext db = new karaokeDataContext();

        public void themNhaCungCap(NhaCungCap mh)
        {
            db.NhaCungCaps.InsertOnSubmit(mh);
            db.SubmitChanges();
        }
        public void suaNhaCungCap(NhaCungCap mh)
        {
            db.NhaCungCaps.Attach(mh);
            db.SubmitChanges();

        }
        public void xoa(NhaCungCap id)
        {
            /*       var dvt = db.NhaCungCaps.SingleOrDefault(x => x.ID == id);*/
            db.NhaCungCaps.DeleteOnSubmit(id);
            db.SubmitChanges();

        }
        public List<NhaCungCap> Timkiem(string mh)
        {
            var mt = db.NhaCungCaps.Where(x => x.TenNCC.Contains(mh)).ToList();
            return mt;
        }
    }
}
