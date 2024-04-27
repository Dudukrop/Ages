using System;
using System.Globalization;
using Exercicio___Idades.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio___Idades
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("First person data:");
            Console.Write("Name: ");
            string name1 = Console.ReadLine();
            Console.Write("Age: ");
            int age1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Second person data:");
            Console.Write("Name: ");
            string name2 = Console.ReadLine();
            Console.Write("Age: ");
            int age2 = int.Parse(Console.ReadLine());

            Pessoa pessoa = new Pessoa(name1, age1, name2, age2);

            Console.WriteLine(pessoa);
        }
    }
}
