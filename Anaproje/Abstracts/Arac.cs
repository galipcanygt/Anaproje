using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Anaproje
{
    public abstract class Arac
    {
        public static int odeFiyat=0;
        public int fiyati=0;
        public int normalYuk;
        public int agırYuk;
        public int manevra;
        public int yokusTırmanma;
        public int engebeliArazi;
        public int motorGuc;
        public int motorTork;
        public int benzinKapasitesi;
        public int vitesSayi;
        abstract public void Fiyat();
        abstract public void Fiyat(int kalem);

    }
}
