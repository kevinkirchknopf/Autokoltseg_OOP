using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auto_koltsegek
{
    internal class Dizel:Auto
    {
        private readonly int Lokter_fog;
        private readonly int Heng_szam;


        public Dizel(int Lokter_fog, int Heng_szam)
        {
            this.Lokter_fog = Lokter_fog;
            this.Heng_szam = Heng_szam;
        }

        public override int Efogyaszt()
        {
            return Lokter_fog;
        }

        public override int Karbtart_kalk()
        {
            return 250 * Heng_szam * 7;
        }

        public override int KFB_kalk()
        {
            return 1700 + Heng_szam / 10;
        }
    }
}
