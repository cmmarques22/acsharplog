Console.WriteLine("=====================================");
Console.WriteLine("===Programa de calculo de idades=====");
Console.WriteLine("=====================================");

//variaveis
int listSize;
int sixtyEightyageCounter = 0;
int ageLessThen25 = 0;
double sumAge25 = 0;
List<int> ageList = new List<int>();
Console.WriteLine("Quantas idades vai inserir?");

//tamanho do loop/lista
listSize = int.Parse(Console.ReadLine());



//programa 
for (int i = 0; i < listSize; i++)
{
    Console.WriteLine("Digite as idades (digite um valor negativo para encerrar):");
    int input = int.Parse(Console.ReadLine());

    if (input < 0)
    {
        Console.WriteLine("Programa terminado");
        break;
    }
    
    ageList.Add(input);

    if (input >= 65 && input < 80)
    {
        sixtyEightyageCounter++;
    }
    else if (input < 25)
    {
        ageLessThen25++;
        ageLessThen25 += input;
    }
}
//calculo da média
double averageAge25 = CalcularMediaIdadeMenos25(ageLessThen25, ageLessThen25);

//apresentacao de resultados
Console.WriteLine($"Pessoas com idade entre 65 e 80: {sixtyEightyageCounter}");
Console.WriteLine($"Média de idade com menos de 25 anos: {averageAge25}");


static double CalcularMediaIdadeMenos25(int ageCounter, double ageSum)
{
    if (ageCounter > 0)
    {
        return ageSum / ageCounter;
    }
    else
    {
        return 0;
    }
}
