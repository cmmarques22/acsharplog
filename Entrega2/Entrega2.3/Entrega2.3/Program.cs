Console.WriteLine(@"
ENTREGA 2 -. Crie uma aplicação que some os dígitos de
um número inteiro fornecido pelo utilizador. Por exemplo,
se o número for 483, o valor a apresentar será o resultado
de 4 + 8 + 3 = 15. Dica: note que o resto da divisão por
10 permite aceder ao último dígito de um número inteiro 
(e.g., 483 % 10 = 3).
");

//variables
int input;

//data fetch
Console.WriteLine("Enter an integer");
input = int.Parse(Console.ReadLine());

//call the sum of digits method
int sum = SumDigits(input);

//display the result
Console.WriteLine($"Sum of the inserted digits is: {sum}");

static int SumDigits(int n)
{
    int sum = 0;

    //iterate until no digits are left
    while (n > 0)
    {
        //find the last digit
        int digit = n % 10;

        //accumulate the last digit
        sum += digit;

        //"remove" the last digit
        n = n / 10;
    }
    return sum;
}
