using ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KARAOKEDAL
{
    internal class LoaiTBDAL
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
        public void xoa(LoaiThietBi id)
        {
            /*       var dvt = db.LoaiThietBis.SingleOrDefault(x => x.ID == id);*/
            db.LoaiThietBis.DeleteOnSubmit(id);
            db.SubmitChanges();

        }
        public List<LoaiThietBi> Timkiem(string mh)
        {
            var mt = db.LoaiThietBis.Where(x => x.TenLoaiTB.Contains(mh)).ToList();
            return mt;
        }
    }
}
