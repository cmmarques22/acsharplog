// variáveis
List<int> numeros = new List<int>();
List<int> numerosSuperioresMedia = new List<int>(); 
int numeroInserido;

// recolher 10 numeros
for (int i = 0; i < 10; i++)
{
    // pedir o número
    Console.Write("Insira um número: ");
    numeroInserido = int.Parse(Console.ReadLine());

    // acrescentar o número à lista
    numeros.Add(numeroInserido);
}

// calcular a media dos 10 numeros 
numerosSuperioresMedia = SuperioresMedia(numeros);

// apresentar os numeros superiores à media
MostraNumeros(numerosSuperioresMedia);



static void MostraNumeros(List<int> numeros)
{
    for (int i = 0;i < numeros.Count;i++)
    {
        Console.Write($"{numeros[i] }, ");
    }
}

static List<int> SuperioresMedia(List<int> numeros)
{
    // variáveis
    float media;
    List<int> superioresMedia = new List<int>();

    // calcula a média
    media = Media(numeros);
    float media2 = Media(numeros);

    // cria a lista com os números superiores à media
    for (int i = 0; i < numeros.Count; i++)
        if (numeros[i] > media)
            superioresMedia.Add(numeros[i]);
    // devolve a lista com os superiores à media
    return superioresMedia;
}


static float Media(List<int> numeros)
{
    // variáveis
    int soma;

    // a média de zero elementos é zero
    if (numeros.Count == 0)
        return 0;

    // somar todos os numeros (prateleiras)
    soma = Soma(numeros);   

    // devolver a média
    return soma / (float)numeros.Count;
}

static int Soma(List<int> numeros)
{
    // variáveis
    int soma = 0;

    // percorrer todos os elementos e acumular em soma
    for (int i = 0; i < numeros.Count; i++)
    {
        soma += numeros[i];
    }

    // devolve a soma
    return soma;
}