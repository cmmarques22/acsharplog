using System;
using System.Collections.Generic;

Console.WriteLine("Bem-vindo ao sorteio de alunos!");

// Definir o intervalo de alunos
int minAluno = 218;
int maxAluno = 233;

// Criar uma lista para armazenar os alunos sorteados
List<int> alunosSorteados = new List<int>();

// Realizar o sorteio
SortearAlunos(minAluno, maxAluno, alunosSorteados);

// Apresentar os alunos sorteados
ApresentarAlunosSorteados(alunosSorteados);


static void SortearAlunos(int min, int max, List<int> listaSorteados)
{
    // Objeto para gerar random
    Random random = new Random();

    // Loop para sortear alunos sem repetição, a lista nunca sera maior que o intervalo
    while (listaSorteados.Count < (max - min))
    {
        //sortear dentro do intervalo
        int alunoSorteado = random.Next(min, max);


        // Verificar se o aluno já foi sorteado
        bool alunoRepetido = false;
        for (int i = 0; i < listaSorteados.Count; i++)
        {
            // Se o aluno já estiver na lista, marcar como repetido e sai do loop
            if (listaSorteados[i] == alunoSorteado)
            {
                alunoRepetido = true;
                break;
            }
        }

        // Adicionar o aluno à lista se não for repetido, tem de ser adicionado
        // fora do for loop que senao corres o risco de nao percorrer a lista toda ou de adicionar a lista em todas as iteraçoes
        if (!alunoRepetido)
        {
            listaSorteados.Add(alunoSorteado);
        }
    }
}


static void ApresentarAlunosSorteados(List<int> listaSorteados)
{
    Console.WriteLine("\nAlunos sorteados:");

    // Loop for para iterar sobre os elementos da lista e apresentar os alunos sorteados
    for (int i = 0; i < listaSorteados.Count; i++)
    {
        Console.WriteLine($"Aluno {listaSorteados[i]}");
    }
}
