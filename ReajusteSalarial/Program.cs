using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReajusteSalarial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double salario = 0;
            double salarionovo = 0;

            for(int i = 0; i < 4; i++)
            {
                Console.WriteLine("Digite seu Salario: ");
                salario = Convert.ToDouble(Console.ReadLine());

                if(salario <= 300)
                {
                    salarionovo = salario * 1.50;
                }
                else 
                {
                    salarionovo = salario + ((salario * 30) / 100);
                }
                


            }
            Console.WriteLine("Salario Reajustado " + salarionovo);
            Console.ReadKey();



        }
    }
}
