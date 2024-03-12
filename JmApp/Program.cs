using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JmApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual sua altura");
            double alt = double.Parse(Console.ReadLine());

            Console.WriteLine("Qual seu peso");
            double peso = double.Parse(Console.ReadLine());

            double imc = peso / (alt * alt);

            Console.WriteLine("O seu IMC é: " + imc );
            if (imc < 17 )
            { 
                Console.WriteLine("Muito abaixo do peso");               
            }

            else if (imc < 18.5) 
            {
                Console.WriteLine("Abaixo do peso"); 
            }
            
            else if (imc < 25)
            {
                Console.WriteLine("Peso normal");
            }
            
            else if (imc < 30)
            {
                Console.WriteLine("Acima do peso");
            }

            else if (imc < 35)
            {
                Console.WriteLine("Obesidade grau I");
            }
            
            else if (imc < 40)
            {
                Console.WriteLine("Obesidade grau II");
            }
            
            else
            {
                Console.WriteLine("Obesidade grau III");
            } 
        
            Console.ReadKey();
        }

    }
}
