﻿using ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KARAOKEDAL
{
    internal class ChitietHoadonNhapDAL
    {
        public karaokeDataContext db = new karaokeDataContext();

        public void themLoaiPhong(LoaiPhong mh)
        {
            db.LoaiPhongs.InsertOnSubmit(mh);
            db.SubmitChanges();
        }
        public void suaLoaiPhong(LoaiPhong mh)
        {
            db.LoaiPhongs.Attach(mh);
            db.SubmitChanges();

        }
        public void xoa(LoaiPhong id)
        {
            /*       var dvt = db.LoaiPhongs.SingleOrDefault(x => x.ID == id);*/
            db.LoaiPhongs.DeleteOnSubmit(id);
            db.SubmitChanges();

        }
        public List<LoaiPhong> Timkiem(string mh)
        {
            var mt = db.LoaiPhongs.Where(x => x.TenLoaiPhong.Contains(mh)).ToList();
            return mt;
        }
    }
}
