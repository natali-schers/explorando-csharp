using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 4 - Convertendo Variáveis Numéricas");

        double salario = 3000.15;
        Console.WriteLine(salario);

        int salarioInteiro = (int)salario;
        Console.WriteLine(salarioInteiro);

        //O long é um tipo de variável de 64 bits
        long x = 20000000000;
        Console.WriteLine(x);

        //O short é um tipo de variável de 16 bits
        short y = 20000;
        Console.WriteLine(y);

        float altura = 1.62f;
        Console.WriteLine(altura);

        Console.WriteLine("Tecle ENTER para fechar...");
        Console.ReadLine();
    }
}
