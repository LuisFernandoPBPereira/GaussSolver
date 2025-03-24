using GaussSolver;

try
{
    #region Montando a matriz com o sistema

    Console.Write("Digite o número de variáveis/equações (X): ");
    int dimensao = int.Parse(Console.ReadLine()!);
    const int TERMO_INDEPENDENTE = 1;

    double[,] matriz = new double[dimensao, dimensao + TERMO_INDEPENDENTE];
    double[] solucao = new double[dimensao];

    Console.WriteLine("Digite os coeficientes da matriz aumentada (incluindo os termos independentes):");
    for (int i = 0; i < dimensao; i++)
    {
        for (int j = 0; j < dimensao + 1; j++)
        {
            matriz[i, j] = double.Parse(Console.ReadLine()!);
        }
    }

    #endregion

    Console.WriteLine("Matriz inicial:");
    ImprimeMatriz.Executar(matriz, dimensao);

    #region Resolução do Escalonamento

    Escalonamento.Executar(matriz, dimensao);
    ResolverSistema.Executar(matriz, dimensao, solucao);

    #endregion

    Console.WriteLine("Solução do sistema:");
    for (int i = 0; i < dimensao; i++)
    {
        Console.WriteLine($"x{i + 1} = {Math.Round(solucao[i])}");
    }

}
catch (Exception excecao)
{
    Console.WriteLine($"Erro inesperado: {excecao.Message}");
}