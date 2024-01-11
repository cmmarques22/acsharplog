Console.WriteLine("qual a largura do quadrado");
int largura = int.Parse(Console.ReadLine());
Console.WriteLine("qual a  do quadrado");
int altura = int.Parse(Console.ReadLine());
Console.Write("Introduza o simbolo desejado: ");
string sinal = Console.ReadLine();
Console.Write("Introduza o tipo de quadrado: (C = Cheio, V = Vazio ");
char forma = char.Parse(Console.ReadLine());

DesenhaQuadrado(altura, largura, sinal, forma);




static void DesenhaQuadrado(int altura, int largura, string simbolo, char tipo)
{
    if (tipo == 'C')
    {
        for (int i = 0; i < altura; i++)
        {
            for (int j = 0; j < largura; j++)
            {
                
                
                    Console.Write(simbolo + " ");
                
            }

            Console.WriteLine();
        }
    }

    if (tipo == 'V')
    {
        for (int i = 0; i <= altura; i++)
        {
            for (int j = 0; j <= largura; j++)
            {
                //preencher as margens na primeira posicao ou ultima
                if (i == 0 || i == altura || j == 0 || j == largura)
                    
                {
                    Console.Write(simbolo + " ");
                    
                }
                else
                {
                    Console.Write("  "); // Two spaces for an empty center
                }
            }
            Console.WriteLine();
        }
    }
}






//Programa(largura, altura, sinal);


//static void Programa(int largura, int altura, string simbolo)
//{
//    string repeticoes = "";

//    for (int i = largura; i <= altura; i += 5)
//    {
//        repeticoes += simbolo;

//        Console.WriteLine($"{repeticoes}");
//    }
//}

