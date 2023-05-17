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
        public void xoa(ThietBi id)
        {
            /*       var dvt = db.ThietBis.SingleOrDefault(x => x.ID == id);*/
            db.ThietBis.DeleteOnSubmit(id);
            db.SubmitChanges();

        }
        public List<ThietBi> Timkiem(string mh)
        {
            var mt = db.ThietBis.Where(x => x.TenThietBi.Contains(mh)).ToList();
            return mt;
        }
    }
}
