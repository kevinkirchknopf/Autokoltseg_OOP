using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auto_koltsegek
{
    internal class Flotta
    {
        //ITT VALAMI FOS
        List<Auto> Autok = new List<Auto>();


        public Flotta()
        {
            Menu();
        }

        private void Benzines_Hozzaad(int lokter_fog, int hengsz, int maxford, string rendszam)
        {
            Autok.Add(new benzines(lokter_fog, hengsz, maxford, rendszam)); 
        }

        private void Dizel_Hozzaad(int lokter_fog, int hengsz, string rendszam)
        {
            Autok.Add(new Dizel(lokter_fog, hengsz, rendszam));
        }

        private void Elektromos_Hozzaad(int akku_kapac, int teljesitmeny, string rendszam)
        {
            Autok.Add(new Elektromos(akku_kapac, teljesitmeny, rendszam));
        }

        public void Menu()
        {
            Console.WriteLine("1. Benzin; 2. Dízel, 3. Elektromos");
            int opcio = int.Parse(Console.ReadLine());
            Console.Clear();
           


            if (opcio == 1)
            {
                Console.WriteLine("Mekkora lökettérfogat?");
                int lokter = int.Parse(Console.ReadLine());

                Console.WriteLine("Hány hengeres?");
                int hengsz = int.Parse(Console.ReadLine());

                Console.WriteLine("Mennyi a max fordulat?");
                int maxford = int.Parse(Console.ReadLine());

                Benzines_Hozzaad(lokter, hengsz, maxford);

                Console.WriteLine("Mi a rendszáma?");
                Autok


                
            }
            if (opcio == 2)
            {
                Console.WriteLine("Mekkora lökettérfogat?");
                int lokter = int.Parse(Console.ReadLine());

                Console.WriteLine("Hány hengeres?");
                int hengsz = int.Parse(Console.ReadLine());

                Dizel_Hozzaad(lokter, hengsz);
            }
            if (opcio == 3)
            {
                Console.WriteLine("Mekkora az akku kapacitása?");
                int akku_kapac = int.Parse( Console.ReadLine());

                Console.WriteLine("Mekkora a teljesitmeny?");
                int teljesitmeny = int.Parse(Console.ReadLine());

                Elektromos_Hozzaad(akku_kapac, teljesitmeny);
            }


            Console.ReadLine();
        }

     

    }
}
