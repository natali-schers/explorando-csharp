using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 7 - Condicionais");

        int idadeJoao = 16;
        int qtdePessoas = 2;

        bool acompanhamento = qtdePessoas > 1;

        if (idadeJoao >= 18 || acompanhamento )
        {
            Console.WriteLine("Pode entrar!");
        }
        else
        {    
            Console.WriteLine("Não pode entrar!");
        }

        int idade = 68;
        bool ehIdoso = idade >= 65;
        Console.WriteLine(ehIdoso);

        Console.WriteLine("Tecle ENTER para fechar...");
        Console.ReadLine();
    }
}