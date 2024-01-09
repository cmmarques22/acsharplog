

// Variáveis
int tabuada;
char tableOrder;
Ordem ordenacao;



// Apresentação do programa
ApresentacaoPrograma();

// Recolha de dados
RecolhaDados();

// Executar programa
TableGenerator(tabuada, tableOrder);

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
    Console.WriteLine("N - Tabuada normal");
    Console.WriteLine("I - Tabuada invertida");
    tableOrder = char.Parse(Console.ReadLine());
}

static void TableGenerator(int number, Ordem ordem)
{
    int result = 0;
        
    if (orderAscDes == 'N' && ascDesc == As && ordem = Ordem.)
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

    if (orderAscDes == 'I')
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
//PODERIA GUARDAR OS RESULTADOS NUMA LISTA
//VARIAVES - List<string> multiplicationList = TableGenerator(tabuada, tableOrder);
//FOR LOOP - List<string> multiplicationList = new List<string>();
//FOR LOOP - multiplicationList.Add(multiplication);
//APRESENTACAO DO PROGRAMA OU DENTRO DE METODO
//for (int i = 0; i < multiplicationList.Count; i++)
// {
//     Console.WriteLine(multiplicationList[i]);
// }


static int RecolheInteiro(string label, int minimo, int maximo)
{
    //variaveis



}