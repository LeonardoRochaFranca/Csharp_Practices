using System;
using System.Globalization;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
 
            while(true)
            {
                Console.Clear();

                Console.WriteLine("********************************");
                Console.WriteLine("*********Calculadora************");
                Console.WriteLine("");

                Console.Write("Primeiro Valor: ");
                double v1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.Write("Qual operação deseja realizar?: ");
                string operacao = Console.ReadLine();

                Console.Write("Segundo Valor: ");
                double v2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                switch (operacao)
                {
                    case "+":
                        Soma(v1, v2);
                        break;

                    case "-":
                        Subtracao(v1, v2);
                        break;

                    case "/":
                        Divisao(v1, v2);
                        break;

                    case "*":
                        Multiplicacao(v1, v2);
                        break;

                    default:
                        Console.WriteLine("Operação não identificada");
                        break;

                }
                Console.WriteLine("********************************");

                Console.Write("Deseja realizar algum calculo? <S/N>");
                string question = Console.ReadLine().ToUpper();

                if(question != "S")
                {
                    break;
                }
            }

        }
        static void Soma(double v1, double v2)
        {
        
            Console.WriteLine();

            var resultado = v1 + v2;

            Console.WriteLine($"O resultado é: {resultado}");
        }
        static void Subtracao(double v1, double v2)
        {
           
            Console.WriteLine();

            var resultado = v1 - v2;
            Console.WriteLine($"O resultado é: {resultado}");
        }
        static void Divisao(double v1, double v2)
        {
            
            Console.WriteLine();

            var resultado = v1 / v2;
            Console.WriteLine($"O resultado é: {resultado}");
        }
        static void Multiplicacao(double v1, double v2)
        {
        
            Console.WriteLine();

            var resultado = v1 * v2;
            Console.WriteLine($"O resultado é: {resultado}");
        }
    }
}
