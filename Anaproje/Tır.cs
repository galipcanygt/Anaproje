using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Anaproje
{
    public class Tır:Arac,Ozellik
    {
        public static int stok=20;
        public static bool satinAl(int p)
        {
            if (stok > 0)
            {
                stok = stok - p;
                if (stok < 0)
                {
                    stok = stok + p;
                    MessageBox.Show
                        ("Galerimizde sipariş etmek istediğiniz kadar tır bulunmamaktadır!" 
                        + Environment.NewLine + "Ancak şu kadar tır satın alabilirsiniz: " 
                        + (stok));
                    return false;
                }
                else
                {
                    MessageBox.Show("Galerimizde kalan tır stoğumuz: " + stok);
                    return true;
                }
            }
            else
            {
                MessageBox.Show("Galerimizde Stoğumuz kalmamıştır.");
                return false;
            }
        }

        public Tır() { }
        public Tır(int normalYuk,int agırYuk,int manevra, int yokusTırmanma, int engebeliArazi)
        {
            this.normalYuk = normalYuk;
            this.agırYuk = agırYuk;
            this.manevra = manevra;
            this.yokusTırmanma = yokusTırmanma;
            this.engebeliArazi = engebeliArazi;
        }

        public override void Fiyat()
        {
           fiyati = 100000;
        }

        public override void Fiyat(int ikinci)
        {
            fiyati = 100000;
        }
        public virtual void benzinKapasite() {}
        public virtual void motorGucu() {}
        public virtual void motorTorku() {}
        public virtual void vitesAdedi() {}
        public virtual void motorGucu(int e) {}
        public virtual void motorTorku(int m) {}
        public virtual void benzinKapasite(int r) {}
        public virtual void vitesAdedi(int e) { }
    
    }
}
