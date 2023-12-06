

Console.WriteLine("Quantos alunos entraram na oficina outra vez?");

int totalCars2 = int.Parse(Console.ReadLine());
int whiteCars2 = 0;
int carCounter = 0;

while (carCounter < totalCars2)
{
    Console.Write("Qual a cor do seu carro?: ");
    string carColor = Console.ReadLine();

    if (carColor == "white")
    {
        whiteCars2++;
    }

    carCounter++;
}
// Exiba os resultados
Console.WriteLine($"Quantidade total de carros: {totalCars2}");
Console.WriteLine($"Quantidade de carros brancos: {whiteCars2}");