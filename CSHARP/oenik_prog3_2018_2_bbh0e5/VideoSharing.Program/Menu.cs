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
                answ = "q";
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

            Console.WriteLine("Videos tábla lekérdezései:");
            Console.WriteLine("\tvideo-q1: Tábla kilistázása");
            Console.WriteLine("\tvideo-q2: Tábla módosítása");
            Console.WriteLine("\tvideo-q3: Táblához adás");
            Console.WriteLine("\tvideo-q4: Táblából törlés");

            Console.WriteLine("Categories tábla lekérdezései:");
            Console.WriteLine("\tcategory-q1: Tábla kilistázása");
            Console.WriteLine("\tcategory-q2: Tábla módosítása");
            Console.WriteLine("\tcategory-q3: Táblához adás");
            Console.WriteLine("\tcategory-q4: Táblából törlés");

            Console.WriteLine("Creators tábla lekérdezései:");
            Console.WriteLine("\tcreator-q1: Tábla kilistázása");
            Console.WriteLine("\tcreator-q2: Tábla módosítása");
            Console.WriteLine("\tcreator-q3: Táblához adás");
            Console.WriteLine("\tcreator-q4: Táblából törlés");

            Console.WriteLine("Uploads tábla lekérdezései:");
            Console.WriteLine("\tupload-q1: Tábla kilistázása");
            Console.WriteLine("\tupload-q2: Tábla módosítása");
            Console.WriteLine("\tupload-q3: Táblához adás");
            Console.WriteLine("\tupload-q4: Táblából törlés");
        }
    }
}
