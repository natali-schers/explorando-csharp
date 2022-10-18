using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 7 - Condicionais");

        int idadeJoao = 19;
        int qtdePessoas = 1;

        bool acompanhamento = qtdePessoas > 1;

        string textoAdicional;

        if (acompanhamento == true)
        {
            textoAdicional = "Está acompanhado. ";
        }
        else
        {
            textoAdicional = "Está desacompanhado. ";
        }

        if (idadeJoao >= 18 || acompanhamento)
        {
            Console.WriteLine(textoAdicional + "Pode entrar!");
        }
        else
        {
            Console.WriteLine(textoAdicional + "Não pode entrar!");
        }

        Console.WriteLine("Tecle ENTER para fechar...");
        Console.ReadLine();
    }
}