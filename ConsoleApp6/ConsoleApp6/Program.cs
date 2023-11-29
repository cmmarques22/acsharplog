// See https://aka.ms/new-console-template for more information
//recolher nome e idade da criança
//mediante idade, receber premio
//    7 anos caderno
//    11 bola
//    o manel ganhou uma bola porque tem 11 anos
//Console.WriteLine("Hello, World!");


//apresentar programa
Console.WriteLine("=====================================");
Console.WriteLine("Programa idade = oferta");
Console.WriteLine("=====================================");



// variaveis
int age;
string name, gift ="";


//Lista de Ofertas

Console.WriteLine(@"
1 a 7 - caderno
8 - caneta
9 - boneco
10 - ferrari 
11 - bola
");

//recolha de idade

Console.Write("Que idade tem a criança? ");
age = int.Parse(Console.ReadLine());

//if (age > 11)
//{
//    Console.WriteLine("nao tem idade para presentes");
//    Environment.ExitCode = 0;
//}

//recolha de nome da crianaça
Console.Write("Nome da criança? ");
name = Console.ReadLine();

//programa para cada presente

switch (age)
{
    case 1:
    case 2:
    case 3:
    case 4:
    case 5:
    case 6:
    case 7:
        gift = "caderno";
        break;
    case 8:
        gift = "caneta";
        break;
    case 9:
        gift = "boneco";
        break;
    case 10:
        gift = "ferrari";
        break;
    case 11:
        gift = "bola";
        break;
    default:
        gift = "NA";
        //Console.WriteLine("nao tem idade para prendas");
        break;
}
if (name == null || age == null || gift == "NA")
{
    Console.WriteLine($"{name} nao tem direito a prenda porque tem {age} anos");
}
else
{
    Console.WriteLine($"{name} ganhou uma {gift} porque tem {age} anos");
}


