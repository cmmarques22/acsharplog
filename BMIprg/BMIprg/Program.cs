// BMI calculator
//apresentar programa
using Microsoft.VisualBasic;

Console.WriteLine("=====================================");
Console.WriteLine("=========Calculadora BMI=========");
Console.WriteLine("=====================================");

//obter dados
Console.WriteLine("Indica o peso");
float weight = float.Parse(Console.ReadLine());
Console.WriteLine("Indica a altura");

float height = float.Parse(Console.ReadLine()); 
float bmi;

// realizar operacoes matematicas
bmi = weight / (height*height);

//apresentacao BMI
Console.WriteLine($" a altura de {height} e o peso de {weight} resulta num BMI de {bmi}");



// o segundo operador tem de ser aberto eg: bmi <25 para a condição appanhar todos os numeros entre 24.9 e 24.999
if (bmi < 18.5)
{
    Console.WriteLine("underweight, Come um iogurte, passarinho");
} else if  ( bmi >= 18.5 && bmi < 25) {

    Console.WriteLine("Normal weight, ta normal, n sabes ler, passarinho");
}
else if (bmi >= 25 && bmi < 30) {
    Console.WriteLine("Overweight , Come meio iogurte, passarinho");
}
else if (bmi >=30 && bmi < 35)
{
    Console.WriteLine("Obesity , Come um iogurte, aproveita a vida , passarinho");
} else
{
    Console.WriteLine("Prontos a data de hoje é " + DateTime.Today + " e  são " + DateAndTime.TimeString + " horas");
}
























