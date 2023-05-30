using ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KARAOKEDAL
{
    public class LoaiTBDAL
    {
        public karaokeDataContext db = new karaokeDataContext();

        public void themLoaiThietBi(LoaiThietBi mh)
        {
            db.LoaiThietBis.InsertOnSubmit(mh);
            db.SubmitChanges();
        }
        public void suaLoaiThietBi(LoaiThietBi mh)
        {
            db.LoaiThietBis.Attach(mh);
            db.SubmitChanges();

        }
        public void xoa(int id)
        {
            var dvt = db.LoaiThietBis.SingleOrDefault(x => x.ID == id);
            db.LoaiThietBis.DeleteOnSubmit(dvt);
            db.SubmitChanges();

        }
        public List<LoaiThietBi> Timkiem(string mh)
        {
            var mt = db.LoaiThietBis.Where(x => x.TenLoaiTB.Contains(mh)).ToList();
            return mt;
        }
    }
}
