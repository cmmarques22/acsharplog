
            
int contadoridade2035 = 0;

Console.WriteLine("Digite as idades ou  '101' para sair):");

while (true)
        {
            int input = int.Parse(Console.ReadLine());
            if (input == 101)
            {
                break;
            }
            // Verificar se a idade está no intervalo desejado
            else if (input >= 20 && input <= 35)
            {
                contadoridade2035++;
            }
        }
        // Exibir o resultado
        Console.WriteLine($"Existem {contadoridade2035} pessoas com idades entre 20 e 35");