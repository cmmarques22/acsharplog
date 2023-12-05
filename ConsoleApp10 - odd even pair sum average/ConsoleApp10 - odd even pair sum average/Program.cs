


//apresentar programa
Console.WriteLine("=====================================");
Console.WriteLine("Programa de idade media impar e soma par");
Console.WriteLine("=====================================");




//recolha das variaveis


//recolher  inteiros da consola
Console.Write("Digite a idade da primeira pessoa:");
int primeirapessoa = int.Parse(Console.ReadLine());
Console.Write("Digite a idade da segunda pessoa:");
int segundapessoa = int.Parse(Console.ReadLine());
Console.Write("Digite a idade da terceira pessoa:");
int terceirapessoa = int.Parse(Console.ReadLine());
Console.Write("Digite a idade da quarta pessoa:");
int quartapessoa = int.Parse(Console.ReadLine());
Console.Write("Digite a idade da quinta pessoa:");
int quintapessoa = int.Parse(Console.ReadLine()); ;

int somaImpar = 0;
int mediaPares = 0;
int contadorPares = 0;

if (primeirapessoa % 2 == 0)
{
    mediaPares = mediaPares + primeirapessoa;
    //contadorPares = contadorPares + 1;
    //contadorPares += 1;
    contadorPares++;

}
else
{
    somaImpar += primeirapessoa;
}
if (segundapessoa % 2 == 0)
{
    mediaPares = mediaPares + segundapessoa;
    //contadorPares += 1;
    contadorPares++;
    // ++contadorPares;

}
else
{
    somaImpar += segundapessoa;
}
if (terceirapessoa % 2 == 0)
{
    mediaPares = mediaPares + terceirapessoa;
    //contadorPares += 1;
    contadorPares++;

}
else
{
    somaImpar += terceirapessoa;
}
if (quartapessoa % 2 == 0)
{
    mediaPares = mediaPares + quartapessoa;
    //contadorPares += 1;
    contadorPares++;

}
else
{
    somaImpar = somaImpar + quartapessoa;
    // somaImpar += quartapessoa;
}
if (quintapessoa % 2 == 0)
{
    mediaPares = mediaPares + quintapessoa;
    //contadorPares += 1;
    contadorPares++;
}
else
{
    somaImpar  += quintapessoa;
}

double resultadoSoma;
double resultadoMEdia = mediaPares / contadorPares;




Console.WriteLine($" a media dos pares dá {resultadoMEdia}");
Console.WriteLine($" a soma dos impares dá {somaImpar}");




