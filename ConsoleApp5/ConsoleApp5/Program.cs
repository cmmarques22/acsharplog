//    programa para lista de produtos
//    recolher inteiro da consola
//    insira o preço
//    metemos o preço de custo
//    em funçao do artigo, calculamos a margem de venda
//    user meteu 1, a margem é de 100
//    a consola diz que o pvp é 107

//apresentar programa
Console.WriteLine("=====================================");
Console.WriteLine("Programa de calculo de pvp");
Console.WriteLine("=====================================");

//lista de produtos

int produto;
float precoCusto, precoVenda;
float margem;



Console.WriteLine(@"
1 - Televisão
2 - Ferro de engomar
3 - Frigorífico
4 - portatil
5 - ferrari
6 - air fryer
7 - air bus
");


//recolha produto
Console.WriteLine("Escolha o produto:");

produto = int.Parse(Console.ReadLine());

//debug and check current product value before and after RUN


if (produto<1 || produto>7)
{
    Console.WriteLine("nao existe");
    return;
}


//recollher precoCusto
Console.WriteLine("insira o preço de custo: ");

precoCusto = int.Parse(Console.ReadLine());




//calcular o precovenda



if ( produto == 1)
{
    margem = 10f;
    //precoVenda = precoCusto + 10;
}
else if ( produto == 2)
{
    margem = 7f;
    //precoVenda = precoCusto + 7;
}
else if (produto == 3)
{
    margem = 9f;
    //precoVenda = precoCusto + 9;
}
else if (produto == 4)
{
    margem = 20f;
    //precoVenda = precoCusto + 20;
}
else if (produto == 5)
{
    margem = 15f;
    //precoVenda = precoCusto + 20;
}
else if (produto == 6)
{
    margem = 12f;
    //precoVenda = precoCusto + 20;
}
else if (produto == 7)
{
    margem = 11f;
    //precoVenda = precoCusto + 20;
}

else
{
    //codigo defensivo, margem declarada fora das condiçoes
    margem = -1;
    Console.WriteLine("produto selecionado nao existe");
}

//apresentar precoVenda
if (margem > 1)
{
    precoVenda = precoCusto + margem;
    Console.WriteLine($"o preço de venda é: {precoVenda}");

}














