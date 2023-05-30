using ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KARAOKEDAL
{
    internal class NhanVienDAL
    {
        public karaokeDataContext db = new karaokeDataContext();

        public void themNhanVien(NhanVien mh)
        {
            db.NhanViens.InsertOnSubmit(mh);
            db.SubmitChanges();
        }
        public void suaNhanVien(NhanVien mh)
        {
            db.NhanViens.Attach(mh);
            db.SubmitChanges();

        }
        public void xoa(NhanVien id)
        {
            /*       var dvt = db.NhanViens.SingleOrDefault(x => x.ID == id);*/
            db.NhanViens.DeleteOnSubmit(id);
            db.SubmitChanges();

        }
        public List<NhanVien> Timkiem(string mh)
        {
            var mt = db.NhanViens.Where(x => x.HoVaTen.Contains(mh)).ToList();
            return mt;
        }
    }
}
