using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a random number: ");
        string input = Console.ReadLine();

        if (int.TryParse(input, out int number))
        {
            int digitSum = CalculateDigitSum(number);
            Console.WriteLine($"Sum of digits: {digitSum}");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
        }
    }

    static int CalculateDigitSum(int number)
    {
        int sum = 0;

        string numberString = number.ToString();

        for (int i = 0; i < numberString.Length; i++)
        {
            if (int.TryParse(numberString[i].ToString(), out int digit))
            {
                sum += digit;
            }
        }

        return sum;
    }
}
