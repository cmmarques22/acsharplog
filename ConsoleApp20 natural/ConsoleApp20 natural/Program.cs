Console.WriteLine("Enter an integer to define the size of the interval:");

// Read the input as a string and parse it to an integer
int input = int.Parse(Console.ReadLine());

// Ensure the input is non-negative
if (input < 0)
{
    // Math.Abs(input);
    input = (input * -1);
}

int sum = 0;
int counter = 1;

// String to store the formatted numbers
string formattedNumbers = "";

// Calculate the sum of numbers from 1 to input
while (counter <= input)
{
    sum += counter;

    // Add the current number to the formatted string
    formattedNumbers += counter;
    formattedNumbers += " + ";
    counter++;
}
// Display the result
Console.WriteLine($"The sum of numbers from 1 to {input} is: {formattedNumbers} = {sum}");

