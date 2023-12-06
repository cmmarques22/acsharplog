Console.WriteLine("" +
                  "Crie uma aplicação que apresente na consola " +
                  "os números entre 5 e 5000.: " +
                  "Evolua o algoritmo para que seja " +
                  "possível alterar os limites. ");
//declaracao variaveis
int limiteInferior, limiteSuperior/*, int counter = 0;*/;

// Solicitar e ler o limite minimo
Console.Write("Digite o limite minimo: ");
 limiteInferior = int.Parse(Console.ReadLine());

// Solicitar e ler o limite maximo
Console.Write("Digite o limite maximo: ");
 limiteSuperior = int.Parse(Console.ReadLine());


//usually we do not change the value of the input provided,
//we work with an outside counter

//while (counter < limiteSuperior)

while (limiteInferior < limiteSuperior)
{
    limiteInferior++;
Console.WriteLine(limiteInferior);

    // Console.WriteLine(counter++);
    
}
