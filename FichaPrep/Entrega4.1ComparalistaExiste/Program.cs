List<string> nomes = new() { "Manel", "Maria", "Fernando", "Manel", "António", "Manel", "Fernando" };
List<string> nomesUnicos = new();
List<int> quantidades = new();
// percorrer cada elemento da lista «nomes»
// e se o nomes[i] não existir na lista «existentes»
// insere na lista existentes, senão ignora
for (int i = 0; i < nomes.Count; i++)
{
    if (Existe(nomesUnicos,nomes[i]) == false)
        nomesUnicos.Add(nomes[i]);
}
// percorrer cada elemento da lista «existentes»
// contar as repetições do existentes[i] na lista «nomes»
// e inserir a quantidade no «quantidades»
for (int i = 0; i < nomesUnicos.Count; i++)
{
    int quantidade;
    quantidade = ContaRepeticoes(nomes, nomesUnicos[i]);
    
    quantidades.Add(quantidade);
}
MostraResultados(nomesUnicos, quantidades);
// mostrar os resultados
static void MostraResultados(List<string> existentes, List<int> quantidades)
{
    for (int i = 0; i < existentes.Count; i++)
    {
        Console.WriteLine($"{existentes[i]} - {quantidades[i]}");

    }
}
// percorrer cada elemento dos «existentes»
// procurar se o «nomeProcurar» existe na lista
// se existir devolver true, senão devolver false
static bool Existe(List<string> nomesExistentes2, string nomePesquisar)
{
    bool repetido = false;
    for (int i = 0; i < nomesExistentes2.Count; i++)
    {
        if (nomePesquisar == nomesExistentes2[i])
            repetido = true;
    }
    return repetido ? true : false;
}
// contar os nomes «nomeProcurar»
// devolver a quantidade de repetições de «nomeProcurar»
static int ContaRepeticoes(List<string> nomes, string nomeProcurar)
{
    int quantidade = 0;
    for (int i = 0; i < nomes.Count; i++)
    {
        if (nomes[i] == nomeProcurar)
        {
            quantidade++;
        }
            
    }
    return quantidade;
}