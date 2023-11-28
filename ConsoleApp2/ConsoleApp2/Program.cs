// See https://aka.ms/new-console-template for more information



// variaveis
float alturaPredio1, alturaPredio2, alturaPredio3;
float mediaPredios;


//apresentar programa
Console.WriteLine("=====================================");
Console.WriteLine("Programa de altura media de predios");
Console.WriteLine("=====================================");


//Obter altura predios


alturaPredio1 = float.Parse(Console.ReadLine());
alturaPredio2 = float.Parse(Console.ReadLine());
alturaPredio3 = float.Parse(Console.ReadLine());


// calculo media
mediaPredios = (alturaPredio1 + alturaPredio2 + alturaPredio3) / 3;


//apresentacao media
Console.WriteLine($"{alturaPredio1}, {alturaPredio2}, {alturaPredio3} da uma media de {mediaPredios} ");




//verificar media

if (mediaPredios >= 10)
{
    Console.WriteLine("a altura media dos predios é maior ou igual a 10");
}
else
{
    Console.WriteLine("a altura media dos predios media menor que 10");
}


mediaPredio(10,10,11);
Console.WriteLine("the end");


