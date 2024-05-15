using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace avaliacao2703.Models
{
    public class Dado
    {
        public int NumeroDeLado { get; set; }
        public int NumeroSorteado { get; set; }

        public string Rolar(int max)
        {
            Random rand = new Random();
            if (max  < 0) { return ""; }

            int min = 1;

            int v = rand.Next(min, max + 1);
            return v.ToString();
        }
    }
}
