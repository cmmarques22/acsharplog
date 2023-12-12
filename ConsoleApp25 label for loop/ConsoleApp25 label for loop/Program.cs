Console.WriteLine("Escolha um digito para inicial o intervalo");
int intervaloMin = int.Parse(Console.ReadLine());

Console.WriteLine("Escolha um digito para fechar o intervalo");
int intervaloMax = int.Parse(Console.ReadLine());


int idade;
idade = RecolheIdade("insira a idade", 25, 490);
Console.WriteLine("A idade inserida é: " + idade);

static int RecolheIdade(string label, int intervaloMin, int intervaloMax)
{
    
    
    for (int i = intervaloMin; i <= intervaloMax; i++)
    {
        if (idade == i)
        {
            return idade; // Return the valid age
        }
    }
}