using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auto_koltsegek
{
    internal class Elektromos : Auto
    {

        readonly private int akku_kapac;
        readonly private int teljesitmeny;

        public Elektromos(int akku_kapac, int teljesitmeny)
        {
            this.akku_kapac = akku_kapac;
            this.teljesitmeny = teljesitmeny;
        }

        public override int Efogyaszt()
        {
            return teljesitmeny * 2;
        }

        public override int Karbtart_kalk()
        {
            return 500;
        }

        public override int KFB_kalk()
        {
            return 1000 + akku_kapac;
        }
    }
}
