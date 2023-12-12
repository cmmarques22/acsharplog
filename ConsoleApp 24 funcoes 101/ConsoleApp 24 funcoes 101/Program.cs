
//Console.WriteLine("Insert digit to check for primality");
////variaveis e guardar o retorno
//int input = int.Parse(Console.ReadLine());

////guardar o numero de divisores
//int number = QtdDivisores(input);

////guardar o resultado do boleano




//MostraPrimos(1, 1000);
//QtdDivisores(3);
//PrimeChecker(2);

static int QtdDivisores(int numero)
{
    int numdivisors = 0;

    for (int i = 1; i <= numero; i++)
    {
        if (numero % i == 0)
        {
            numdivisors++;
        }
    }
    return numdivisors;
}

static bool PrimeChecker(int number)
{

    if (QtdDivisores(number) == 2)
    {
        return true;
    }
    else
    {
        return false;
    }
}

Console.WriteLine("From: ");
int from = int.Parse(Console.ReadLine());
Console.WriteLine("To: ");
int to = int.Parse(Console.ReadLine());
static void MostraPrimos(int from, int to)
{

    //while (from <= to)
    //{
    //    if (PrimeChecker(from) == true)
    //    {
    //        Console.WriteLine($"{from} is prime");
    //    }
    //    from++;
    //}

    //for loop
    //for (int i = from; i <= to; i++)


    for (int i = from; i <= to; i++)
    {
        if (PrimeChecker(i) == true)
        {
            Console.WriteLine($"{i} is prime");
        }
        //else
        //{
        //    Console.WriteLine($"{i} not not a prime number");
        //}
    }
}


