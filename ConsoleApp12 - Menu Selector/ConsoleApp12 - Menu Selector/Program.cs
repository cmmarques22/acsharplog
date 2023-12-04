Console.WriteLine("=====================================");
Console.WriteLine("=========Menu Selector=========");
Console.WriteLine("=====================================");




//recolher input
Console.Write(@"
Seleccione uma opçao
    1 - Formandos
    2 - Cursos
    3 - Turmas
    0 - Sair

");


Console.WriteLine("Opçao: ");
string selecao = Console.ReadLine();
switch (selecao)
{
    case "1":
    case "F":
    case "f":
        Console.WriteLine("Foi selecionada a opção Formandos.");
        break;
    case "2":
    case "C":
    case "c":
        Console.WriteLine("Foi selecionada a opção Cursos.");
        break;
    case "3":
    case "T":
    case "t":
        Console.WriteLine("Foi selecionada a opção Turmas.");
        break;
    case "0":
    case "S":
    case "s":
        Console.WriteLine("Foi selecionada a opção Sair. Adeus!");
        //Console.ReadKey();
        //Environment.Exit(0);
        break;
    default:
        Console.WriteLine("Opção inválida. Tente novamente.");
        break;
}





Console.WriteLine($"Foi selecionada a opçao {selecao}");