Console.WriteLine(@"
ENTREGA 2 -. Desenvolva uma aplicação que conte a quantidade
de números ímpares gerados de forma aleatória num lote de 1000. 
Utilize uma string para concatenar todos os números que foram
considerados na contagem.
");

//variaveis
int oddNumberCounter = 0;

List<int> numbersList = new List<int>();
Random random = new Random();
string oddContacNumbers = "";

//Recolha de dados
Console.Write("How many random numbers do you want? ");
int numberGenerator = int.Parse(Console.ReadLine());
Console.Write("Enter a number to choose the range of generated numbers from 1 to:  ");
int randomInterval = int.Parse(Console.ReadLine());


//execucao programa
//for loop para percorrer intervalo de 1 a 1000

for (int i = 0; i <= numberGenerator; i++)
{
    //dois argumentos para min e max value
    //segundo argumento nao é inclusivo, usar +1

    int randomNumber = random.Next(1, (randomInterval + 1));
    //adicionar a lista
    numbersList.Add(randomNumber);

    if (randomNumber % 2 != 0)
    {
        oddNumberCounter++;
        //concatenar string
        oddContacNumbers += " " + randomNumber;
    }
}
//display data in list
Console.WriteLine("Numbers generated are:");
for (int i = 0; i < numbersList.Count; i++)
{
    Console.Write(numbersList[i] + " ");
}

//display data with concatenation
//Console.WriteLine($"\nProvide data by concatenation");
Console.WriteLine($"\n{numberGenerator} were generated, {oddNumberCounter} are odd numbers" +
                  $"\nThe odd numbers are: {oddContacNumbers}");


