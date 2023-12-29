using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("Desenvolva uma aplicação que guarde os 5" +
                          " visitantes mais velhos que foram\r\nao circo" +
                          " neste Natal. A cada inserção de idade, a aplicação " +
                          "deverá remover a idade mais\r\nnova existente na" +
                          " lista, desde que a idade em inserção seja mais" +
                          " velha do que essa. No final,\r\nas 5 idades" +
                          " existentes na lista dirão respeito às 5 pessoas" +
                          " mais velhas que foram ao circo.\r\nImprima-as" +
                          " na consola.");

        // Variáveis
        List<int> listaIdades = new List<int>();

        // Recolher idades
        RecolhaIdades(listaIdades);
        ImprimirIdadesMaisVelhas(listaIdades);
    }

    static void RecolhaIdades(List<int> listaIdades)
    {
        // Receive 5 ages
        for (int i = 0; i < 5; i++)
        {
            Console.Write($"Insira a {i + 1}ª idade: ");
            int idade = int.Parse(Console.ReadLine());

            if (idade > 0)
            {
                InserirIdades(listaIdades, idade);
            }
            else
            {
                Console.WriteLine("Idade inválida, tente outra vez");
                i--;
            }
        }

        // Print the initial 5 ages
        ImprimirIdadesMaisVelhas(listaIdades);

        // Receive additional ages one by one
        int novaIdade = 0;
        while (novaIdade != -1)
        {
            Console.Write("Insira idade: ");
            novaIdade = int.Parse(Console.ReadLine());

            if (novaIdade > 0)
            {
                InserirIdades(listaIdades, novaIdade);
                ImprimirIdadesMaisVelhas(listaIdades); // Print after each insertion
            }
            else if (novaIdade != -1)
            {
                Console.WriteLine("Idade inválida, tente outra vez");
            }
        }
    }

    static void InserirIdades(List<int> listaIdades, int idade)
    {
        // Add the new age to the list
        listaIdades.Add(idade);

        // Sort the list in descending order
        for (int i = 0; i < listaIdades.Count - 1; i++)
        {
            for (int j = i + 1; j < listaIdades.Count; j++)
            {
                if (listaIdades[i] < listaIdades[j])
                {
                    // Swap ages if out of order
                    int temp = listaIdades[i];
                    listaIdades[i] = listaIdades[j];
                    listaIdades[j] = temp;
                }
            }
        }

        // Remove the extra elements if more than 5
        while (listaIdades.Count > 5)
        {
            listaIdades.RemoveAt(5);
        }
    }


    static void ImprimirIdadesMaisVelhas(List<int> listaIdades)
    {
        // Imprimir as 5 pessoas mais velhas que foram ao circo
        Console.WriteLine("As 5 pessoas mais velhas que foram ao circo:");

        for (int i = 0; i < listaIdades.Count; i++)
        {
            Console.WriteLine(listaIdades[i]);
        }
    }
}


//  void SaidaAluno()
// {
//     Console.WriteLine("Digite os nomes dos alunos que sairam da escola (digite 'fim' para encerrar):");
//
//     string aluno = Console.ReadLine();
//
//     while (aluno != "fim")
//     {
//         for (int i = 0; i < listaAlunos.Count; i++)
//         {
//             if (listaAlunos[i] == aluno)
//             {
//                 listaAlunos.Remove(aluno);
//                 Console.WriteLine($"{aluno} saiu da escola.");
//             }
//             else
//             {
//                 Console.WriteLine($"{aluno} não estava presente na escola.");
//             }
//         }
//         
//         aluno = Console.ReadLine();
//     }
//     UserInterface();
// }