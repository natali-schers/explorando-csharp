using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 10 - Condicional While");

        double investimento = 1000;

        int mes = 1;

        while (mes <= 12)
        {
            //rendimento 0,5%(0.005) ao mês
            investimento = investimento + investimento * 0.005;
            Console.WriteLine("No mês " + mes + " você terá R$" + investimento + ".");

            mes++;
        }

        Console.WriteLine("Tecle ENTER para fechar...");
        Console.ReadLine();
    }
}