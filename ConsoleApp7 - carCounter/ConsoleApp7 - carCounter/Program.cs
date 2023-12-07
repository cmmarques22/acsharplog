
using System.Security.Cryptography;

Console.WriteLine("Contagem de Carros na Oficina");

//int totalCars;
//int whiteCars;
//Console.WriteLine("Quantos carros entraram na oficina?");
//Random random = new Random();
//Random random2 = new Random();


//totalCars = random.Next(1, int.Parse(Console.ReadLine()));
//whiteCars = random2.Next(1, totalCars);


//Console.WriteLine($"Entraram {totalCars} na oficina, {whiteCars} eram brancos");

//Console.WriteLine("Quantos carros entraram na oficina outra vez?");

//int totalCars2 = int.Parse(Console.ReadLine());
int whiteCars = 0;
int carCounter = 0;
bool permitidaEntrada = true;

//Console.WriteLine("Pode entrar carros? (true/false): ");
//carEntry = bool.Parse(Console.ReadLine());

while (permitidaEntrada)
{
    Console.WriteLine("Pode entrar carros? (true/false): ");
    permitidaEntrada = bool.Parse(Console.ReadLine()); 
    string resposta = Console.ReadLine();

    if (resposta == "nao")
    {
        permitidaEntrada = false;}

    if (permitidaEntrada)
    {
        // Se um carro vai entrar, perguntar a cor
        Console.Write("Qual a cor do seu carro?: ");
        string carColor = Console.ReadLine();

        // Verificar se o carro é branco e incrementar o contador correspondente
        if (carColor.ToLower() == "white")
        {
            whiteCars++;
        }

        // Incrementar o contador total
        carCounter++;
    }
}

// Exibir resultados
Console.WriteLine($"Quantidade total de carros: {carCounter}");
Console.WriteLine($"Quantidade de carros brancos: {whiteCars}");