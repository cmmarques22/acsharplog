// See https://aka.ms/new-console-template for more information
Console.WriteLine("2)\nCrie uma aplicação que calcule os primos de um intervalo" +
                  " definido pelo utilizador, e apresente os seguintes dados na" +
                  " consola:\na)\nMédia dos quadrados dos primos;\nb)\nSoma dos" +
                  " quadrados dos primos;");

int intervaloMinimo = 0;
int intervaloMaximo = 0;

List<int> numeros = RecolheCoisas(intervaloMinimo,intervaloMaximo);
List<int> listaPrimos = ListarPrimos(numeros);
List<int> quadradoPrimos = ObterQuadradoLista(listaPrimos);
float somaQuadrados = Soma(quadradoPrimos);
float mediaQuadrados = Media(quadradoPrimos);

Console.WriteLine($"a soma do quadrado dos primos é de {somaQuadrados}");
Console.WriteLine($"a media do quadrado dos primos é de {mediaQuadrados}");






//metodo para receber lista de numeros, utilizar uma soma, fazer media de 
static float Media(List<int> numeros)
{
    if (numeros.Count == 0)
        return -1;
    float media = Soma(numeros);

    return media / numeros.Count;
}

//metodo para receber lista de numeros, somar todos os numeros e devolver
static float Soma(List<int> numeros)
{
    if (numeros.Count == 0)
        return -1;

    float soma = 0;
    for (int i = 0; i < numeros.Count; i++)
    {
        soma += numeros[i];
    }
    return soma;
}


//metodo para receber lista de numeros, criar lista temp, fazer o quadrado de cada elemento e devolver
static List<int> ObterQuadradoLista(List<int> numeros)
{
    List<int> listaTempQuadrado = new List<int>();
    for (int i = 0; i < numeros.Count; i++)
    {
        listaTempQuadrado.Add(numeros[i]*2);
    }

    return listaTempQuadrado;
}
//filtrar crair lista temp. filtrar primos, e devolver lista so de primos
static List<int> ListarPrimos(List<int> numeros)
{
    List<int> listaPrimos = new List<int>();
    for (int i = 0; i < numeros.Count; i++)
    {
        if (IsPrime(numeros[i]))
        {
            listaPrimos.Add(numeros[i]);  
        }
    }

    return listaPrimos;
}








static List<int> RecolheCoisas( int minimo, int maximo)
{
    Console.WriteLine("insira digitos('-1' para sair do loop):");
    List<int> coisas = new List<int>();
    
    while (true)
    {
        //continuar a pedir input ao utilizador
         
         Console.WriteLine("digite o numero minimo do intervalo");
         minimo = int.Parse(Console.ReadLine());
         Console.WriteLine("digite o numero maximo do intervalo");
         maximo = int.Parse(Console.ReadLine());
        
        break;
    }

    for (int i = minimo; i <= maximo; i++)
    {
        coisas.Add(i);
    }

    return coisas;
}

static bool IsPrime(int number)
{
    // Verificar se o número é menor que 2, caso contrário, não é primo
    if (number < 2)
    {
        return false;
    }
    int numeroDivisores = 2;
    // Verificar divisibilidade até a raiz quadrada do número
    while (numeroDivisores * numeroDivisores <= number)
    {
        if (number % numeroDivisores == 0)
        {
            return false;
        }
        numeroDivisores++;
    }
    return true;
}