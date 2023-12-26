Console.Write("Enter a number: ");
int input = int.Parse(Console.ReadLine());

int factorsCount = 0;
int numeroDivisores = 1;


int sumOfPrimes = 0;
int countOfPrimes = 0;



Console.WriteLine("Enter numbers in the range 100 to 200. Type 'exit' to finish.");

while (true)
{
    Console.Write("Enter a number: ");
    int input = int.Parse(Console.ReadLine());


    if (input.ToLower() == "exit")
    {
        break;
    }
    while (numeroDivisores <= input)
    {
        if (input % numeroDivisores == 0)
        {
            factorsCount++;
        }
        numeroDivisores++;
    }
    if (factorsCount > 2)
   {
       Console.WriteLine($"{input} is not prime");
   }

Console.WriteLine($"Number of factors of {input}: {factorsCount}");

Console.WriteLine($" {Soma(3, 4)}");
static int Soma(int a, int b)
{
    int c;
    c = a + b;
    return c;
}}