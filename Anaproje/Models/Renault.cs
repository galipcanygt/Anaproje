using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Anaproje
{
    public class Renault:Tır
    {
        public Renault()
        {

        }
        public Renault(int normalYuk, int agırYuk, int manevra, int yokusTırmanma, int engebeliArazi) : base(normalYuk, agırYuk, manevra, yokusTırmanma, engebeliArazi)
        {

        }
        public override void Fiyat()
        {
            fiyati = 125785;
        }
        public override void Fiyat(int ikinci)
        {
            fiyati = 115213;
        }
        public override void benzinKapasite()
        {
            benzinKapasitesi = 1200;
        }

        public override void motorGucu()
        {
            motorGuc = 440;
        }

        public override void motorTorku()
        {
            motorTork = 2200;
        }

        public override void vitesAdedi()
        {
            vitesSayi = 12;
        }
        public override void benzinKapasite(int e)
        {
            benzinKapasitesi = 1045;
        }

        public override void motorGucu(int m)
        {
            motorGuc = 380;
        }

        public override void motorTorku(int i)
        {
            motorTork = 1800;
        }

        public override void vitesAdedi(int r)
        {
            vitesSayi = 12;
        }
    }
}
