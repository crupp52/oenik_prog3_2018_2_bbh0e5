using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoSharing.Program
{
    class Menu
    {
        public Menu()
        {
            this.PrintMenu();

            string answ = string.Empty;
            while (answ != "q")
            {
                Console.Write("parancs: ");
                answ = Console.ReadLine();

                Console.WriteLine("Még nincs kész!");
                //switch (answ)
                //{
                //    default:
                //        Console.WriteLine("Rossz lehetőség. A felsoroltak közül válassz!");
                //        break;
                //}
            }
        }

        private void PrintMenu()
        {
            Console.WriteLine("Válassz az alábbi lehetőségek közül!");

            Console.WriteLine("\nCRUD lekérdezések");

            Console.WriteLine("Videos tábla lekérdezései:");
            Console.WriteLine("\tvid-q1: Tábla kilistázása");
            Console.WriteLine("\tvid-q2: Tábla módosítása");
            Console.WriteLine("\tvid-q3: Táblához adás");
            Console.WriteLine("\tvid-q4: Táblából törlés");

            Console.WriteLine("Categories tábla lekérdezései:");
            Console.WriteLine("\tcat-q1: Tábla kilistázása");
            Console.WriteLine("\tcat-q2: Tábla módosítása");
            Console.WriteLine("\tcat-q3: Táblához adás");
            Console.WriteLine("\tcat-q4: Táblából törlés");

            Console.WriteLine("Creators tábla lekérdezései:");
            Console.WriteLine("\tcre-q1: Tábla kilistázása");
            Console.WriteLine("\tcre-q2: Tábla módosítása");
            Console.WriteLine("\tcre-q3: Táblához adás");
            Console.WriteLine("\tcre-q4: Táblából törlés");

            Console.WriteLine("Uploads tábla lekérdezései:");
            Console.WriteLine("\tupl-q1: Tábla kilistázása");
            Console.WriteLine("\tupl-q2: Tábla módosítása");
            Console.WriteLine("\tupl-q3: Táblához adás");
            Console.WriteLine("\tupl-q4: Táblából törlés");

            Console.WriteLine("\nNem CRUD lekérdezések");

            Console.WriteLine("\tcustom-q1: Videók címének és készítőjének neve");
            Console.WriteLine("\tcustom-q2: Videók és kategóriájuk");
            Console.WriteLine("\tcustom-q3: Videók és feltöltési idejük");

            Console.WriteLine("\nJAVA lekérdezés");
            Console.WriteLine("\tjava: Küldött adat feldolgozása");
        }
    }
}
