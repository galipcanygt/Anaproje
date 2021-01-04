using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anaproje
{
    public interface Ozellik
    {
        void motorGucu();
        void motorTorku();
        void benzinKapasite();
        void vitesAdedi();
        void motorGucu(int e);
        void motorTorku(int m);
        void benzinKapasite(int r);
        void vitesAdedi(int e);

    }
}
