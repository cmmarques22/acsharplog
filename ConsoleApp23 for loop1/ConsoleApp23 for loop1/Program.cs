//variaveis
int soma3 = SomaAte(3);
int soma5 = SomaAte(5);
int soma7 = SomaAte(7);


MostraSoma(3, soma3 );
MostraSoma(5, soma5);
MostraSoma(7, soma7);

//efetuar a soma

static void MostraSoma(int n, int soma)
{
    Console.WriteLine(@$"
------------------------
Número:{n}
Soma: {soma}
------------------------");
}

static int SomaAte(int n)
{
    //variaveis
    int soma = 0;
    //acumular ate n
    for (int i = 1; i <= n; i++)
    {
        soma += i;
    }
    return soma;
}
