
//mostrar na consola numeros de 5 em 5
// 0
// 5
// 10
// 15
// 25
//limite minimo e maximo ao utilizador
//
//a frente de cada numero coloquem sinal pedido ao utilizador e repitir esse sinal
// 5 ´´´´´´
// 10 ++++++++++



//aprensetacao do programa/recolha de dados
Console.WriteLine("defina numero minimo para intervalo");
int minimo = int.Parse(Console.ReadLine());
Console.WriteLine("defina numero maximo para intervalo");
int maximo = int.Parse(Console.ReadLine());
Console.Write("Introduza o sinal desejado: ");
string sinal = Console.ReadLine();

Programa(minimo, maximo, sinal);

static void Programa(int minimo, int maximo, string sinal)
{
   
    //ciclo definido pelo utilizador, incrementa +5
    for (int i = minimo; i <= maximo; i += 5)
    {
        //print ao i
        string linha = $"{i} ";
        //ciclo do tamanho do i atual para concatenar N vezes o sinal
        for (int j = 0; j < i; j++)
        {
            linha += sinal;
        }

        Console.WriteLine(linha);
    }

}


