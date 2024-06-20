public class Program
{
    public static void Main()
    {
        // Exemplo de vetor de faturamento diário
        int[] faturamento_anual = new int[] {
            100, 200, 0, 150, 300, 250, 0, 180, 220, 280, 200, 150, 0, 175, 225,
            275, 250, 300, 0, 200, 150, 250, 275, 225, 0, 190, 210, 220, 300,
            175, 0, 200, 180, 220, 280, 250, 0, 150, 175, 225, 275, 200, 0,
            190, 225, 250, 275, 225, 0, 200, 175, 225, 275, 250, 0, 200, 225,
            275, 250, 275, 0, 200, 220, 280, 250, 275, 0, 175, 200, 250, 275,
            200, 0, 200, 220, 280, 250, 300, 0, 175, 200, 250, 275, 200, 0,
            190, 210, 220, 300, 175, 0, 200, 225, 275, 250, 275, 0, 190, 225,
            250, 275, 225, 0, 200, 180, 220, 280, 250, 0, 150, 175, 225, 275,
            200, 0, 190, 225, 250, 275, 225, 0, 200, 220, 280, 250, 275, 0,
            175, 200, 250, 275, 200, 0, 200, 220, 280, 250, 300, 0, 175, 200,
            250, 275, 200, 0, 190, 210, 220, 300, 175, 0, 200, 225, 275, 250,
            275, 0, 190, 225, 250, 275, 225, 0, 200, 180, 220, 280, 250, 0,
            150, 175, 225, 275, 200, 0
        };

        // Chamando a função analisar_faturamento_anual
        var resultados = analisar_faturamento_anual(faturamento_anual);

        // Exibindo os resultados
        Console.WriteLine($"Menor valor de faturamento diário: {resultados.Item1}");
        Console.WriteLine($"Maior valor de faturamento diário: {resultados.Item2}");
        Console.WriteLine($"Número de dias com faturamento acima da média anual: {resultados.Item3}");
    }

    // Definindo a função analisar_faturamento_anual
    public static (int, int, int) analisar_faturamento_anual(int[] faturamento_diario)
    {
        // Encontra o menor valor de faturamento diário
        int menor_valor = faturamento_diario.Min();

        // Encontra o maior valor de faturamento diário
        int maior_valor = faturamento_diario.Max();

        // Calcula a média anual de faturamento, ignorando dias sem faturamento
        var faturamento_positivo = faturamento_diario.Where(f => f > 0);
        double media_anual = faturamento_positivo.Sum() / faturamento_positivo.Count();

        // Conta o número de dias em que o faturamento diário foi superior à média anual
        int dias_acima_da_media = faturamento_diario.Count(f => f > media_anual);

        // Retorna os resultados
        return (menor_valor, maior_valor, dias_acima_da_media);
    }
}