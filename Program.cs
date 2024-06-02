using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversor_deTemperaturas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double celcius, farenraid, kelvin;

            Console.WriteLine("CONVERSOR DE TEMPERATURAS");
            Console.Write("Insira a temperatura em Ceucius: ");
            celcius = double.Parse(Console.ReadLine());
            Console.WriteLine(" ------------------------------");

            // (celcius * 9 / 5) + 32 farenraid
            farenraid = (celcius * 9 / 5) + 32;

            // ceulcius + 273,15
            kelvin = celcius + 273.15;

            Console.WriteLine(celcius + " graus celcios = " + farenraid + "graus farenraid");
            Console.WriteLine(celcius + " graus celcios = " + kelvin + "graus kelvin");
            Console.WriteLine(" ------------------------------");
            Console.ReadKey();


        }
    }
}
