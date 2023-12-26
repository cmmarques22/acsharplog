
//variaveis
List<int> numeros = RecolherNumeros();

List<int> superioresAMedia = SuperioresMedia(numeros);


Console.WriteLine("Numeros superiores ou iguais a media: ");
for (int i = 0; i < superioresAMedia.Count; i++)
{
    Console.Write(superioresAMedia[i]+ ", ");
}

//funcoes
static List<int> RecolherNumeros()
{
    List<int> listaNumeros = new List<int>();

    for (int i = 0; i < 10; i++)
    {
        Console.WriteLine("Insira numeros");
        int numeroInserido = int.Parse(Console.ReadLine());
        listaNumeros.Add(numeroInserido);
    }
    return listaNumeros;
}


static List<int> SuperioresMedia(List<int> numeros)
{
    //variaves, criar lista temporaria para guardar numeros
    float media;
    List<int> superioresAMedia = new List<int>();

    //guardar a media
    media = Media(numeros);

    // percorrer  pelos números e adiciona aqueles maiores ou
    // iguais à média à lista de resultados
    for (int i = 0; i < numeros.Count; i++)
    {
        if (numeros[i] >= media)
        {
            superioresAMedia.Add(numeros[i]);
        }
    }

    return superioresAMedia;
}

static float Media(List<int> numeros)
{
    //variaveis
    int soma = Soma(numeros);
    float media = 0;
    //calcular media
    media = (float)soma / numeros.Count;
    return media;
}


static int Soma(List<int> numeros)
{
    //variaveis
    int soma = 0;
    //percorrer a lista de numeros, e somar e guardar
    for (int i = 0; i < numeros.Count; i++)
    {
        soma += numeros[i];
    }

    //devolver a soma
    return soma;
}


