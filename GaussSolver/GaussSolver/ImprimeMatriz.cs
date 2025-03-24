namespace GaussSolver;

public static class ImprimeMatriz
{
    public static void Executar(double[,] matriz, int dimensao)
    {
        for (int i = 0; i < dimensao; i++)
        {
            for (int j = 0; j < dimensao + 1; j++)
            {
                Console.Write($"{Math.Round(matriz[i, j]):F2} ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}
