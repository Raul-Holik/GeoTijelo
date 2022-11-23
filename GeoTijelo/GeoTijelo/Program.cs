using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoTijelo
{
    class GeoTijelo
    {
        double volumen, oplosje;
        public static int BrojacTijela = 0;
        
    }
    class Kugla:GeoTijelo
    {
        static Kugla()
        {
            BrojacTijela++;
        }
    }
    class Kvadar : GeoTijelo
    {
        static Kvadar()
        {
            BrojacTijela++;
        }
    }
    class Kocka:Kvadar
    {
        static Kocka()
        {
            BrojacTijela++;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Kugla x=new Kugla();
            Kvadar y=new Kvadar();
            Kocka z=new Kocka();

            Console.WriteLine("Ima "+GeoTijelo.BrojacTijela+" tijela.");
            

            Console.ReadKey();
        }
    }
}
