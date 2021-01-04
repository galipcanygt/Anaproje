using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Anaproje
{
    public class Mercedes:Tır
    {
        public Mercedes()
        {

        }
        public Mercedes(int normalYuk, int agırYuk, int manevra, int yokusTırmanma, int engebeliArazi) : base(normalYuk, agırYuk, manevra, yokusTırmanma, engebeliArazi)
        {

        }
        public override void Fiyat()
        {
            fiyati = 116005;
        }
        public override void Fiyat(int ikinci)
        {
            fiyati = 118775;
        }
        public override void benzinKapasite()
        {
            benzinKapasitesi = 600;
        }

        public override void motorGucu()
        {
            motorGuc = 320;
        }

        public override void motorTorku()
        {
            motorTork = 1650;
        }

        public override void vitesAdedi()
        {
            vitesSayi = 12;
        }
        public override void benzinKapasite(int e)
        {
            benzinKapasitesi = 1140;
        }

        public override void motorGucu(int m)
        {
            motorGuc = 421;
        }

        public override void motorTorku(int i)
        {
            motorTork = 2100;
        }

        public override void vitesAdedi(int r)
        {
            vitesSayi = 12;
        }
    }
}
