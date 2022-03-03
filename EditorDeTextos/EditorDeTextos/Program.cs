using System;
using System.IO;

namespace EditorDeTextos
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }
        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("_______________________ C# WRITING _______________________");
            Console.WriteLine("                     O que deseja fazer?                  ");
            Console.WriteLine("1 - Novo Arquivo");
            Console.WriteLine("2 - Abrir Arquivo");
            Console.WriteLine("0 - Sair");

            int entrada = int.Parse(Console.ReadLine());

            if (entrada == 1)
                Editar();
            else if (entrada == 2)
                Abrir();
            else if (entrada == 0)
                Environment.Exit(0);
        }   
        static void Editar() 
        {
            Console.Clear();
            Console.WriteLine("Digite seu texto abaixo:");
            Console.WriteLine("________________________");
            string texto = " ";

            do
            {
                texto += Console.ReadLine();
                texto += Environment.NewLine;

            } while (Console.ReadKey().Key != ConsoleKey.Escape);

            Salvar(texto);

        }
        static void Abrir()
        {
            Console.Clear();
            Console.WriteLine("Digite o caminho do arquivo:");
            string caminho = Console.ReadLine();

            using (var arquivo = new StreamReader(caminho))
            {
                string texto = arquivo.ReadToEnd();
                Console.WriteLine(texto);
            }
            Console.WriteLine("");
            Menu();
        }
        static void Salvar(string texto)
        {
            Console.Clear();
            Console.WriteLine("Onde deseja salvar o arquivo?");
            var caminho = Console.ReadLine();

            using (StreamWriter arquivo = new StreamWriter(caminho))
            {
                arquivo.Write(texto);
            }
            Console.WriteLine("Arquivo salvo com Sucesso!");
        }
    }
}
