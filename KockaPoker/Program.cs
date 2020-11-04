using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KockaPoker
{
    class Program
    {
        static void Main(string[] args)
        {
            Dobas d = new Dobas();

            d.EgyDobas();
            d.Kiiras();
            Console.WriteLine(d.Erteke());
            Console.ReadKey();
        }
    }
}
