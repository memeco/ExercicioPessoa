using System;

namespace ExercicioPessoa
{
    public class Pessoa
    {
        private string nome;
        private int idade;
        private double altura;

        public Pessoa(string nome, int idade, double altura)
        {
            this.nome = nome;
            this.idade = idade;
            this.altura = altura;
        }

        public void Apresentar()
        {
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"Idade: {idade} anos");
            Console.WriteLine($"Altura: {altura:F2} m");
        }
    }

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
