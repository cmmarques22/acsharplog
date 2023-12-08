Console.WriteLine("teste numeros inteiros, filtrar media e primos");


Console.WriteLine("Insira um numero inteiro maior que 1");
int input = 0;
if (input < 2)
{
    Console.WriteLine("numero invalido, tente outra vez");
    input = int.Parse(Console.ReadLine());

}

int primeSum = 0;
int primeCounter = 0;


while (true)
{
    //verificar primo
    input = int.Parse(Console.ReadLine());
    
    if (input % 2 == 0)
    {

        //verificar intervalo
        if (input >= 100 && input <= 200)
        {
            //contar numeros primos
            primeCounter++;



            //fazer soma dos numeros no intervalo   
            primeSum += primeCounter;
            int primeAverage = primeSum / primeCounter;

        }
    }
    Console.WriteLine($"A soma é de {primeSum}");
    if (primeCounter > 0)
    {
        double primeAverage = (double)primeSum / primeCounter;
        Console.WriteLine($"A média de números primos é de {primeAverage}");
    }
    Console.WriteLine($" a soma é de {primeSum} ");

    // Pedir novo input
    Console.WriteLine("Insira outro número inteiro ou digite '0' para sair");
    input = int.Parse(Console.ReadLine());

    // Sair do loop se o input for 0
    if (input == 0)
    {
        break;
    }
}

