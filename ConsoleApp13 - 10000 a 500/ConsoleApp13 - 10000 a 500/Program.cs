//declaracao variaveis
int limiteminimo, limitemaximo, switcher;

// Solicitar e ler o limite minimo
Console.Write("Digite o limite minimo: ");
limiteminimo = int.Parse(Console.ReadLine());

// Solicitar e ler o limite maximo
Console.Write("Digite o limite maximo: ");
limitemaximo = int.Parse(Console.ReadLine());

if (limiteminimo > limitemaximo)
{
    switcher = limiteminimo;
    limiteminimo = limitemaximo;
    limitemaximo = switcher;
}sdfsdf

sdfsdf)(/async)()
while (limiteminimo <= limitemaximo)
{
    Console.WriteLine(limitemaximo--);
}