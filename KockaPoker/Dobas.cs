using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KockaPoker
{
    class Dobas
    {
        int[] kockak = new int[5];

        public Dobas()
        {

        }

        public void EgyDobas()
        {
            Random vel = new Random();

            for (int i = 0; i < kockak.Length; i++)
            {
                kockak[i] = vel.Next(1, 7);
            }
        }

        public void Kiiras()
        {
            foreach (var k in kockak)
            {
                Console.Write($"{k} ");
            }
        }

        public string Erteke()
        {
            Dictionary<int, int> eredmeny = new Dictionary<int, int>();

            for (int i = 0; i <= 6; i++)
            {
                eredmeny.Add(i, 0);
            }

            foreach (var k in kockak)
            {
                eredmeny[k]++;
            }

            if (eredmeny.ContainsValue(4))
            {
                return "Póker";
            }
            else if (eredmeny.ContainsValue(5))
            {
                return "Nagypóker";
            }
            else if (eredmeny.ContainsValue(3))
            {
                if (eredmeny.ContainsValue(3) && eredmeny.ContainsValue(2))
                {
                    return "Full";
                }
                return "Drill";
            }
            else if (eredmeny.ContainsValue(2))
            {
                return "Pár";
            }
            return "Meh";
        }
    }
}
