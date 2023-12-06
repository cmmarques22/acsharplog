Console.WriteLine(@"O organismo público responsável pela meteorologia
 em Portugal necessita de fazer um estudo acerca da temperatura na 
cidade do Porto. 

Crie uma aplicação capaz de recolher durante n dias a temperatura, e no final,
informar qual o pico de calor ocorrido, assim como a média das temperaturas
recolhidas. Em cada dia apenas será efetuada uma única recolha.");

//apresentar variaveis

int dayCounter = 0;
int totalDays;
double temperature;
double peakTemperature = 0;
double totalTemperatureSum =0;
double averageTemperature = 0;

Console.WriteLine("Quantos dias vamos analisar?");
totalDays = int.Parse(Console.ReadLine());

// verificar temperaturas
while (dayCounter < totalDays)
{
    Console.WriteLine("Qual a temperatura de hoje?");
    temperature = int.Parse(Console.ReadLine());

    if (temperature > peakTemperature)
    {
        peakTemperature = temperature;
    }
    totalTemperatureSum += temperature;
        
    dayCounter++;
}

//average temperature calculation
averageTemperature = totalTemperatureSum / totalDays;

Console.WriteLine($"a temperatura media durante os dias analisados e de {averageTemperature}");
Console.WriteLine($"a temperatura maxima registada e de  {peakTemperature}");
