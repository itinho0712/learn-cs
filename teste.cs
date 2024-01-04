using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite o primeiro termo da progressão aritmética: ");
        int primeiroTermo = Convert.ToInt32(Console.ReadLine());
        int diferenca = 2;
        int termoAtual = primeiroTermo;

        Console.WriteLine("Os 10 primeiros termos da progressão aritmética são:");

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(termoAtual);
            termoAtual += diferenca;
        }
    }
}
