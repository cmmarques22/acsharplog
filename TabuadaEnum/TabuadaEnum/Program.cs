// Variáveis

using TabuadaEnum;

int numero;
int tabuada;

char tableOrder;
Ordem ordem;


int opcao;
string tabuada1 = "";



// Apresentação do programa
ApresentacaoPrograma();

// Recolha de dados
RecolhaDados();

// Executar programa
TableGenerator(tabuada, ordem);

opcao = RecolheInteiro("coisas:", 1, 10);

static void ApresentacaoPrograma()
{
    Console.WriteLine("=====================================");
    Console.WriteLine("==========Programa de tabuada========");
    Console.WriteLine("=====================================");

    Console.Write("Tabuada do numero: ");
}

void RecolhaDados()
{
    tabuada = int.Parse(Console.ReadLine());
    Console.WriteLine("Escolha a opção:");
    Console.WriteLine("A - Tabuada ascendente");
    Console.WriteLine("D - Tabuada descendente");
    tableOrder = char.Parse(Console.ReadLine());

}

static void TableGenerator(int number, Ordem ordem)
{
    int result = 0;

    if (ordem == Ordem.Ascendente )
    {
        // Loop para ir até ao número escolhido ASC
        for (int i = 1; i <= 10; i++)
        {
            // Multiplicação
            result = number * i;

            // Print em linhas diferentes
            Console.WriteLine($"{number} * {i} = {result}");
        }
    }

    if (ordem == Ordem.Descendente)
    {
        // Loop para ir até ao número escolhido DESC
        for (int i = 10; i >= 1; i--)
        {
            result = number * i;
            // String que faz {NUMERO ESCOLHIDO} + " X " + I + " = " {RESULTADO}
            Console.WriteLine($"{number} * {i} = {result}");
        }
    }
    //PARA JA NAO PRECISO DE DEVOLVER NADA
}

static int RecolheInteiro(string label, int minimo, int maximo)
{
    int opcao;

    for (int i = 0; i < UPPER; i++)
    {
        
    }
    
    return 0;



}