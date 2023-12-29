Console.WriteLine(@"Desenvolva uma aplicação que permita 
descobrir quantos formandos com o mesmo primeiro nome 
existem numa escola. Guarde numa lista todos os primeiros 
nomes dos alunos. Posteriormente, imprima na consola a 
quantidade de repetições existente por cada nome.");

//variaveis
//criar lista para iterar
List<string> nomes = new List<string>();


Console.WriteLine("escreva os nomes dos alunos 'fim' para sair do loop):");

//pedir input ao utilizador
string input = Console.ReadLine();

while (input != "fim")
{
    nomes.Add(input);
    //continuar a pedir input ao utilizador
    input = Console.ReadLine();
}

//iterar sobre a lista
for (int i = 0; i < nomes.Count; i++)
{
    if (nomes[i] != null)
    {
        //uma repeticao do nome
        int contagem = 1;
        // nested loop para iterar sobre o elemento a seguir na lista. sem isso vamos comparar sempre o msm elemento consigo proprio.
        //comparar o 1 com o 2, 2 com o 3 elemento. sem +1 seria compara consigo proprio e tudo seria repetido
        for (int j = i + 1; j < nomes.Count; j++)
        {
            if (nomes[i] == nomes[j])
            {
                contagem++;
                nomes[j] = null;
            }
        }
        // Imprimir a contagem
        Console.WriteLine($"Nome: {nomes[i]}, Repetições: {contagem}");
    }
}
