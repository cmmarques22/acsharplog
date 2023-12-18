int userChoice = 0;
int enemyChoice = 0;
int userPoints = 0;
int enemyPoints = 0;
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

First to reach 5 points wins, else the game ends 
after 10 tries");


void LetsPlayAGame()
{
    while (!endGame && tries > 0)
    {
        PickStage();
        PointAwardStage();
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
    enemyChoice = GetRandomNumberBetween(1, 100); // Adjusted the upper limit to 100
    Console.WriteLine("The enemy chose number " + enemyChoice);
}

void PointAwardStage()
{
    if (userChoice == enemyChoice)
    {
        userPoints++;
        tries--;
        Console.Write($@"
You have guessed the enemy's number!
You have {userPoints} points
");
    }
    else
    {
        enemyPoints++;
        tries--;
        Console.Write($@"
You failed to guess the enemy's number!
The enemy has {enemyPoints} points
");
        GameHint();
    }
}

void GameHint()
{
    if (userChoice >= enemyChoice)
    {
        Console.WriteLine("Hint: Your pick was above the enemy's choice");
    }

    else
    {
        Console.WriteLine("Hint: Your pick was below the enemy's choice");
    }
}

void GameReview()
{
    if (userPoints == 5)
    {
        Console.WriteLine("You have won the game!");
        endGame = true;
    }

    if (enemyPoints == 5)
    {
        Console.WriteLine("The enemy won the game!");
        endGame = true;
    }

    if (tries == 0)
    {
        Console.WriteLine("No more tries left. Game over!");
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