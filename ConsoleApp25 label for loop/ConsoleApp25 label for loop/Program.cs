//funcao recolheInteiro, recebe string, minumo e maximo, tem de haver ciclo

int idade;
idade = RecolheIdade("insira a idade", 25, 490);

// Console.WriteLine("A idade inserida é: " + idade);
static int RecolheIdade(string label, int intervaloMin, int intervaloMax)
{
    //variaveis
    int numero, switcher;


    //colocar pergunta
    Console.WriteLine(label);

    //recolher inteiro ate que seja valido
    // 1a soluçao
    numero = int.Parse(Console.ReadLine());


    //2a solucao
    while (numero < intervaloMin || numero > intervaloMax)
    {
        Console.WriteLine(label);
        numero = int.Parse(Console.ReadLine());

        //validar se monimo esta na ordem correta

        if (intervaloMin > intervaloMax)
        {
            switcher = intervaloMin;
            intervaloMin = intervaloMax;
            intervaloMax = switcher;
        }
    }

    // devolver inteiro
    return numero;
}