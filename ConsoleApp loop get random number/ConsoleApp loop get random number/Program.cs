﻿//jogo,
//pensar num numero ao sistema e sortear entre um limite 50 e 100
// tres perguntas ao utilizador, maxomo 10 tentativas, num loop 
//se acertar ganhamos, se nao perdemos x10 tentativas

//se nao acertar. dizer se é superior ou inferior ao palpite


//variaveis

int userChoice = 0;
int systemChoice = 0;
int pointsPlayer1 = 0;
int pointsPlayer2 = 0;
int tries = 10;
bool endGame = false;

Console.WriteLine(@"
Lets play a game. It's you versus your worst enemy! 



Game rules:

Pick a random number between 1 and 10;
Your enemy will pick another number

You have 10 tries to guess the your enemy's number.

If you guess your enemy's number, you get a point. 
If not, your enemy gets a point.

First to reach 5 points wins.");


void LetsPlayAGame()
{
    while (!endGame || tries > 0)
    {
        PickStage(userChoice, systemChoice);

        AwardStage(userChoice, systemChoice, pointsPlayer1, pointsPlayer2, tries);

        GameReview(pointsPlayer1, pointsPlayer2, endGame, tries);
    }
}

static void PickStage(int userChoice, int systemChoice)
{
    Console.WriteLine("It's your turn");
    Console.WriteLine("Pick a number between 1 a 10");
    userChoice = int.Parse(Console.ReadLine());
    Console.WriteLine("you have chosen number " + userChoice);

    Console.WriteLine("Press ENTER so your enemy picks a number");
    Console.ReadLine();
    systemChoice = GetRandomNumberBetween(1, 1000);
    Console.WriteLine("the enemy chose number " + systemChoice);
}

static void AwardStage(int userChoice, int systemChoice, int pointsPlayer1, int pointsPlayer2, int tries)
{
    if (userChoice == systemChoice)
    {
        pointsPlayer1++;
        tries--;
        Console.Write($@"
You have guessed the enemy's number!
You have {pointsPlayer1}  points
");
    }
    else
    {
        pointsPlayer2++;
        tries--;
        Console.Write($@"
You failed to guess the enemy's number!
The enemy has {pointsPlayer2}  points
");
        GameHint(userChoice, systemChoice);
    }
}

static void GameHint(int userChoice, int systemChoice)
{
    if (userChoice > systemChoice)
    {
        Console.WriteLine("Hint: Your pick was above the enemy's choice");
    }

    if (userChoice < systemChoice)
    {
        Console.WriteLine("Hint: Your pick was below the enemy's choice");
    }
}

static void GameReview(int pointsPlayer1, int pointsPlayer2, bool endGame, int tries)
{
    if (pointsPlayer1 == 5)
    {
        Console.WriteLine("You have won the game!");
        endGame = true;
    }

    if (pointsPlayer2 == 5)
    {
        Console.WriteLine("The enemy won the game!");
        endGame = true;
    }

    if (tries == 8)
    {
        endGame = true;
    }
}


static int GetRandomNumberBetween(int min, int max)
{
    int quociente = max - min;
    int aleatorio = GetRandomNumber() % quociente;
    return aleatorio + min;

    // int numero;
    // return  (GetRandomNumber() % (max - min)) + min;
}


static int GetRandomNumber()
{
    Random rnd = new Random();
    return rnd.Next();
}

LetsPlayAGame();