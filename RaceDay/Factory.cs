using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceDay
{
    public static class Factory
    {
        public static Punter GetPunterInfo(int id)
        {
            switch (id)
            {
                case 0:
                    return new Balbir();
                case 1:
                    return new Lucky();
                case 2:
                    return new Sameer();
                default:
                    return new Balbir();
            }
        }


        public static Contender CreateContender(string name, Bitmap picBitmap)
        {
            return new Student{ContenderName = name, ContenderPicture = picBitmap};
        }
    }
}
