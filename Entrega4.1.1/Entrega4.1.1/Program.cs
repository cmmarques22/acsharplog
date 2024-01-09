
// variáveis
List<string> nomes = new List<string>
    { "Manel", "Maria", "Fernando", "Manel", "António", "Manel", "Fernando" };

List<string> existentes = new List<string>();
List<int> quantidades = new List<int>();






// percorrer cada elemento da lista «nomes»
// e se o nomes[i] não existir na lista «existentes»
// insere na lista existentes, senão ignora
for (int i = 0; i < nomes.Count; i++)
{
    if (Existe(existentes, nomes[i]) == false)
    {
        existentes.Add(nomes[i]);
    }
}


// percorrer cada elemento da lista «existentes»
// contar as repetições do existentes[i] na lista «nomes»
// e inserir a quantidade no «quantidades»

for (int i = 0; i < existentes.Count; i++)
{
    int quantidade;
    quantidade = ContaRepeticoes(nomes, existentes[i]);

    quantidades.Add(quantidade);
}

// mostrar os resultados
MostraResultados(existentes, quantidades);

static void MostraResultados(List<string> existentes, List<int> quantidades)
{
    for (int i = 0; i < existentes.Count; i++)
    {
        Console.WriteLine($"{existentes[i]} - {quantidades[i]}");
    }
}


static bool Existe(List<string> existentes, string nomeProcurar)
{

    bool repetido = false;

    for (int i = 0; i < existentes.Count; i++)
    {
        if (nomeProcurar == existentes[i])
            repetido = true;
        //break;
    }
    return repetido ? true : false;


    // percorrer cada elemento dos «existentes»
    // procurar se o «nomeProcurar» existe na lista
    // se existir devolver true, senão devolver false
}


static int ContaRepeticoes(List<string> nomes, string nomeProcurar)
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
