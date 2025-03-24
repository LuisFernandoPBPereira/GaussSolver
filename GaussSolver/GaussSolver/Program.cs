using GaussSolver;

try
{
    Console.Write("Digite o número de variáveis/equações (X): ");
    int dimensao = int.Parse(Console.ReadLine()!);
    const int TERMO_INDEPENDENTE = 1;

    double[,] matriz = new double[dimensao, dimensao + TERMO_INDEPENDENTE];

    Console.WriteLine("Digite os coeficientes da matriz aumentada (incluindo os termos independentes):");
    for (int i = 0; i < dimensao; i++)
    {
        for (int j = 0; j < dimensao + 1; j++)
        {
            matriz[i, j] = double.Parse(Console.ReadLine()!);
        }
    }

    Console.WriteLine("Matriz inicial:");
    ImprimeMatriz.Executar(matriz, dimensao);

    Escalonamento.Executar(matriz, dimensao);

    double[] solucao = new double[dimensao];
    for (int i = dimensao - 1; i >= 0; i--)
    {
        solucao[i] = matriz[i, dimensao];
        for (int j = i + 1; j < dimensao; j++)
        {
            solucao[i] -= matriz[i, j] * solucao[j];
        }
    }

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