// See https://aka.ms/new-console-template for more information
Console.WriteLine("Foi efetuado um questionário a um grupo de " +
                  "pacientes num hospital. De entre as perguntas " +
                  "efetuadas a cada paciente, destaca-se o género," +
                  " a idade e se gostaram do atendimento efetuado " +
                  "pelo profissional de saúde que os atendeu. " +
                  "Implemente uma aplicação capaz de calcular e informar:" +
                  "\r\n•\r\nO número de inquiridos do género feminino e masculino," +
                  " que esperaram mais de 2 horas para serem atendidos;\r\n•\r\n" +
                  "Percentagem de pacientes do género feminino que não gostaram" +
                  " do atendimento do profissional de saúde que os atendeu;\r\n•\r\n" +
                  "Quantidade de pacientes de género masculino, maiores de idade" +
                  ", que gostaram do atendimento do médico que os atendeu;\r\n•\r\n" +
                  "Média do tempo de espera dos pacientes femininos que não gostaram" +
                  " do atendimento do profissional de saúde.\r\nFIM");

int totalPacientes = 5;
int numeroMulheres = 0;
int numeroHomens = 0;
int homensMais2Horas = 0;
int mulheresMAis2Horas = 0;
int mulheresMaufeedback = 0;
int idadeHomem = 0;
int homensBomFeedBack = 0;
double somaTempoEsperaMulheresInsatisfeitas = 0;
int totalMulheresInsatisfeitas = 0;

// Perguntar sobre cada paciente
for (int i = 0; i < totalPacientes; i++)
{
    Console.WriteLine($"\nInformações do paciente {i + 1}:");

    // Sexo
    Console.Write("Sexo (F/M): ");
    char genero = char.Parse(Console.ReadLine());

    // Idade
    Console.Write("Idade: ");
    int idade = int.Parse(Console.ReadLine());

    // Tempo de espera
    Console.Write("Tempo de espera (em horas): ");
    double tempoDeEspera = double.Parse(Console.ReadLine());

    // Satisfação com atendimento
    Console.Write("Gostou do atendimento? (S/N): ");
    bool gostouDoAtendimento = (Console.ReadLine() == "S");

    // Pergunta 1
    if (genero == 'F' && tempoDeEspera > 2)
    {
        mulheresMAis2Horas++;
    }
    else if (genero == 'M' && tempoDeEspera > 2)
    {
        homensMais2Horas++;
    }

    // Pergunta 2
    if (genero == 'F' && !gostouDoAtendimento)
    {
        mulheresMaufeedback++;
    }

    // Pergunta 3
    if (genero == 'M' && idade >= 18 && gostouDoAtendimento)
    {
        homensBomFeedBack++;
    }

    // Pergunta 4
    if (genero == 'F' && !gostouDoAtendimento)
    {
        somaTempoEsperaMulheresInsatisfeitas += tempoDeEspera;
        totalMulheresInsatisfeitas++;
    }
}

// Cálculo da média do tempo de espera das mulheres insatisfeitas
double mediaTempoEsperaMulheresInsatisfeitas = totalMulheresInsatisfeitas > 0 ?
    somaTempoEsperaMulheresInsatisfeitas / totalMulheresInsatisfeitas :
    0;

// Exibição dos resultados
Console.WriteLine($"\nMulheres que esperaram mais de 2 horas: {mulheresMAis2Horas}");
Console.WriteLine($"Homens que esperaram mais de 2 horas: {homensMais2Horas}");
Console.WriteLine($"Percentagem de mulheres insatisfeitas: {(double)mulheresMaufeedback / totalPacientes * 100}%");
Console.WriteLine($"Homens maiores de idade que gostaram do atendimento: {homensBomFeedBack}");
Console.WriteLine($"Média do tempo de espera das mulheres insatisfeitas: {mediaTempoEsperaMulheresInsatisfeitas} horas");

