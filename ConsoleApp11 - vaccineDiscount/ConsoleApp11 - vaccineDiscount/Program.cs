//apresentar programa
Console.WriteLine("=====================================");
Console.WriteLine("Programa de descontos para vacinas");
Console.WriteLine("=====================================");


//declaracao de variaveis

double comprimentoCanidieo;
string generoCanideo;
float desconto = 0f;


//obter input da consola  
Console.Write("Qual o comprimento do seu cao?: ");
comprimentoCanidieo = double.Parse(Console.ReadLine());
Console.Write("Qual o genero do seu canideo?: ");
generoCanideo = Console.ReadLine();

//tabela por generos switch
switch (generoCanideo)
{
    case "F":
    case "f":
        if (comprimentoCanidieo >= 10 && comprimentoCanidieo < 15)
        {
            desconto = 10f;
        }
        else if (comprimentoCanidieo >= 15 && comprimentoCanidieo < 20)
        {
            desconto = 8f;
        }
        else if (comprimentoCanidieo >= 20 && comprimentoCanidieo < 25)
        { 
            desconto = 7f; 
        }
        else
        { 
            desconto = 5f; 
        }
        break;
    case "M":
    case "m":
        if (comprimentoCanidieo >= 15 && comprimentoCanidieo < 20)
        {
            desconto = 9f;
        }
        else if (comprimentoCanidieo >= 20 && comprimentoCanidieo < 25)
        {
            desconto = 7f;
        }
        else
        {
            desconto = 5f;
        }
        break;
    default:
        Console.WriteLine("O genero nao existe");
        break;
}

//apresentar taxa de desconto
Console.WriteLine($" o comprimento do canideo é de {comprimentoCanidieo} e" +
    $" tem um desconto de {desconto}");
















//tabela por generos if else
/*
if ((comprimentoCanidieo >= 10 && comprimentoCanidieo < 15) && generoCanideo == "F")
{ 
    desconto = 10;
}
else if ((comprimentoCanidieo >= 15 && comprimentoCanidieo < 20) && generoCanideo == "M")
{
    desconto = 9;
}
else if ((comprimentoCanidieo >= 15 && comprimentoCanidieo < 20) && generoCanideo == "F")
{
    desconto = 8;
}
else if ((comprimentoCanidieo >= 20  && comprimentoCanidieo < 25) && (generoCanideo == "F" || generoCanideo == "M"))
{
    desconto = 7;
}
else
{
    desconto = 5;

}
Console.WriteLine($" o comprimento do canideo é de {comprimentoCanidieo} e tem um desconto de {desconto}");
*/



