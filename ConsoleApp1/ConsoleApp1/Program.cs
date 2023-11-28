using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            // progam that takes 2 ints and outpus in console


            // variables
            int numberOne, numberTwo;
            int soma, subtracao, multiplicacao, quociente, resto;
            double divisao;


            //apresentar programa
            Console.WriteLine("=====================================");
            Console.WriteLine("=====================================");
            Console.WriteLine("=====================================");


            // obter 2 inteiros
            //numberOne = 7;
            //numberTwo = 2;
            Console.WriteLine("Número 1: ");
            numberOne = int.Parse(Console.ReadLine());
            Console.WriteLine("Número 2: ");
            numberTwo = int.Parse(Console.ReadLine());


            // realizar operacoes matematicas
            soma = numberOne + numberTwo;
            subtracao = numberOne - numberTwo;
            multiplicacao = numberOne * numberTwo;
            quociente = numberOne / numberTwo;
            divisao = (float)numberOne / (float)numberTwo;
            resto = numberOne % numberTwo;

            // apresentar os resultados
            Console.WriteLine("Results");
            Console.WriteLine("Soma: " + soma);
            Console.WriteLine("Subtracao: " + subtracao);
            Console.WriteLine($"Subtracao: { subtracao}");
            Console.WriteLine($"Subtracao entre {numberOne} e {numberTwo} dá " + subtracao);
            Console.WriteLine($"Multiplicacao:{ multiplicacao}");
            Console.WriteLine("Quociente: {0}, Divisao: {1}, Restante: {2}",
                quociente,
                divisao,
                resto
                );








        }
    }
}
