Console.WriteLine("Desenvolva aplicacao que receba numero indefinido de preços. aprensenta na consola");


//variaveis
List<double> listaPrecos = new List<double>() { 1, 5, 7, 10, 12, 13, 15, 20 };
List<double> preçosSuperioresMedia = SuperiorA(listaPrecos);

//atribuir resultados
double soma = Somatorio(listaPrecos);
double media = Media(listaPrecos);
double max = Max(listaPrecos);
double min = Min(listaPrecos);
double amplitude = Amplitude(listaPrecos);

//apresentar resultados
ApresentacaoResultados();

void ApresentacaoResultados()
{
    Console.WriteLine(" os preços  previamente introduzidos foram o ");
    for (int i = 0; i < listaPrecos.Count; i++)
    {
        Console.WriteLine(listaPrecos[i]);
    }
    Console.WriteLine("A amplitude dos preços é de: " + amplitude);
    Console.WriteLine("Preco mais baixo: " + min);
    Console.WriteLine("Preco mais baixo: " + min);
    Console.WriteLine("A media dos precos é de " + media);
    Console.WriteLine("A soma de todos os precos é de : " + soma);
    Console.WriteLine("Os preços superiores a media sao: ");
    for (int i = 0; i < preçosSuperioresMedia.Count; i++)
    {
        Console.WriteLine(preçosSuperioresMedia[i]);
    }
}
static List<double> SuperiorA(List<double> numeros)
{
    //variaveis
    List<double> superiorMedia = new();
    double media = Media(numeros);
    //ciclo percorrer lista
    for (int i = 0; i < numeros.Count; i++)
    {
        //verificacao de valor e insercao em lista
        if (numeros[i] > media)
            superiorMedia.Add(numeros[i]);
    }
    return superiorMedia;
}
static double Amplitude(List<double> numeros)
{
    //se lista for vazia
    if (numeros.Count == 0)
        return -1;

    //variaveis
    double max = Max(numeros);
    double min = Min(numeros);
    //double amplitude = Max(numeros)-Min(numeros);

    //retorno de resultado
    return max - min;
}
static double Min(List<double> numeros)
{
    //programacao defensiva
    if (numeros.Count == 0)
        return -1;

    //variaveis, se igualsse a zero seria esse o minimo
    double minimo = numeros[0];
    for (int i = 0; i < numeros.Count; i++)
    {
        //verificacao e atualizacao do valor
        if (numeros[i] < minimo)
            minimo = numeros[i];
    }
    return minimo;
}
static double Max(List<double> numeros)
{
    //controlo
    if (numeros.Count == 0)
        return -1;
    //variaveis
    double maximo = 0;

    //ciclo para verificar valores e atualizar maximo
    for (int i = 0; i < numeros.Count; i++)
    {
        if (numeros[i] > maximo)
            maximo = numeros[i];
    }
    return maximo;
}
static double Media(List<double> numeros)
{
    //variaveis e atribucao de valor
    double soma = Somatorio(numeros);

    //calculo e retorno da media
    return soma / numeros.Count;
}
static double Somatorio(List<double> numeros)
{
    //controlo de lista vaiza
    if (numeros.Count == 0)
        return -1;
    //variaveis
    double somatorio = 0;

    //ciclo para atribuir e soma
    for (int i = 0; i < numeros.Count; i++)
    {
        somatorio += numeros[i];
    }
    return somatorio;
}