using System.Collections.Generic;

Console.WriteLine("Desenvolva uma pequena aplicação que permita" +
                  " controlar quais os alunos presentes numa escola," +
                  " tendo por base o registo da sua entrada no edifício." +
                  " Sempre que um aluno entra na escola, o seu número deve" +
                  " ser guardado numa lista. Quando o aluno sai da escola," +
                  " esse aluno deve ser removido da lista. Note que, a qualquer" +
                  " momento, poderá ser necessário saber se um aluno está" +
                  " dentro ou fora da escola. Portanto, o menu deste programa," +
                  " deverá conter, pelo menos, as opções: " +
                  "1 – entrada de um aluno; " +
                  "2 – saída de um aluno; " +
                  "3 – verificar presença de um aluno; " +
                  "0 – Sair.");

//variaveis

List<string> listaAlunos = new List<string>();
UserInterface(listaAlunos);


 void UserInterface(List<string> lista)
{
    Console.WriteLine(@"Selecione uma das seguitne s opçoes:
1 – entrada de um aluno
2 – saída de um aluno
3 – verificar presença de um aluno
0 – Sair");

    string userChoice = Console.ReadLine();
    switch (userChoice)
    {
        case "1":
            EntradaAluno(lista);
            break;
        case "2":
            SaidaAluno(lista);
            break;
        case "3":
            VerificaPresenca(lista);
            break;
        case "0":
            Environment.Exit(0);
            break;
        default:
            Console.WriteLine("Escolha inválida");
            break;
    }
}


void VerificaPresenca(List<string> listaPresencas)
{
    Console.WriteLine("Digite o nome do aluno para verificar presença:");
    string aluno = Console.ReadLine();

    Console.WriteLine("Alunos presentes na escola:");

    bool alunoPresente = false;

    for (int i = 0; i < listaPresencas.Count; i++)
    {
        Console.WriteLine("verificando a presenca do aluno " +  listaPresencas[i]);

        if (listaPresencas[i] == aluno)
        {
            alunoPresente = true;
        }
    }

    if (alunoPresente)
    {
        Console.WriteLine($"{aluno} está presente na escola.");
    }
    else
    {
        Console.WriteLine($"{aluno} não está presente na escola.");
    }

    UserInterface(listaPresencas);
}


void EntradaAluno(List<string> listaEntradas)
{
    Console.WriteLine("Digite os nomes dos alunos que entraram na escola(digite 'fim' para encerrar):");

    string aluno = Console.ReadLine();

    while (aluno != "fim")
    {
        listaEntradas.Add(aluno);
        aluno = Console.ReadLine();
    }
    UserInterface(listaEntradas);
}


void SaidaAluno(List<string> listaSaida)

//lista nova devido ao problema de for loop out of bounds e ou iterar incorretamente
//quando removemos algo de uma lista em runtime, a lista ficara mais pequena ( nao acontece em array), e o indice do elementos restantes
// ficam mais pequenos.
// lista [1, 2, 3, 4, 5]. Quando i é 1 e removemos o elemento 2, a lista  torna se [1, 3, 4, 5].
// Agora, a próxima iteração com i como 2 irá ignorar o elemento 3 que agora está no índice 1
// no fim da lista tb pode ocorrer IndexOutOfRangeException, ai podes fazer try catch desta excepçao tb


{
    Console.WriteLine("Digite os nomes dos alunos que saíram da escola (digite 'fim' para encerrar):");

    string aluno = Console.ReadLine();

    while (aluno != "fim")
    {
        List<string> listaNova = new List<string>();

        for (int i = 0; i < listaSaida.Count; i++)
        {
            if (listaSaida[i] != aluno)
            {
                listaNova.Add(listaSaida[i]);
            }
            else
            {
                Console.WriteLine($"{aluno} saiu da escola.");
            }
        }

        listaSaida = listaNova;
        aluno = Console.ReadLine();
    }

    UserInterface(listaSaida);
}








