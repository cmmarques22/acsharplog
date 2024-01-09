//apresentar programa
Console.WriteLine("=====================================");
Console.WriteLine("Programa de descontos para vacinas");
Console.WriteLine("=====================================");

//variaveis
char genero;
double cumprimento;

//recolha de dados

Console.WriteLine("Qual o cumprimento do gato?");
cumprimento = double.Parse(Console.ReadLine());

Console.WriteLine("Qual o genero do gato?");
genero = char.Parse(Console.ReadLine());


float desconto = (float)CalcularDesconto(cumprimento, genero);

// Calcular e exibir o desconto ao utilizador

ExibirDesconto(desconto);
static double CalcularDesconto(double comprimento, char genero)
    {
        double desconto = 5; // Valor padrão para restantes casos

        if (comprimento >= 6 && comprimento < 10)
        {
            if (genero == 'F')
                desconto = 10;
        }
        else if (comprimento >= 4.5 && comprimento < 6)
        {
            if (genero == 'M')
                desconto = 5.8;
        }
        else if (comprimento >= 2 && comprimento < 4)
        {
            if (genero == 'F')
                desconto = 4;
        }
        else if (comprimento >= 10 && comprimento < 15)
        {
            if (genero == 'M')
                desconto = 9;
        }
        else if (comprimento >= 15 && comprimento < 18)
        {
            if (genero == 'F')
                desconto = 8;
        }
        else if (comprimento >= 18 && comprimento < 25)
        {
            desconto = 7;
        }

        return desconto;
    }
static void ExibirDesconto(double desconto)
{
        Console.WriteLine($"Desconto a atribuir: {desconto}%");
}
