
using System.Security.Cryptography;

int totalCars = 0;
int whiteCars = 0;

Random random = new Random();
int carCounter = random.Next(1, 101);

Console.WriteLine("Contagem de Carros na Oficina");

Console.Write($"Entraram {carCounter} na oficina");

