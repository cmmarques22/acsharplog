using System.Numerics;

Console.WriteLine(@"
Crie uma aplicação que peça ao utilizador um conjunto
de alturas de pessoas, e apresente na consola quais as
alturas superiores à média.
");

//variaveis
List<double> ListaAlturas = RecolherAlturas();
List<double> listaAltSuperiorMedia = SuperioresMedia(ListaAlturas);
MostraLista(listaAltSuperiorMedia);

static void MostraLista(List<double> numeros)
{
    Console.WriteLine("Numeros superiores ou iguais a media: ");
    for (int i = 0; i < numeros.Count; i++)
    {
        Console.Write($"{numeros[i]}, ");
    }
}



static List<double> RecolherAlturas()
{
    List<double> listaAlturas = new List<double>();
    double numeroInserido;

    for (int i = 0; i < 3; i++)
    {
        Console.WriteLine("Insira altura: ");
        numeroInserido =  double.Parse(Console.ReadLine());
        listaAlturas.Add(numeroInserido);
    }
    return listaAlturas;
}

static List<double> SuperioresMedia(List<double> numeros)
{
    //variaves, criar lista temporaria para guardar numeros
    //guardar a media
    
    double media = Media(numeros);
    List<double> superioresMedia = new List<double>();

    // percorrer  pelos números e adiciona aqueles maiores ou
    // iguais à média à lista de resultados
    int i = 0;
    while (i < numeros.Count)
    {
        if (numeros[i] > media)
        {
            superioresMedia.Add(numeros[i]);
        }
        i++;
    }

    return superioresMedia;
}

static double Media(List<double> numeros)
{
    //variaveis
    double soma = Soma(numeros);

    if (numeros.Count == 0)
        return 0;
    //calcular media
    return soma /numeros.Count;

}

static double Soma(List<double> numeros)
{
    //variaveis
    
    double soma = 0;

    //percorrer lista e somar
    for (int i = 0; i < numeros.Count; i++)
    {
        soma += numeros[i];
    }
    //devolver resultado
    return soma;

}


