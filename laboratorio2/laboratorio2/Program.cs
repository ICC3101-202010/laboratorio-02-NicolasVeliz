using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laboratorio2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Cancion cancion1 = new Cancion("Entre canibales", "Soda", "Comfort y musica para volar", "rock");
            Cancion cancion2 = new Cancion("True love", "SOJA", "Peace in time of war", "Regae");
            Cancion cancion3 = new Cancion("Ignorantes", "Bad bunny", "YHLQMDLG", "Trap");

            Console.WriteLine(cancion1.Informacion());
            Console.WriteLine(cancion2.Informacion());
            Console.WriteLine(cancion3.Informacion());

            Console.ReadKey();

        }
    }
}
