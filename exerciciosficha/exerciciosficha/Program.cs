
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
List<float> superiorMedia = SuperiorA(salariosLista, media);


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
        Console.WriteLine(superiorMedia[i]);
    }
    Console.WriteLine($"o salario superior a media: {superiorMedia}");

}
static List<float> RecolheCoisas()
{
    Console.WriteLine("insere salarios ('-1' para sair do loop):");
    float input = 0;
    List<float> numeros = new List<float>();
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

static List<float> SuperiorA(List<float> numeros, float valor)
{
    List<float> superiores = new List<float>();
    
   
    
    if (numeros.Count == 0)
        return superiores;
    for (int i = 0; i < numeros.Count; i++)
    {
        if (numeros[i] > valor)
        {
            superiores.Add(numeros[i]);
        }
    }

    return superiores;
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

    float media = Soma(numeros);

    return media / numeros.Count;

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
    switch (filtro)
    {
        
    }
}