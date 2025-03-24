namespace GaussSolver;

public static class ResolverSistema
{
    public static void Executar(double[,] matriz, int dimensao, double[] solucao)
    {
        for (int i = dimensao - 1; i >= 0; i--)
        {
            solucao[i] = matriz[i, dimensao];

            for (int j = i + 1; j < dimensao; j++)
            {
                solucao[i] -= matriz[i, j] * solucao[j];
            }
        }
    }
}
