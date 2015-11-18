using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAfKlasse
{
    class Figure
    {
        public void volume()
        {
            Console.WriteLine("kan ikke regne rumfang");
        }
        public void area()
        {
            Console.WriteLine("Kan ikke regne areal");
            Console.WriteLine();
        }
    }
    class Sqare : Figure
    {
        public void area(int l, int h)
        {
            Console.WriteLine(l * h);
        }
    }
    class Tube : Figure
    {
        public void volume(int r, int h)
        {
            Console.WriteLine(3.14 * (r * r) * h);
            Console.WriteLine();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Sqare s1 = new Sqare();
            s1.area(2, 2);
            s1.volume();
            Tube t1 = new Tube();
            t1.area();
            t1.volume(2, 2);
        }
    }
}
