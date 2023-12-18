//recolher 10num do utilizador
//calocular media
// apresentar os numeros superiores a media


List<int> numeros = new List<int>();

numeros.Add(12);
numeros.Add(18);
numeros.Add(60);
numeros.Add(20);

Console.WriteLine($"posiçao 1 do conjunto: {numeros[1]}");
Console.WriteLine($"posiçao 1 do conjunto: {numeros[1]}");
Console.WriteLine($"posiçao 2 do conjunto: {numeros[2]}");

numeros.Remove(18);

for (int i = 0; i < numeros.Count; i++)
{
    Console.WriteLine(numeros[i]);
}

Console.WriteLine("Fim");