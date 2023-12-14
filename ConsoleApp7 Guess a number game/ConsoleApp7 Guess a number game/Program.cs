int userChoice = 0;
int systemChoice = 0;
int pointsPlayer1 = 0;
int pointsPlayer2 = 0;
int tries = 10;
bool endGame = false;


Console.WriteLine(@"
Let's play a game. It's you versus your worst enemy!

Game rules:

Pick a random number between 1 and 10;
Your enemy will pick another number

You have 10 tries to guess your enemy's number.

If you guess your enemy's number, you get a point.
If not, your enemy gets a point.

First to reach 5 points wins.");


void LetsPlayAGame()
{
    while (!endGame && tries > 0)
    {
        PickStage();
        AwardStage();
        GameReview();
    }
}

void PickStage()
{
    Console.WriteLine("It's your turn");
    Console.WriteLine("Pick a number between 1 and 10");
    userChoice = int.Parse(Console.ReadLine());
    Console.WriteLine("You have chosen number " + userChoice);

    Console.WriteLine("Press ENTER so your enemy picks a number");
    Console.ReadLine();
    systemChoice = GetRandomNumberBetween(1, 10); // Adjusted the upper limit to 100
    Console.WriteLine("The enemy chose number " + systemChoice);
}

void AwardStage()
{
    if (userChoice == systemChoice)
    {
        pointsPlayer1++;
        tries--;
        Console.Write($@"
You have guessed the enemy's number!
You have {pointsPlayer1} points
");
    }
    else
    {
        pointsPlayer2++;
        tries--;
        Console.Write($@"
You failed to guess the enemy's number!
The enemy has {pointsPlayer2} points
");
        GameHint();
    }
}

void GameHint()
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

void GameReview()
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

    if (tries == 0)
    {
        Console.WriteLine("No more tries left. Game over!");
        endGame = true;
    }
}



static int GetRandomNumberBetween2(int min, int max)
{
    Random rnd = new Random();
    return rnd.Next(min, max);
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