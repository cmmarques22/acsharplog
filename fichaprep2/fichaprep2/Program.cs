Console.WriteLine("defina numero minimo para intervalo");
int minimo = int.Parse(Console.ReadLine());
Console.WriteLine("defina numero maximo para intervalo");
int maximo = int.Parse(Console.ReadLine());
Console.Write("Introduza o sinal desejado: ");
string sinal = Console.ReadLine();

//TrianguloRetangulo(minimo, maximo, sinal);

static void TrianguloRetangulo(int minimo, int maximo, string sinal)
{
    string repeticoes = "";

    for (int i = minimo; i <= maximo; i += 5)
    {
        repeticoes += sinal;

        Console.WriteLine($"{repeticoes}");
    }
}

//TrianguloEquilatero1(minimo, maximo, sinal);

static void TrianguloEquilatero1(int minimo, int maximo, string sinal)
{
    string repeticoes = "";

    for (int i = minimo; i <= maximo; i++)
    {
        // Calcula o número de espaços antes do sinal para centralizar a linha
        int centrodoLoop = (maximo - i) / 2;

        // Adiciona espaços antes do sinal para centralizar
        for (int k = 0; k < centrodoLoop; k++)
        {
            Console.Write('_');
        }

        // Imprime os sinais
        for (int j = 0; j < i; j++)
        {
            Console.Write(sinal);
        }
        // próxima linha
        Console.WriteLine();
    }
}

TrianguloEquilatero2(minimo, maximo, sinal);

static void TrianguloEquilatero2(int minimo, int maximo, string sinal)
{

    for (int i = minimo; i <= maximo; i++)
    {
        // Calcula o número de espaços antes do sinal para centralizar a linha
        int centrodoLoop = (maximo - i) / 2;

        // Adiciona espaços antes do sinal para centralizar
        for (int k = 0; k < centrodoLoop; k++)
        {
            Console.Write('_');
        }

        // Imprime os sinais
        for (int j = 0; j < i; j++)
        {
            Console.Write(sinal);
        }
        //prrencher o resto da linha
        for (int l = 0; l < ((maximo - centrodoLoop)-i); l++)
        {
            Console.Write('_');
        }
        // próxima linha
        Console.WriteLine();
    }
}