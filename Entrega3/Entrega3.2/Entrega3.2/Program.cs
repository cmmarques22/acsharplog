Console.WriteLine(@"
Desenvolva uma aplicação que peça um número inteiro ao utilizador (n),
e some os quadrados de [1; n] (pode calcular o quadrado de um número
multiplicando-o por si próprio) (e.g. o 5'2 = 5 x 5 = 25).
");

//variaveis
int number;

//recolha dados
Console.WriteLine("Insere um numero para definir um intervalo de soma dos seus quadrados: ");
number = int.Parse(Console.ReadLine());

//static int RecolheDados()
//{
//    number = int.Parse(Console.ReadLine());
//    if (number < 1)
//    {
//        System.Console.WriteLine("numero negativo, insere novo");
//        number = int.Parse(Console.ReadLine());
//    }
//}

//programa

static int SumSquareto(int number)
{

    int sum = 0;
    for (int i = 1; i <= number; i++)
    {
        sum += i * i;
    }

    return sum;
}

Console.WriteLine($"a soma dos quadrados de 1 até {number}  é igual a: " + SumSquareto(number));



