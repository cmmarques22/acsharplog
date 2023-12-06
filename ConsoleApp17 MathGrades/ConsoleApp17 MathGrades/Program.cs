
        Console.WriteLine("Concurso de Matemática ");

        // Inicializa variáveis
        int studentNumber = 0;
        double gradeSum = 0;

        // Loop para inscrição de alunos
        while (true)
        {
            Console.Write("Informe o nome do aluno (ou 'sair' para encerrar): ");
            string studentName = Console.ReadLine();

            // Verifica se o usuário deseja sair do programa
            if (studentName.ToLower() == "sair")
            {
                break;
            }

            // recolher a nota do aluno
            Console.Write($"Informe a nota de {studentName} em Matemática (0 a 20): ");
            double mathGrade = double.Parse(Console.ReadLine());

            // Verifica se a nota está dentro do intervalo permitido
            if (mathGrade < 0 || mathGrade > 20)
            {
                Console.WriteLine("A nota deve estar no intervalo de 0 a 20. Inscrição automaticamente recusada.");
                continue;
            }

            // Verifica se a inscrição é recusada de acordo com as condições
            if (mathGrade < 14)
            {
                Console.WriteLine($"Inscrição de {studentName} recusada. Nota inferior a 14.");
                continue;
            }

            // Atualiza o número de alunos e a soma das notas
            studentNumber++;
            gradeSum += mathGrade;

            // Verifica se atingiu o número máximo de alunos ou a média desejada
            if (studentNumber >= 5 && (gradeSum / studentNumber) >= 18)
            {
                break;
            }
            else if (studentNumber >= 10)
            {
                Console.WriteLine("Número máximo de alunos atingido (10). Encerrando as inscrições.");
                break;
            }
        }

        // Exibe os resultados
        Console.WriteLine($"Número total de alunos inscritos: {studentNumber}");
        Console.WriteLine($"Média das notas dos alunos inscritos: {gradeSum / studentNumber}");

        // Aguarde o usuário pressionar uma tecla antes de fechar o console
        Console.ReadLine();
    