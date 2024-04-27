using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio___Idades.Entities
{
    class Pessoa
    {
        public string Name1 { get; set; }
        public int Age1 { get; set; }
        public string Name2 { get; set; }
        public int Age2 { get; set; }

        public Pessoa(string name1, int age1, string name2, int age2)
        {
            Name1 = name1;
            Age1 = age1;
            Name2 = name2;
            Age2 = age2;
        }

        public double Media()
        {
            return ((double)Age1 + Age2) / 2;
        }

        public override string ToString()
        {
            return "A idade media de "
                + Name1
                + " e "
                + Name2
                + " eh de "
                + Media().ToString("F1", CultureInfo.InvariantCulture);
        }
    }
}
