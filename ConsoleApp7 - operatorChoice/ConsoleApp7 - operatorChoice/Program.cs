
Console.WriteLine(@"
Crie uma aplicação que pergunte 
dois números inteiros ao utilizador,
e a operação matemática que pretende realizar.
Por exemplo, se o utilizador inserir o número
2 e o número 5, e se escolher a operação de 
somar através do símbolo + a aplicação deverá 
apresentar na consola 2 + 5 = 7.
");

//recolher  inteiros da consola

Console.Write("Escolha o primeiro numero inteiro: ");
int input1 = int.Parse(Console.ReadLine());

Console.Write("Escolha o segundo numero inteiro: ");
int input2 = int.Parse(Console.ReadLine());

Console.Write(@" 


string operatorInput = Console.ReadLine();

double result;

switch (operatorInput)
{
    case "+":
        result = input1 + input2;
        Console.WriteLine($" {input1} {operatorInput} {input2} dá {result}");
        break;
    case "-":
        result = input1 - input2;
        Console.WriteLine($" {input1} {operatorInput} {input2} dá {result}");
        break;
    case "*":
        result = input1 * input2;
        Console.WriteLine($" {input1} {operatorInput} {input2} dá {result}"); 
        break;
    case "/":
        result = (double)input1 / (double)input2;
        Console.WriteLine($" {input1} {operatorInput} {input2} dá {result}");
        break;
    case "%":
        result = input1 % input2;
        Console.WriteLine($" {input1} {operatorInput} {input2} dá {result}");
        break;
    default:
        Console.WriteLine("Operador inválido");
        break;
}



