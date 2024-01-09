using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> userInputs = new List<int> { 221233, 23000, 21762 };

        List<int> orderedFirstTwoDigits = GetOrderedFirstTwoDigitsList(userInputs);

        Console.WriteLine("First two digits in ascending order:");
        for (int i = 0; i < orderedFirstTwoDigits.Count; i++)
        {
            Console.WriteLine(orderedFirstTwoDigits[i]);
        }
    }

    static List<int> GetOrderedFirstTwoDigitsList(List<int> numbers)
    {
        List<int> firstTwoDigits = new List<int>();

        foreach (var n in numbers)
        {
            // Ensure n has at least two digits
            if (n >= 10)
            {
                // Extract the last digit
                int lastDigit = n % 10;

                // Remove the last digit
                int temp = n / 10;

                // Extract the new last digit (which is now the second-to-last digit)
                int secondToLastDigit = temp % 10;

                // Add the first two digits to the list
                firstTwoDigits.Add(secondToLastDigit * 10 + lastDigit);
            }
        }

        // Sort the list in ascending order
        firstTwoDigits.Sort();

        return firstTwoDigits;
    }
}
