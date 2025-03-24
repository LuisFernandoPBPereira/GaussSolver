namespace GaussSolver;

public static class Escalonamento
{
    public static void Executar(double[,] matriz, int dimensao)
    {
        for (int i = 0; i < dimensao; i++)
        {
            double pivot = matriz[i, i];
            if (pivot == 0)
            {
                Console.WriteLine("Erro: Pivô é zero. O sistema pode ser indeterminado ou impossível.");
                return;
            }

            for (int j = i; j < dimensao + 1; j++)
            {
                matriz[i, j] /= pivot;
            }

            for (int k = i + 1; k < dimensao; k++)
            {
                double fator = matriz[k, i];
                for (int j = i; j < dimensao + 1; j++)
                {
                    matriz[k, j] -= fator * matriz[i, j];
                }
            }

            Console.WriteLine($"Matriz após a iteração {i + 1}:");
            ImprimeMatriz.Executar(matriz, dimensao);
        }
    }
}
