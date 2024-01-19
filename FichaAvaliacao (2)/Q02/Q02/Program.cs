
Console.WriteLine("Programa de calculo de intervalos de primos dentro de um intervalo");


//variveis e atribuicao de resultados
List<int> listNumeros = RecolheNumeros();
List<int> listaPrimos = ListaPrimos(listNumeros);
List<int> listaPrimosCubo = NumerosAoCubo(listaPrimos);
double media = Media(listaPrimosCubo);
int soma = Soma(listaPrimosCubo);

//apresentar resultados
ApresentacaoResultados();



void ApresentacaoResultados(){
    Console.WriteLine($"a media dos cubos dos primos é de: " + media);
    Console.WriteLine($"a soma dos cubos dos primos é de : " + soma);
}

static List<int> NumerosAoCubo(List<int> numeros)
{
    //controlo
    if(numeros.Count == 0) 
        return numeros;
    
    //variaveis
    List<int> numeroCubo = new List<int>();
    
    //ciclo para percorrer lista e adicionar o cubo de cada elemento
    for (int i = 0;i < numeros.Count; i++)
    {
        numeroCubo.Add(numeros[i]* numeros[i] * numeros[i]);
    }

    //devoler lista de cubos
    return numeroCubo;
}
static int Soma(List<int> numeros)
{
    //controlo
    if (numeros.Count == 0)
    {
        return -1;
    }

    //variaveis
    int soma = 0;

    //ciclo para incrementar soma
    for (int i = 0; i< numeros.Count; i++)
    {
        soma += numeros[i];
    }
    return soma;
}
static double Media(List<int> numeros)
{
    //variaveis
    int soma = Soma(numeros);

    //devolver media
    return soma / numeros.Count;
}
List<int> ListaPrimos(List<int> numeros)
{
    //variaveis
    List<int> listaPrimos = new List<int>();
    
    //ciclo para verificar se elemento de numeros é primo e adicionar a lista nova
    for (int i = 0; i < numeros.Count; i++)
    {
        if (ePrimo(numeros[i]))
        {
            listaPrimos.Add(numeros[i]);
        }
    }
    return listaPrimos;
}
List<int> RecolheNumeros()
{
    List<int> numeros = new();
    Console.WriteLine("introduza um numero minimo para definicao do intervalo");
    int minimo = int.Parse(Console.ReadLine());
    Console.WriteLine("intruduza um numero maxima para definicao do intervalo");
    int maximo = int.Parse(Console.ReadLine());

    for (int i = minimo; i <= maximo; i++)
    {
        numeros.Add(i);
    }
    return numeros;
}
static bool ePrimo(int number)
{
    // Verificar se o número é menor que 2, caso contrário, não é primo
    if (number < 2)
    {
        return false;
    }
    return QtdDivisores(number) == 2;
}
static int QtdDivisores(int numero)
{
    //variaveis
    int contador = 0;

    //percorer [2 ate numero-1]
    for (int i = 2; i < numero - 1; i++)
    {
        if (numero % i == 0)
        {
            contador++;
        }
    }
    //devolver quantidade
    return contador + 2;
}

