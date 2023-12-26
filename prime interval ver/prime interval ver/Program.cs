Console.WriteLine(@"
Crie uma aplicação que peça 2 limites ao utilizador 
e que some o valor dos primos existentes dentro desse 
intervalo. Essa soma só deverá ser apresentada na consola
se o valor for divisível por 3. Caso não seja divisível, 
deve apresentar o texto 'soma dos primos não divisível 
por 3'.
");

//variaveis
int limiteMinimo;
int limiteMaximo;

Console.WriteLine("Insira o valor máximo do intervalo");
limiteMaximo = int.Parse(Console.ReadLine());
Console.WriteLine("Insira o valor mínimo do intervalo");
limiteMinimo = int.Parse(Console.ReadLine());
int primeSum = 0;

for (int i = limiteMinimo; i <= limiteMaximo; i++)
{
    if (IsPrime(i))
    {
        primeSum += i;
    }
}

// Chamar a função para verificar se a soma é divisível por 3
SumVerifier(primeSum);

Console.WriteLine($"A soma total dos primos é: {primeSum}");

static void SumVerifier(int num)
{
    // Verificar se a soma é divisível por 3 e imprimir mensagem apropriada
    if (num % 3 == 0)
    {
        Console.WriteLine($"{num} é divisível por 3.");
    }
    else
    {
        Console.WriteLine($"{num} não é divisível por 3.");
    }
}

static bool IsPrime(int number)
{
    // Verificar se o número é menor que 2, caso contrário, não é primo
    if (number < 2)
    {
        return false;
    }

    int numeroDivisores = 2;

    // Verificar divisibilidade até a raiz quadrada do número
    while (numeroDivisores * numeroDivisores <= number)
    {
        if (number % numeroDivisores == 0)
        {
            return false;
        }

        numeroDivisores++;
    }

    return true;
}
