// 
//

string nome;
string morada;
string codPostal;

nome = GetString("nome:", 3, 5);
morada = GetString("morada:", 3, 5);
codPostal = GetString("codPostal:", 3, 5);


static string GetString(string label, int minSize, int maxSize)
{
    //variaveis
    string input;

    //recolher numero  e guardar lenght  
    Console.WriteLine($"{label} entre {minSize} e {maxSize}");
    input = Console.ReadLine();
    
    //verificar tamanho dentro dos intervalos
    while (input.Length < minSize || input.Length > maxSize)
    {
        Console.WriteLine(label);
        input = $"not good. enter a string between {minSize} and {maxSize} characters.";
        input = Console.ReadLine();
    }
    
    return input;
}