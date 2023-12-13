for (int i = 0; i < 10; i++)
{
    Console.WriteLine(GetRandomNumberBetween(100,500));

}

//jogo,
//pensar num numero ao sistema e sortear entre um limite 50 e 100
// tres perguntas ao utilizador, maxomo 10 tentativas, num loop 
//se acertar ganhamos, se nao perdemos x10 tentativas

//se nao acertar. dizer se é superior ou inferior ao palpite


Console.WriteLine("insira um digito entre 1 a 100");
Console.WriteLine(GetRandomNumberBetween(1,100));

int userChoice;
int systemChoice;
userChoice = int.Parse(Console.ReadLine());
systemChoice = GetRandomNumber();

if (userChoice == 0)
{
    
}

static int GetRandomNumberBetween(int min, int max)
{
    int quociente = max - min;
    int aleatorio = GetRandomNumber() % quociente;
    return aleatorio + min;

    // int numero;
    // return  (GetRandomNumber() % (max - min)) + min;
}

GetRandomNumber();
static int GetRandomNumber()
{
    Random rnd = new Random();
    return rnd.Next() ;
}

