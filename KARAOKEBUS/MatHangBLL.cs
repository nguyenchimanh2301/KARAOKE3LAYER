using KARAOKEDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTITY;
namespace KARAOKEBUS
{
    public class MatHangBLL
    {
        MatHangDAL dal = new MatHangDAL();
        public void themMathang(MatHang mh)
        {
            dal.themMathang(mh);
        }
        public void suaMathang(MatHang mh)
        {
            dal.suaMathang(mh);
        }
        public void xoa(int mh)
        {
            dal.xoa(mh);
        }
        public IQueryable Timkiem(string mh)
        {
            return dal.Timkiem(mh);
        }
    }
}
