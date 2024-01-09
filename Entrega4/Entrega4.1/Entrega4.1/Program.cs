using System;
using System.Collections.Generic;

//variaveis
//criar lista para iterar
List<string> nomes = RecolheCoisas();

int nomesRepetidos = ContaRepetidos(nomes);

Console.WriteLine($"Existem {nomesRepetidos} repetidos");

static List<string> RecolheCoisas()
{
    Console.WriteLine("Escreva os nomes dos alunos ('fim' para sair do loop):");
    //pedir input ao utilizador
    List<string> coisas = new List<string>();
    while (true)
    {
        //continuar a pedir input ao utilizador
        string input = Console.ReadLine();
        
        if (input.ToLower() == "fim")
            break;

        coisas.Add(input);
    }

    return coisas;
}


static int ContaRepetidos(List<string> coisas)
{
    int totalContagem = 0;

    // Iterar sobre a lista
    for (int i = 0; i < coisas.Count; i++)
    {
        // Verificar se a string não foi contada
        if (coisas[i] != null)
        {
            // Uma repetição do nome
            int contagem = 1;

            // Nested loop para iterar sobre o elemento a seguir na lista.
            for (int j = i + 1; j < coisas.Count; j++)
            {
                // Verificar se o elemento não foi contado e não é null
                if (coisas[j] != null && coisas[i] == coisas[j])
                {
                    // Marcar o elemento como contado
                    contagem++;
                }
            }

            // Se houver repetição, incrementar a contagem total
            if (contagem > 1)
            {
                totalContagem += contagem;

                // Marcar o elemento atual como contado
                coisas[i] = null;
            }
        }
    }

    return totalContagem;
}


//variaveis
List<string> nomes = new List<string>() {"manel", "maria", "antonio", "fernando"};

//recolher nomes