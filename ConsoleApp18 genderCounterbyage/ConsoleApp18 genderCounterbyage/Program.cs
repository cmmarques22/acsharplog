//variaveis

int peopleCounter = 0;
int femaleCounter = 0;
int maleCounter = 0;
string gender;
int age = 0;
int femaleAge2030Counter =0;
bool entradaPermitida = true;

//recolher idade e genero

while (entradaPermitida)
{
    Console.WriteLine("Estao a entrar pessoas?");
    entradaPermitida = bool.Parse(Console.ReadLine());

    if (entradaPermitida)
    {
        Console.WriteLine("qual o seu genero? M ou F");
        gender = Console.ReadLine();

        if (gender == "F")
        {
            femaleCounter++;
            Console.WriteLine("qual a sua idade?");
            age = int.Parse(Console.ReadLine());

            if (age >= 20 && age <= 30)
            {
                femaleAge2030Counter++;
            }
        }
        else if (gender == "M")
        {
            maleCounter++;
        }
    }
}

Console.WriteLine($"Entraram {maleCounter} homens");
Console.WriteLine($"Existem {femaleCounter} mulheres");
Console.WriteLine($"Existem {femaleAge2030Counter} com idade entre 20 e 30");
