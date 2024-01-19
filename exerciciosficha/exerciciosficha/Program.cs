
using exerciciosficha;

Console.WriteLine("1)\r\nDesenvolva uma aplicação que receba um número indefinido de" +
                  " salários. Apresente na consola as seguintes informações:" +
                  "\r\na)\r\nQuais os salários superiores à média.\r\nb)\r\n" +
                  "O salário mais alto.\r\nc)\r\nO salário mais baixo.\r\nd)\r\n" +
                  "A média dos salários.\r\ne)\r\nA soma de todos os salários.\r\nf)\r\n" +
                  "A amplitude dos salários (diferença entre o salário mais alto e " +
                  "o mais baixo).");

//2 liastas para guardar resultados
List<float> salariosLista = RecolheCoisas();
float media = Media(salariosLista);
List<float> superiorMedia = FiltraLista(salariosLista,Filtro.SuperioresA, media);
int[] idades = new int[5] {1,3,4,5, 2};
for (int i = 0; i < idades.Length; i++)
{
    if (idades[i] == 3)
    {

    }
    {
        
    } 
}

float somaSalarios = Soma(salariosLista);
float mediaSalarios = Media(salariosLista);
float salarioMaximo = Max(salariosLista);
float salarioMinimo = Min(salariosLista);
float amplitudeSalarial = Amplitude(salariosLista);



ApresentacaoResultados();
void ApresentacaoResultados()
{
    Console.WriteLine($"a soma dos salarios é de: {somaSalarios}");
    Console.WriteLine($"a media dos salarios é de: {mediaSalarios}");
    Console.WriteLine($"o salario mais alto é de: {salarioMaximo}");
    Console.WriteLine($"o salario mais baixo é de: {salarioMinimo}");
    Console.WriteLine($"a amplitude salarial é de: {amplitudeSalarial}");
    Console.WriteLine("os salarios superiores a media sao o:");
    for (int i = 0; i < superiorMedia.Count; i++)
    {
        Console.WriteLine($"os salarios superior a media: {superiorMedia[i]}");
    }

}
static List<float> RecolheCoisas()
{
    Console.WriteLine("insere salarios ('-1' para sair do loop):");
    float input;
    List<float> numeros = new ();
    while (true)
    {
        //continuar a pedir input ao utilizador
         input = float.Parse(Console.ReadLine());

        if (input  == -1)
            break;

        numeros.Add(input);
    }

    return numeros;
}


static float Amplitude(List<float> numeros)
{
    float maximo = Max(numeros), minimo = Min(numeros);
    return maximo - minimo;
}

static float Max(List<float> numeros)
{
    if (numeros.Count == 0)
        return -1;
    float max = numeros[0];
    for (int i = 1; i < numeros.Count; i++)
    {
        if (numeros[i] > max)
            max = numeros[i];
    }

    return max;
}
static float Min(List<float> numeros)
{
    if (numeros.Count == 0)
        return -1;
    float min = numeros[0];
    for (int i = 1; i < numeros.Count; i++)
    {
        if (numeros[i] < min)
            min = numeros[i];
    }

    return min;
}

static float Media(List<float> numeros)
{
    if (numeros.Count == 0)
        return -1;

    float soma = Soma(numeros);

    return soma / numeros.Count;

}

static float Soma(List<float> numeros)
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

static List<float> FiltraLista(List<float> lista, Filtro filtro, float valor)
{

    List<float> filtrados = new();

    switch (filtro)
    {
        case Filtro.SuperioresA:
            for (int i = 0; i < lista.Count; i++)
            {
                if (lista[i] > valor)
                {
                    filtrados.Add(lista[i]);
                }
            }
            break;
        case Filtro.IgualOuSuperioresA:
            for (int i = 0; i < lista.Count; i++)
            {
                if (lista[i] >= valor)
                {
                    filtrados.Add(lista[i]);
                }
            }
            break;
        case Filtro.InferioresA:
            for (int i = 0; i < lista.Count; i++)
            {
                if (lista[i] < valor)
                {
                    filtrados.Add(lista[i]);
                }
            }
            break;
        case Filtro.IgualOuInferioresA:
            for (int i = 0; i < lista.Count; i++)
            {
                if (lista[i] <= valor)
                {
                    filtrados.Add(lista[i]);
                }
            }
            break;
        default:
            throw new ArgumentOutOfRangeException(nameof(filtro), filtro, "Opção inválida");
    }

    return filtrados;

}