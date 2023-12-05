//declaracao variaveis
int limiteInferior;
int limiteSuperior;
//int counter = 0;

// Solicitar e ler o limite minimo
Console.Write("Digite o limite minimo: ");
 limiteInferior = int.Parse(Console.ReadLine());

// Solicitar e ler o limite maximo
Console.Write("Digite o limite maximo: ");
 limiteSuperior = int.Parse(Console.ReadLine());

while (limiteInferior < limiteSuperior)
{
    limiteInferior++;
    
    Console.WriteLine(limiteInferior);
    
}
