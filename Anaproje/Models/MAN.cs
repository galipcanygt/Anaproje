using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Anaproje
{
    public class MAN:Tır
    {
        public MAN()
        {

        }
        public MAN(int normalYuk, int agırYuk, int manevra, int yokusTırmanma, int engebeliArazi) : base(normalYuk, agırYuk, manevra, yokusTırmanma, engebeliArazi)
        {

        }
        public override void Fiyat()
        {
            fiyati = 99965;
        }
        public override void Fiyat(int ikinci)
        {
            fiyati = 109175;
        }
        public override void benzinKapasite()
        {
            benzinKapasitesi = 1250;
        }

        public override void motorGucu()
        {
            motorGuc = 320;
        }

        public override void motorTorku()
        {
            motorTork = 1600;
        }

        public override void vitesAdedi()
        {
            vitesSayi = 12;
        }
        public override void benzinKapasite(int e)
        {
            benzinKapasitesi = 1160;
        }

        public override void motorGucu(int m)
        {
            motorGuc = 360;
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
