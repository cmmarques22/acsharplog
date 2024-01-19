using System;


int userChoice = 0;
int enemyChoice = 0;
int userPoints = 0;
int enemyPoints = 0;
int maxTries = 15;
bool endGame = false;


Console.WriteLine("Welcome to 'Adivinhe para não ganhar nada!'");

while (!endGame && maxTries > 0)
{
    Console.WriteLine("Choose a difficulty level:");
    Console.WriteLine("1. Iniciante");
    Console.WriteLine("2. Intermédio");
    Console.WriteLine("3. Avançado");
    Console.WriteLine("4. Exit");

    int menuOption = int.Parse(Console.ReadLine());

    switch (menuOption)
    {
        case 1:
            StartGame(5, 12, 5);
            break;

        case 2:
            StartGame(5, 30, 8);
            break;

        case 3:
            StartGame(10, 50, 15);
            break;

        case 4:
            Console.WriteLine("Thanks for playing! Goodbye!");
            return;

        default:
            Console.WriteLine("Invalid choice. Please choose a valid option.");
            break;
    }
}


void StartGame(int min, int max, int maxTries)
{
    userPoints = 0;
    enemyPoints = 0;
    endGame = false;

    Console.WriteLine($"\nLet's play! You have {maxTries} tries.");

    while (!endGame && maxTries > 0)
    {
        PickStage(min, max);
        PointAwardStage();
        GameReview();
    }
}

void PickStage(int min, int max)
{
    Console.WriteLine($"\nIt's your turn. Pick a number between {min} and {max}");
    userChoice = int.Parse(Console.ReadLine());

    // Adjusted upper limit to make sure it is within the specified range
    enemyChoice = GetRandomNumberBetween(min, max + 1);
    Console.WriteLine("The enemy chose number " + enemyChoice);
}

void PointAwardStage()
{
    if (userChoice == enemyChoice)
    {
        userPoints++;
        maxTries--;
        Console.Write($"\nYou have guessed the enemy's number!\nYou have {userPoints} points\n");
    }
    else
    {
        enemyPoints++;
        maxTries--;
        Console.Write($"\nYou failed to guess the enemy's number!\nThe enemy has {enemyPoints} points\n");
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

    if (maxTries == 0)
    {
        Console.WriteLine("No more tries left. Game over!");
        endGame = true;
    }
}

int GetRandomNumberBetween(int min, int max)
{
    //int quociente = max - min;
    //int aleatorio = GetRandomNumber() % quociente;
    //return aleatorio + min;


    Random rnd = new Random();
    return rnd.Next(min, max);
}

