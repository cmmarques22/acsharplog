//apresentar programa
Console.WriteLine("=====================================");
Console.WriteLine("Programa de descontos para vacinas");
Console.WriteLine("=====================================");



Console.Write("Qual o comprimento do seu cao?: ");
double comprimentoCao = double.Parse(Console.ReadLine());
string generoCao = Console.ReadLine();

if ((comprimentoCao >= 10 || comprimentoCao <15) && generoCao == "F") {
        Console.WriteLine("tem direito a um desconto de 10%");
}
else if ((comprimentoCao >= 15 || comprimentoCao < 20) && generoCao == "M")
{
    Console.WriteLine("tem direito a um desconto de 9%");
}

else if ((comprimentoCao >= 15 || comprimentoCao < 20) && generoCao == "F")
{
    Console.WriteLine("tem direito a um desconto de 8%");
}
else if ((comprimentoCao >= 20  || comprimentoCao < 25) && (generoCao == "F" || generoCao == "M"))
{
    Console.WriteLine("tem direito a um desconto de 8%");
}
else
{
    Console.WriteLine("tem direito a um desconto de 5%");

}




