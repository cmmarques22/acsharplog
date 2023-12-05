

//declaracao variaveis
int minimumValue;
int maximumValue;
string userChoice;

// Solicitar e ler o limite minimo
Console.Write("Digite o limite minimo: ");
minimumValue = int.Parse(Console.ReadLine());

// Solicitar e ler o limite maximo
Console.Write("Digite o limite maximo: ");
maximumValue = int.Parse(Console.ReadLine());

//apresentacao do programa
Console.WriteLine("Odd or Even: ");
Console.WriteLine("Write O for Odd");
Console.WriteLine("Write E for Even:");

userChoice = Console.ReadLine();

if (userChoice == "E")
{
    while (minimumValue <= maximumValue)
    {
        if (minimumValue % 2 == 0)
        {
            Console.WriteLine(minimumValue);
        }

        minimumValue++;
    }
}

else if (userChoice == "O")
{
    while (minimumValue <= maximumValue)
    {
        if (minimumValue % 2 != 0)
        {
            Console.WriteLine(minimumValue);
        }

        minimumValue++;
    }
}