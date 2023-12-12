
//recolher variaveis da consola

using System.Diagnostics.Metrics;

Console.WriteLine("Escolha um digito para inicial o intervalo");
int intervaloMin = int.Parse(Console.ReadLine());

Console.WriteLine("Escolha um digito para fechar o intervalo");
int intervaloMax = int.Parse(Console.ReadLine());


static int Soma(int bananas, int laranjas)
{
    int soma = 0;

    for (int i = bananas; i <= laranjas; i++)
    {
        soma += i;
    }
    return soma;
}

static string SomaExtenso(int bananas, int laranjas)
{
    string somaPorExtenso = "";

    for (int i = bananas; i <= laranjas; i++)
    {
        somaPorExtenso += i;
        somaPorExtenso += " + ";

    }
    return somaPorExtenso;
}
Console.WriteLine($"Soma de {intervaloMin} até {intervaloMax} é: {Soma(intervaloMin, intervaloMax)}");
Console.WriteLine($"Soma de {intervaloMin} até {intervaloMax} é: {SomaExtenso(intervaloMin, intervaloMax)}");

