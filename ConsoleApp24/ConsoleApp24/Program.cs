//funçao maximo. recebe abc, e devolve o maior
//funcao recolheInteiro, recebe string, minumo e maximo, tem de haver ciclo



int maximo = Maximo(3, 5, 4);
Console.WriteLine(maximo);


static int Maximo(int a, int b, int c)
{
    if (a >= b && a >= c)
    {
        return a;
    }
    else if (b >= a && b >= c)
    {
        return b;
    }
    else
    {
        return c;
    }
    // int largestNumber = Math.Max(Math.Max( a, b), c);
    // return largestNumber;
}

