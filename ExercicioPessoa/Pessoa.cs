using System;

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
