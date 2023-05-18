using ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KARAOKEDAL
{
    public class PhongDAL
    {
        public karaokeDataContext db = new karaokeDataContext();

        public void themPhong(Phong mh)
        {
            db.Phongs.InsertOnSubmit(mh);
            db.SubmitChanges();
        }
        public void suaPhong(Phong mh)
        {
            db.Phongs.Attach(mh);
            db.SubmitChanges();

        }
        public void xoa(int id)
        {
            var dvt = db.Phongs.SingleOrDefault(x => x.ID == id);
            db.Phongs.DeleteOnSubmit(dvt);
            db.SubmitChanges();

        }
        public List<Phong> Timkiem(string mh)
        {
            var mt = db.Phongs.Where(x => x.TenPhong.Contains(mh)).ToList();
            return mt;
        }
    }
}
