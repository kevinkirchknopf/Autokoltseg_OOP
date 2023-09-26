using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auto_koltsegek
{
    abstract class Auto
    {
        abstract public int KFB_kalk();

        abstract public int Efogyaszt();

        abstract public int Karbtart_kalk();
            

    }
}
