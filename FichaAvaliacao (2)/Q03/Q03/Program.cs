
Console.WriteLine("programa comparar nomes dos formandos repetidos");

//varaives, lista com nomes, lista com nomes unicos,, quantidade de repeticoes dos nomes
List<string> nomes = new List<string>() { "manel", "horacio", "maria", "orlando", "camane", "manel" };
List<string> unicos = new List<string>();




//1o loop para ver se existe
for (int i = 0; i < nomes.Count; i++)
{
    if (ExisteElemento(unicos, nomes[i]) == false)
        unicos.Add(nomes[i]);

}
// o metodo conta repetidos vai ser chamado dentro de um loop na main (para evitar usar nested loop)
//2o loop para verificar repetidos
List<int> quantidadeRepeticoes = new();
for (int i = 0; i < unicos.Count; i++)
{
    int quantidadeRepetidos = ContarRepeticoes(nomes, unicos[i]);
    quantidadeRepeticoes.Add(quantidadeRepetidos);

}

//apresentar resultados de ambas as listas
ApresentaResultados(unicos, quantidadeRepeticoes);

void ApresentaResultados(List<string> unicos, List<int> repetidos)
{
    for (int i = 0;i < unicos.Count; i++)
    {
        Console.WriteLine("o nome "+ unicos[i] +" é repetido " + repetidos[i]+ "x");
    }

}
//criar metodo para verificar se o nome existe na lista
static bool ExisteElemento(List<string> unicos2, string nomeProcurar)
{
    //ciclo para comparar string da lista
    bool repetido = false;

    //ciclo para compara elemento da lista
    for (int i = 0; i < unicos2.Count; i++)
    {
        if (nomeProcurar == unicos2[i])
            repetido = true;
    }
    return repetido ? true : false;
}

//criar metodo para depois contar repetidos em sentido inverso
static int ContarRepeticoes(List<string> nomeUnicos, string nomeComparar)
{
    //variaveis
    int numerorepeticoes = 0;

    //ciclo para comparar elemento da lsita com string, sera chamado dentro de um loop
    //cada iteracao ira ser igual com outro int
    for (int i = 0; i < nomeUnicos.Count; i++)
    {
        if (nomeUnicos[i] == nomeComparar)
        {
            numerorepeticoes++;
        }
    }
    return numerorepeticoes;
}




