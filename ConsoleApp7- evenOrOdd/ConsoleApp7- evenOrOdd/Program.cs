using System;

Console.WriteLine(@"
=====================================
 Programa de calculo de par ou impar
Desenvolva uma aplicação que pergunte
ao utilizador 6 números e faça a soma,
apenas, dos números pares.
No final, apresente a soma dos pares.
=====================================");



// declaraçao variavaies
int input;
int somaDePares = 0;
int number = 0;

//recolha de numeros
Console.WriteLine("escreva 6 números aleatorios");


Console.Write(" 1º: ");
input = int.Parse(Console.ReadLine());

if( input % 2 == 0)
{
    somaDePares = somaDePares + input;
}
Console.Write(" 2º: ");
input = int.Parse(Console.ReadLine());

if (input % 2 == 0)
{
    somaDePares = somaDePares + input;
}
Console.Write(" 3º: ");
input = int.Parse(Console.ReadLine());

if (input % 2 == 0)
{
    somaDePares = somaDePares + input;
}
Console.Write(" 4º: ");
input = int.Parse(Console.ReadLine());

if (input % 2 == 0)
{
    somaDePares = somaDePares + input;
}
Console.Write(" 5º: ");
input = int.Parse(Console.ReadLine());

if (input % 2 == 0)
{
    somaDePares = somaDePares + input;
}
Console.Write(" 6º: ");
input = int.Parse(Console.ReadLine());
if (input % 2 == 0)
{
    somaDePares += input;
}

Console.WriteLine($" a soma de todos os numeros pares é de {somaDePares}");


