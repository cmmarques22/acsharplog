
Console.WriteLine("teste numeros inteiros, filtrar media e primos");


Console.WriteLine("Insira um numero inteiro maior que 1");
int input = int.Parse(Console.ReadLine());
if (input < 2)
{
    Console.WriteLine("numero invalido, tente outra vez"); 
    input = int.Parse(Console.ReadLine());

}

int primeSum = 0;
int primeCounter =0;


while (true)
{
    //verificar primo
    if (
        (input < 2) 
        &&  
        (input % 2 == 0))
    {
        
        
        //verificar intervalo
        if (input <= 100 && input >= 200)
        { 
            //contar numeros primos
            primeCounter++;
            
            
            
            //fazer soma dos numeros no intervalo   
            primeSum += primeCounter;
        
        } 
    }
    double primeAverage = primeSum/primeCounter ;
    Console.WriteLine($" a ssoma é de {primeSum} " + "a media de numeros primos é de {primeAverage}");
}
3

