using System;
using System.Globalization;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 5 - Caracteres e Textos");
        /* https://www.rapidtables.com/code/text/ascii-table.html */

        char letra = 'a';
        Console.WriteLine(letra);

        letra = (char)65;
        Console.WriteLine(letra);

        letra = (char)(65 + 1);
        Console.WriteLine(letra);

        string primeiraFrase = "Alura - Cursos de Tecnologia ";
        Console.WriteLine(primeiraFrase + 2022);

        string vazia = "";
        Console.WriteLine(vazia);

        string cursosDisponiveis = @"Cursos disponíveis na Alura:
        - Go;
        - C#;
        - JS;
        - Java;";
        Console.WriteLine(cursosDisponiveis);

        Console.WriteLine("Tecle ENTER para fechar...");
        Console.ReadLine();
    }
}