using System;

class Program
{
    static void Main()
    {
        int homem = 0;
        int mulher = 0;

        Console.WriteLine($"Before Increment: Value1 = {homem}, Value2 = {mulher}");

        // Use a for loop to repeatedly read input and increment values
        for (int i = 0; i < 5; i++) // Change the loop condition as needed
        {
            Console.Write("Enter 'H' or 'M': ");
            
            int int = int.Parse(Console.ReadLine());
            if (input == "H")
            {
                homem++;
                Console.WriteLine($"Homem:{homem} Mulher: {mulher} ");
            }
            else if (input == "M")
            {
                mulher++;
                Console.WriteLine($"Homem:{homem} Mulher: {mulher} ");
            }
            else
            {
                Console.WriteLine("H ou M, não é fisica quantica");
            }


        }

        Console.WriteLine($"Resultado Final = {homem}, Value2 = {mulher}");
    }

    
    }


