using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public  class Phongtk
    {
        public int gio { get; set; }
        public int phut { get; set; }
        public Phongtk()
        {

        }
        public Phongtk(double thgian)
        {
            var tg = laygio(thgian);
            gio = (int)tg;
            phut = (int)((tg - Math.Truncate(tg)) * 60);
        }
        public double laygio(double tg)
        {

            return Math.Round(tg, 1);
        }
        public override string ToString()
        {
            return String.Format("{0}:{1}", gio, phut);
        }
        public int thanhtien(double tg, int dgia)
        {
            return (int)laygio(tg) * dgia;
        }
        public double layngay(double tg)
        {

            return Math.Round(tg);
        }
        public int thanhtien2(double tg, int dgia)
        {
            return (int)layngay(tg) - Convert.ToInt32(dgia);
        }
    }
}
