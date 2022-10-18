using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 7 - Condicionais");

        int idadeJoao = 16;
        int qtdePessoas = 2;

        if (idadeJoao >= 18)
        {
            Console.WriteLine("Pode entrar!");
        }
        else
        {
            if (qtdePessoas > 1)
            {
                Console.WriteLine("Ele(a) está acompanhado, pode entrar!");
            }
            else
            {
                Console.WriteLine("Não pode entrar!");
            }
        }

        Console.WriteLine("Tecle ENTER para fechar...");
        Console.ReadLine();
    }
}