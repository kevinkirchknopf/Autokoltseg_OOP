namespace Auto_koltsegek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Járműköltség kalkulátor");
            Console.WriteLine("2. Flotta kezelése");
            int opc1 = int.Parse(Console.ReadLine());
            Console.Clear();
            if(opc1 == 1 ) 
            {
                Console.WriteLine("1. Benzin, 2. Dízel, 3. Elektromos");
                int opc2 = int.Parse(Console.ReadLine());
                Console.Clear();
                if (opc2 == 1)
                {
                    benya();
                }
                if (opc2 == 2)
                {
                    dizel();
                }
                if (opc2 == 3)
                {
                    elektromos();
                }
            }
            if(opc1 == 2)
            {
                Flotta flotta = new Flotta();
                
            }
            
            Console.ReadKey();

        }

        static void benya()
        {
            Console.WriteLine("Add meg a lökettérfogatot!");
            int lokter_fog = int.Parse(Console.ReadLine());

            Console.WriteLine("Add meg a hengerszámot!");
            int hengszam = int.Parse(Console.ReadLine());

            Console.WriteLine("Add meg a maximális fordulatot!");
            int max_ford = int.Parse(Console.ReadLine());

            benzines ben1 = new benzines(lokter_fog, hengszam, max_ford);

            Console.WriteLine($"A karbantartási költség: {ben1.Karbtart_kalk()}");
            Console.WriteLine($"A KFB ára: {ben1.KFB_kalk()}");
            Console.WriteLine($"A fogyasztás: {ben1.Efogyaszt()}");
        }

        static void dizel()
        {
            Console.WriteLine("Add meg a lökettérfogatot!");
            int lokter_fog = int.Parse(Console.ReadLine());

            Console.WriteLine("Add meg a hengerszámot!");
            int hengszam = int.Parse(Console.ReadLine());

            Dizel diz1 = new Dizel(lokter_fog, hengszam);

            Console.WriteLine($"A karbantartási költség: {diz1.Karbtart_kalk()}");
            Console.WriteLine($"A KFB ára: {diz1.KFB_kalk()}");
            Console.WriteLine($"A fogyasztás: {diz1.Efogyaszt()}");
        }

        static void elektromos()
        {
            Console.WriteLine("Add meg az akkumlátor kapacitását");
            int akku = int.Parse(Console.ReadLine());

            Console.WriteLine("Add meg a teljesitmenyt");
            int teljesitmeny = int.Parse(Console.ReadLine());

            Elektromos elek1 = new Elektromos(akku, teljesitmeny);

            Console.WriteLine($"A karbantartási költség: {elek1.Karbtart_kalk()}");
            Console.WriteLine($"A KFB ára: {elek1.KFB_kalk()}");
            Console.WriteLine($"A fogyasztás: {elek1.Efogyaszt()}");

        }

    }
}