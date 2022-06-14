using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorBinarioDecimal.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese un número binario:");
            var nroBinario = int.Parse(Console.ReadLine());
            Console.WriteLine($"{nroBinario} es  equivalente a {Conversor.ConvertirBinarioDecimal(nroBinario)}");
            Console.ReadLine();
        }
    }
}
