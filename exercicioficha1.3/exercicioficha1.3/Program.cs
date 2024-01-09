using System.Net.Sockets;

Console.WriteLine("3)\nCrie uma aplicação que registe os números dos alunos" +
                  " à entrada da escola. A numeração dos alunos contém a" +
                  " indicação do ano de matrícula nos primeiros 2 dígitos " +
                  "(e.g. o aluno com o número 2200523 matriculou-se em 2022)." +
                  " Quando terminar a recolha, apresente na consola os" +
                  " dados abaixo:\na)\nUma tabela com a quantidade de alunos" +
                  " matriculados entre o ano \ud835\udc99 e o ano" +
                  " \ud835\udc9a.\nb)\nÚltimo aluno matriculado do ano \ud835\udc99.");

List<int> numeros = RecolheNumeros();
for (int i = 0; i < existentes.Count; i++)
{
    int quantidade;
    quantidade = ContaRepeticoes(numeros, existentes[i]);

    quantidades.Add(quantidade);
}
ContaRepeticoes2(numeros,)

static List<int> RecolheNumeros()
{
    Console.WriteLine("Digite os números ('-1' para sair do loop):");
    List<int> numeros = new List<int>();
    int input;
    while (true)
    {
        Console.WriteLine("Digite numeros:");
         input = int.Parse(Console.ReadLine());

        if (input == -1)
            break;
        
        numeros.Add(input);
    }
    return numeros;
}

static void ApresentaResultados(List<int> numeros)
{
    // for (int i = 0; i < numeros.Count; i++)
    // {
    //     if (numeros[i] )
    // }
    
}

//funcao para receber lista de numeros, filtrar por numeros de dois digitos e devolver lista
static List<double> ObterDoisDigitos(List<double> numeros)
{
    List<double> listaDigitos = new List<double>();
    int doisDigitos = 0;
    for (int i = 0; i < numeros.Count; i++)
    {
        doisDigitos = (int)numeros[i] / 100000;
        listaDigitos.Add(doisDigitos);

    }

    return listaDigitos;
}

static int ObterAnoMatricula(int numero)
{
    return numero / 10000; // Assume que os dois primeiros dígitos representam o ano
}

//funcao para contar numeros de anos, 22 = 1, 23 = 4
static int ContaRepeticoes2(List<int> anos,int anoPesquisar )
{
    int quantidade = 0;
     
    // percorrer cada elemento da lista nomes
    for (int i = 0; i < anos.Count; i++)
    {
        if (anos[i] == anoPesquisar)
            quantidade++;
    }

    return quantidade;
    // contar os nomes «nomeProcurar»
    // devolver a quantidade de repetições de «nomeProcurar»
}





List<int> existentes = new List<int>();
List<int> quantidades = new List<int>();

for (int i = 0; i < numeros.Count; i++)
{
    if (Existe(existentes, numeros[i]) == false)
    {
        existentes.Add(numeros[i]);
    }
}

for (int i = 0; i < existentes.Count; i++)
{
    int quantidade;
    quantidade = ContaRepeticoes(numeros, existentes[i]);

    quantidades.Add(quantidade);
}
MostraResultados(existentes, quantidades);

static void MostraResultados(List<int> existentes, List<int> quantidades)
{
    for (int i = 0; i < existentes.Count; i++)
    {
        Console.WriteLine($"{existentes[i]} - {quantidades[i]}");
    }
}
static bool Existe(List<int> existentes, int anoProcurar)
{

    bool repetido = false;

    for (int i = 0; i < existentes.Count; i++)
    {
        if (anoProcurar == existentes[i])
            repetido = true;
        //break;
    }
    return repetido ? true : false;


    // percorrer cada elemento dos «existentes»
    // procurar se o «nomeProcurar» existe na lista
    // se existir devolver true, senão devolver false
}


static int ContaRepeticoes(List<int> nomes, int nomeProcurar)
{
    int quantidade = 0;

    // percorrer cada elemento da lista nomes
    for (int i = 0; i < nomes.Count; i++)
    {
        if (nomes[i] == nomeProcurar)
            quantidade++;
    }

    return quantidade;
    // contar os nomes «nomeProcurar»
    // devolver a quantidade de repetições de «nomeProcurar»
}


// static int ContadorNumerosUnicos(List<double> numeros)
// {
//     
//     
//     int contador = 0;
//     for (int i = 0; i < numeros.Count; i++)
//     {
//         
//     }
// }

