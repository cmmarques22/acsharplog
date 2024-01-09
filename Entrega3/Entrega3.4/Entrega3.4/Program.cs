Console.WriteLine(@"Crie uma aplicação que peça as idades
de todos os formandos do UpSkill e apresente na
consola a média, máximo, mínimo e soma de todas as idades.");

//variaveis
double mediaIdade;
int minIdade;
int maxIdade;
int soma;

Console.WriteLine("insira  15 idades:");
List<int> idades = RecolherIdades();

//guardar a soma
soma = Soma(idades);
//guardar a media
mediaIdade = Media(idades);
//guardar idade minima
minIdade = Min(idades);
//guardar idade maxima
maxIdade = Max(idades);


Console.WriteLine(@$"
a soma de todas as idades é de {soma}
a idade minima é de {minIdade}
a idade maxima é de {maxIdade}
a media de idades é de {mediaIdade}"); 
static List<int> RecolherIdades()
{
    List<int> listaIdades = new List<int>();
    for (int i = 0; i < 15; i++)
    {
        int idade = int.Parse(Console.ReadLine());
        listaIdades.Add(idade);
    }

    return listaIdades;
}

static int Max(List<int> numeros)
{
    //numeros.Sort();
    //numeros.count -1 para aceder ao ultimo numero
    //return numeros[numeros.Count - 1];
    int intMaior;

    if (numeros.Count == 0)
        {return -1}

    intMaior = numeros[0];

    for (int i = 1; i < numeros.Count; i++)
    {
        if (numeros[i] > intMaior)
            intMaior = numeros[i];
    }

    return intMaior;
}
static int Min(List<int> numeros)
{
    //numeros.Sort();
    //return numeros[0];

    int intMenor = numeros[0];
    for (int i = 1; i < numeros.Count; i++)
    {
        if (numeros[i] < intMenor)
        {
        intMenor = numeros[i];
        }
    }

    return intMenor;

}
static double Media(List<int> numeros)
{
    double soma;
    
    if(numeros.Count == 0)
        return 0;
    
    //variaveis
    double soma = Soma(numeros);


    //calcular e devolver media
    return (double)soma / numeros.Count;
}
static int Soma(List<int> numeros)
{
    if (numeros.Count == 0)
        return -1;
    
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

