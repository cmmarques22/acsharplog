using System;
using System.Collections.Generic;

//variaveis
List<string> inputList = GetListFromUser();
int commonCount = CountCommonStrings(inputList);

//apresentar resultados
Console.WriteLine($"Number of common strings: {commonCount}");

//recolher strings da consola
static List<string> GetListFromUser()
{
    Console.WriteLine("Enter strings (type 'done' to finish):");
    List<string> guardarLista = new List<string>();

    //loop para preencher lista ate escrever "fim"
    while (true)
    {
        string input = Console.ReadLine();
        if (input.ToLower() == "fim")
            break;

        guardarLista.Add(input);
    }

    return guardarLista;
}

static int CountCommonStrings(List<string> comparaStringsLista)
{
    int contadorRepeticoes = 0;

    //loop externo para avaliar a 1 string com todas as restantes
    for (int i = 0; i < comparaStringsLista.Count; i++)
    {
        string stringAtual = comparaStringsLista[i];

        Console.WriteLine($"iteracao loop externo {i + 1}: stringAtual = {stringAtual}, Index i = {i}");
        // loop interno para avaliar a 2a string com as restantes
        // i+1 para nao comparar 1a letra repetidamente
        for (int j = i + 1; j < comparaStringsLista.Count; j++)
        {
            string stringComparada = comparaStringsLista[j];

            Console.WriteLine($"  iteracao loop interno {j + 1}: stringComparada = {stringComparada}, Index j = {j}");

            //avaliar as strings de ambos os loops
            if (stringAtual == stringComparada)
            {
                contadorRepeticoes++;
                Console.WriteLine($"String repetida encontrada. contadorRepeticoes = {contadorRepeticoes}");
            }
        }
    }

    return contadorRepeticoes;
}
