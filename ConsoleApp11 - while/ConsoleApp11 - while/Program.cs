// variaveis

float somaAlturaPredios = 0f, alturaMediaPredios, alturaPredio;
int contadorPredios = 0;


        //obter altura dos predios

Console.WriteLine("Insira a primeira altura do predio: ");
alturaPredio = int.Parse(Console.ReadLine());

while (alturaPredio > 0)
{
    somaAlturaPredios += alturaPredio;
    contadorPredios++;
    Console.WriteLine("Insira a proxima altura do predio: ");
    alturaPredio = int.Parse(Console.ReadLine());
}

//calculo da media
if ( contadorPredios > 0)
{
    alturaMediaPredios = somaAlturaPredios / (float)contadorPredios;

    //apresentar resultado
    Console.WriteLine($"da altura total dos predios é " +
        $"de {somaAlturaPredios}, " +
        $"a altura media dos predios é de  {alturaMediaPredios}");
}

//while (i < 5)
//{
//    Console.WriteLine("Insira a idade: ");
//    idade = int.Parse(Console.ReadLine());
//    soma += idade;
//    Console.WriteLine(i);
//    i++;
//}