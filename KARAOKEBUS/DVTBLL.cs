using ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KARAOKEDAL;

namespace KARAOKEBUS
{
    public class DVTBLL
    {
        DonviTinhDAL dal = new DonviTinhDAL();
        public void themDonViTinh(DonViTinh mh)
        {
            dal.themDonViTinh(mh);
        }
        public void suaDonViTinh(DonViTinh mh)
        {
            dal.suaDonViTinh(mh);
        }
        public void xoa(int id)
        {
            dal.xoa(id);
        }
        public List<DonViTinh> Timkiem(string mh)
        {
            return dal.Timkiem(mh); 
        }
    }
}
