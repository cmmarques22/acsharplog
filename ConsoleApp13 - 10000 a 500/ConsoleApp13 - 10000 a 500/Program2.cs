//declaracao variaveis
int limiteMinimo;
int limiteMaximo2;

// Solicitar e ler o limite minimo
Console.Write("Digite o limite minimo: ");
limiteMinimo = int.Parse(Console.ReadLine());

// Solicitar e ler o limite maximo
Console.Write("Digite o limite maximo: ");
limiteMaximo2 = int.Parse(Console.ReadLine());

while (limiteMaximo2 > limiteMinimo )
{
    limiteMaximo2--;
    Console.WriteLine(limiteMaximo2);
}