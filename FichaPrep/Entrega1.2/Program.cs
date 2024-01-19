using Entrega1._2;

Console.WriteLine("Desenvolva um programa que receba um número indefinido " +
                  "de idades e que mostre na consola a quantidade de pessoas " +
                  "que 65\u2264\ud835\udc56\ud835\udc51\ud835\udc4e\ud835\udc51\ud835\udc52 <80, " +
                  "e a média dos que têm menos de 25 anos.");
                  
//variaveis
List<double> listaIdades = RecolheCoisas();

List<double> menores25 = FiltraLista(listaIdades,Filtro.InferiorA25, 25);
double mediaMenos25 = Media(menores25);
//quantidadeentre >= 60 e <80
List<double> Entre6080 = FiltraLista(listaIdades, Filtro.MaiorIgual65Menor80, listaIdades.Count());
List<double> entre60e80 = FiltraLista(listaIdades, Filtro.MaiorIgual65Menor80, 0);
ApresentaConsola();


List<double> RecolheCoisas()
{
    List<double> listaNumeros = new List<double>();
    double idade = 0;
    while (true)
    {
        Console.WriteLine("Insira idades");
        idade = double.Parse(Console.ReadLine());
        if (idade == -1)
        {
            break;
        }

        listaNumeros.Add(idade);
    }

    return listaNumeros;
}

 List<double> FiltraLsita(List<double > numeros, Filtro filtro, float valor)
{
    List<double> listraFiltrada = new();
    
    switch (filtro)
    {
        case Filtro.InferiorA25:
            for (int i = 0; i < numeros.Count; i++)
            {
                if (numeros[i] < valor)
                {
                    listraFiltrada.Add(numeros[i]);
                }
            }
            break;
        case Filtro.MaiorIgual65Menor80:
            for (int i = 0; i < numeros.Count; i++)
            {
                if (numeros[i] >= 65 && numeros[i] < 80)
                {
                    listraFiltrada.Add(numeros[i]);
                }
            }
            break;
        default:
            throw new ArgumentOutOfRangeException(nameof(filtro), filtro, "intervalo invalido");
    }

    return listraFiltrada;
}
static double Media(List<double> numeros)
{
    if (numeros.Count == 1)
    {
        return -1;
    }

    double soma = SomaTodasIdades(numeros);
    return soma / numeros.Count;
}
static double SomaTodasIdades(List<double> numeros)
{
    if (numeros.Count == 0)
        return -1;
    
    double soma = 0;

    for (int i = 0; i < numeros.Count; i++)
    {
        soma += numeros[i];
    }

    return soma;
}

static List<double> FiltraLista(List<double> lista, Filtro filtro, double valor)
{
    
    switch (filtro)
    {
        case Filtro.InferiorA25: 
            lista.Add(valor);
            break;
        case Filtro.MaiorIgual65Menor80:
            lista.Add(valor);;
            break;
        default:
            throw new ArgumentOutOfRangeException(nameof(filtro), filtro, "idade invalida");
    }
    
    return lista;
}



void ApresentaConsola() 
{
    Console.WriteLine($"a media de idades com menos de 25 é de {mediaMenos25}");
    Console.WriteLine($"a quantidade de pessoas com idade entre 65 r 80 anos é de {entre60e80.Count()}");

    for (int i = 0; i < entre60e80.Count; i++)
    {
        Console.WriteLine($"as idades sao{entre60e80[i]}");  
    }

    
}