using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auto_koltsegek
{
    internal class benzines : Auto
    {
        readonly private int Lokter_fog;
        readonly private int heng_szam;
        readonly private int max_ford;
        

        


        public benzines(int Lokter_fog, int heng_szam, int max_ford, string rendszam)
        {
          this.Lokter_fog = Lokter_fog;
          this.heng_szam = heng_szam;
          this.max_ford = max_ford;
          this.rendszam = rendszam;
        }

        public override int Efogyaszt()
        {
            return max_ford + heng_szam * 10 + Lokter_fog;
        }

        public override int Karbtart_kalk()
        {
            return max_ford + heng_szam * 10;
        }

        public override int KFB_kalk()
        {
            return 1500 + Lokter_fog / 2 + heng_szam / 10;
        }


    }
}
