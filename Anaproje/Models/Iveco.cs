using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anaproje
{
    public class Iveco:Tır
    {
        public Iveco()
        {

        }
        public Iveco(int normalYuk, int agırYuk, int manevra, int yokusTırmanma, int engebeliArazi) : base(normalYuk, agırYuk, manevra, yokusTırmanma, engebeliArazi)
        {

        }
        public override void Fiyat()
        {
            fiyati = 149260;
        }
        public override void Fiyat(int ikinci)
        {
            fiyati = 157945;
        }
        public override void benzinKapasite()
        {
            benzinKapasitesi = 400;
        }

        public override void motorGucu()
        {
            motorGuc = 450;
        }

        public override void motorTorku()
        {
            motorTork = 2100;
        }

        public override void vitesAdedi()
        {
            vitesSayi = 12;
        }
        public override void benzinKapasite(int e)
        {
            benzinKapasitesi = 1200;
        }

        public override void motorGucu(int m)
        {
            motorGuc = 310;
        }

        public override void motorTorku(int i)
        {
            motorTork = 1300;
        }

        public override void vitesAdedi(int r)
        {
            vitesSayi = 12;
        }
    }
}
