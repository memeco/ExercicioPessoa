using System;

namespace ExercicioPessoa
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa1 = new Pessoa("João Silva", 25, 1.75);
            pessoa1.Apresentar();

            Console.WriteLine();

            Pessoa pessoa2 = new Pessoa("Maria Oliveira", 30, 1.60);
            pessoa2.Apresentar();
        }
    }
}
