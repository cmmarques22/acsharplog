


Console.WriteLine(@"
Crie uma aplicação que calcule a média de consumo de um carro.
Peça as variáveis necessárias ao utilizador e apresente na consola o consumo do carro a cada 100km.
");


//apresentar programa
Console.WriteLine("=====================================");
Console.WriteLine("Programa de altura media de consumo de combustivel");
Console.WriteLine("=====================================");



//declaraçao das variaveis
double quantidadeDeposito;
double totalKM;


//recolha das variaveis
Console.Write("Quantos quilometros consegue percorrer com um depósito cheio?: ");
totalKM = int.Parse(Console.ReadLine());


Console.Write("Quantos litros tem o depóstito do seu carro?: ");
quantidadeDeposito = double.Parse(Console.ReadLine());


//calculo da media
double consumoMedio = (quantidadeDeposito  /  totalKM) * 100;

Console.WriteLine($" O consumo médio do seu carro é de {consumoMedio}");



