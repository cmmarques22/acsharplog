Console.WriteLine(@"
Crie uma aplicação que faça a conversão de graus Celsius para
Fahrenheit. Além de indicar o valor a converter, o utilizador
pode também inserir o tipo de conversão que pretende fazer:
Celsius → Fahrenheit ou Fahrenheit → Celsius.
");

//variaveis
string temperatureType;
double temperature;

//User prompts
Console.WriteLine(@"Select temperature type to convert
C for Celsius ----  F for Fahrenheit:");

//recolha de dados
temperatureType = Console.ReadLine().ToUpper();

//temperatureType ? "F" : "C";


static int escolheTipo(string type)
{
    if (type == "C")
    {
        Console.Write("You selected Celsius" +
                      "\nEnter a temperature to convert to Fahrenheit\n");
        temperature = double.Parse(Console.ReadLine());
        Console.WriteLine($"{temperature}{type}º is equivalent to " + ToFahrenheit(temperature).ToString("F2") + "º Fahrenheit");

    }

}

if (temperatureType == "C")
{
    Console.Write("You selected Celsius" +
                      "\nEnter a temperature to convert to Fahrenheit\n");
    temperature = double.Parse(Console.ReadLine());
    Console.WriteLine($"{temperature}{temperatureType}º is equivalent to " + ToFahrenheit(temperature).ToString("F2") + "º Fahrenheit");

}
else if (temperatureType == "F")
{
    Console.WriteLine("You selected Fahrenheit" +
                      "\nEnter a temperature to convert to Celsius\n");
    temperature = double.Parse(Console.ReadLine().ToUpper());
    
    Console.WriteLine($"{temperature}{temperatureType}º is equivalent to " + ToCelsius(temperature).ToString("F2") + "º Celsius");
}
else
{
    Console.WriteLine("Invalid temperature type selected.");
}
//excecucao do programa
static double ToFahrenheit(double temperature, string type)
{
    


    return ((temperature * 9/5) + 32);
}
double ToCelsius (double temperature)
{
    return (temperature - 32) * 5 / 9;
}


static int abs(int numro)
{
    //if numero < 0
    //{
    //    return numero + -1;
    //}
    //else return numero;
    return (numero < 0) ? numero * -1 : numero;

}
