// variaveis
int limite1, limite2, numero;
string userChoice ="";

//recolher da consola
Console.Write("qual o limite 1? : ");
limite1 = int.Parse(Console.ReadLine());

Console.Write("qual o limite 2? : ");
limite2 = int.Parse(Console.ReadLine());

Console.Write(@"pretende par ou impar?"
    + "digite E para escolher par "
    + "digite O para escolher impar ");

userChoice = Console.ReadLine();

//ficar em contador com o valor inicial de limite2
numero = limite1;

//ciclo para apresentar todos os pares entre [limite1, limite2]

// ciclo para apresentar ímpares
if (userChoice == "O")
{
    while (numero <= limite2)
    {
        if (numero % 2 != 0)
        {
            Console.WriteLine(numero);
        }
        numero++;
    }
}
numero = limite1;
// ciclo para apresentar pares
if (userChoice == "E")
{
    while (numero <= limite2)
    {
        if (numero % 2 == 0)
        {
            Console.WriteLine(numero);
        }
        numero++;
    }
}
