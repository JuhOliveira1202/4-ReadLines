// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    public static int LerLinhas()
    {
        int linhas;
        Console.Write("Digite o número de linhas: ");
        linhas = Convert.ToInt32(Console.ReadLine());
        return linhas;
    }

    public static void DesenharTriangulo(int linhas)
    {
        int linha, coluna;

        if (linhas > 10)
        {
            Console.WriteLine("O número de linhas não deve ser superior a 10.");
            return; // termina já aqui a função DesenharTriangulo() e volta para a Main()
        }

        for (linha = 0; linha < linhas; linha++)
        {
            for (coluna = 0; coluna <= linha; coluna++)
            {
                Console.Write("*");
            }
            Console.WriteLine(); // mudar para a linha seguinte
        }

    }

    public static void Main(string[] args)
    {
        int linhas;

        linhas = LerLinhas();
        DesenharTriangulo(linhas);

    }

}
