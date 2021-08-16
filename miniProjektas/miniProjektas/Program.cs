using System;
using System.Text;

namespace miniProjektas
{
//    Sukurti parduotuvę, kuri parduoda saldainius, knygas, puodukus.
//Jie visi turi pavadinimą, kiekį. Programa turėtų nepasibaigti įrašius tik vieną komandą,
//turėtų leisti kelias.Reikia panaudoti objektinį programavimą.

//Galimos komandos konsolėje:
//"List" išspausdina informacija, ką galima nusipirkti parduotuvėje, koks kiekis ir kokios kainos.Išpirktų produktų neturėtų rodyti.
//"Buy Candy 20" - turėtų nupirkti visus egzistuojančius jeigu toks item egzistuoja parduotuvėje ir yra toks kiekis.Jei ne, turėtų parodyti atitinkamą žinutę.
//"Add Cup 30" - turėtų papildyti parduotuvę su atitinkamu produktu ir kiekiu. Tai turętų atsivaizduoti ir "List" komandoje.
//Jei tokiu produktų jau yra, papildyti.
    class Program
    {
        static void Main(string[] args)
        {
            var parduotuve = new Shop();
            var user = new User();


            Console.WriteLine("Sveiki atvyke i mini parduotuve!!!");
            Console.WriteLine("----------------------------------");

            while (true)
            {
            Console.WriteLine();
            Console.WriteLine("Galimu prekiu pasirinkimas:");
            Console.WriteLine();

            Console.WriteLine();
            Console.WriteLine("1 - List išspausdina informacija, ką galima nusipirkti parduotuvėje, koks kiekis ir kokios kainos.");
            Console.WriteLine("2 - Buy(pavadinimas)(kiekis) - perki visus egzistuojančius jeigu toks item egzistuoja parduotuvėje ir yra toks kiekis.");
            Console.WriteLine("3 - Add(pavadinimas)(kiekis) - papildyti parduotuvę su atitinkamu produktu ir kiekiu.");
            Console.WriteLine("4 - Iseiti is parduotuves");
            Console.WriteLine();
            Console.WriteLine("Jusu pasirinkimas: ");

            var pick = Convert.ToInt32(Console.ReadLine());             
            switch (pick)
            {
                case 1:
                        Console.WriteLine("Spausdinam informacija apie prekes parduotuveje:");
                        parduotuve.List();
                        Console.WriteLine();
                    break;

                case 2:
                        Console.WriteLine("Parduotuveje yra:");
                        parduotuve.List();
                        Console.WriteLine();
                        Console.Write("Kokia preke is galimu pasirinkimu Id: ");
                        var buyId = Convert.ToInt32(Console.ReadLine()); 
                        Console.Write("Pasirinkite produkto kieki: ");
                        var buyQty = Convert.ToInt32(Console.ReadLine());
                        parduotuve.Buy(buyId, buyQty);           
                    break;

                case 3:
                        Console.WriteLine("Parduotuveje yra:");
                        parduotuve.List();
                        Console.WriteLine();
                        Console.Write("Kokia preke is galimu pasirinkimu Id: ");
                        var addId = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Pasirinkite produkto kieki: ");
                        var addQty = Convert.ToInt32(Console.ReadLine());
                        parduotuve.Add(addId, addQty);
                    break;

                    case 4:
                        return;                    

                    default:
                        Console.WriteLine("Negalimas veiksmas. Bandykite dar karta!");
                        break;
                }

        }
        }
    }
}
