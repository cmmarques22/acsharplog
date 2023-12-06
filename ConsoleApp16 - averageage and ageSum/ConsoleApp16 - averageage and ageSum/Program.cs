Console.WriteLine("Crie uma aplicação que questione as idades dos " +
                  "alunos à entrada da escola.Apresente a média " +
                  "dos alunos com idade inferior a 20 e a soma" +
                  "dos restantes.");

//apresentar variaveis

int studentCounter = 0;
int totalStudents;
int age;
Console.WriteLine("Quantos alunos entram na escola?");
totalStudents = int.Parse(Console.ReadLine());
double ageBelow20 = 0;
double ageEqualOrAbove20 = 0;
int totalStudentsbelow20 =0;
double averageAge = 0;



while (studentCounter < totalStudents)
{
    Console.WriteLine("Que idade tens?");
    age = int.Parse(Console.ReadLine());

    if (age < 20)
    {
        ageBelow20 += age;
        totalStudentsbelow20++;
    }

    if (age >= 20)
    {
        ageEqualOrAbove20 += age;
    }
    studentCounter++;
}
averageAge = ageBelow20 / totalStudentsbelow20;
Console.WriteLine($"a media dos da idade dos estudantes com menos de 20 anos e de {averageAge}");

Console.WriteLine($"a soma  da idade dos estudantes com mais de 19 anos e de {ageEqualOrAbove20}");


