using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Anaproje
{
    public class DAF:Tır
    {
        public DAF() { }
        public DAF(int normalYuk, int agırYuk, int manevra, int yokusTırmanma, int engebeliArazi)
            :base(normalYuk,agırYuk,manevra,yokusTırmanma,engebeliArazi) {  }
        public override void Fiyat()
        {   fiyati = 117270;    }
        public override void Fiyat(int ikinci)
        {   fiyati = 127690;    }
        public override void benzinKapasite()
        {   benzinKapasitesi = 1000;    }

        public override void motorGucu()
        {   motorGuc = 360; }

        public override void motorTorku()
        {   motorTork = 1775;   }

        public override void vitesAdedi()
        {   vitesSayi = 12; } 
        public override void benzinKapasite(int e)
        {   benzinKapasitesi = 1400;    }

        public override void motorGucu(int m)
        {   motorGuc = 370; }

        public override void motorTorku(int i)
        {   motorTork = 1850;   }

        public override void vitesAdedi(int r)
        {   vitesSayi = 12;     }
    }
}