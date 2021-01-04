using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Anaproje
{
    public class Volvo:Tır
    {
        public Volvo()
        {

        }
        public Volvo(int normalYuk, int agırYuk, int manevra, int yokusTırmanma, int engebeliArazi) : base(normalYuk, agırYuk, manevra, yokusTırmanma, engebeliArazi)
        {

        }
        public override void Fiyat()
        {
            fiyati = 113680;
        }
        public override void Fiyat(int ikinci)
        {
            fiyati = 114590;
        }
        public override void benzinKapasite()
        {
            benzinKapasitesi = 1400;
        }

        public override void motorGucu()
        {
            motorGuc = 420;
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
            benzinKapasitesi = 1400;
        }

        public override void motorGucu(int m)
        {
            motorGuc = 420;
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
