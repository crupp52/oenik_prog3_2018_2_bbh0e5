namespace VideoSharing.Program
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Contains the ToStringArray and the CallQruery functions.
    /// </summary>
    public static class Tools
    {
        public static string[] CollectParameters()
        {
            Console.WriteLine("Add meg a bemeneti paramétereket SZÓKÖZZEL elválasztva.");
            Console.Write("Paraméterek: ");
            string param = Console.ReadLine();

            return param.Split(' ');
        }

        public static int CollectId()
        {
            Console.Write("Add meg az ID-t: ");
            string id = Console.ReadLine();

            return int.Parse(id);
        }
    }
}
