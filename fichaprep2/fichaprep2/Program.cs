Console.WriteLine("defina numero minimo para intervalo");
int minimo = int.Parse(Console.ReadLine());
Console.WriteLine("defina numero maximo para intervalo");
int maximo = int.Parse(Console.ReadLine());
Console.Write("Introduza o sinal desejado: ");
string sinal = Console.ReadLine();

//Programa(minimo, maximo, sinal);

//static void Programa(int minimo, int maximo, string sinal)
//{
//    string repeticoes = "";

//    for (int i = minimo; i <= maximo; i += 5)
//    {
//        repeticoes += sinal;

//        Console.WriteLine($"{repeticoes}");
//    }
//}

Programa(minimo, maximo, sinal);

static void Programa(int minimo, int maximo, string sinal)
{
    string repeticoes = "";

    for (int i = minimo; i <= maximo; i += 5)
    {
        repeticoes += sinal;

        Console.WriteLine($"{repeticoes}");

        for (int k = 1; k <= i; k++)
        {
            Console.Write(" *");
            if (k > 3)
            {
                for (int l = 1; l <= k - 2; l++)
                {
                    Console.Write(" ");
                }

            }
        }
    }



    


}