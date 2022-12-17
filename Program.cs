//Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
//4 -> да
//-3 -> нет
//7 -> нет
Console.WriteLine("Введите первое число");
string numberStr = Console.ReadLine() ??"";
int number = int.Parse(numberStr);
int result = number;
if ( number%2==0) 
{
    Console.WriteLine($"число {number} явялется четным");
}
else
Console.WriteLine($"число {number} не явялется четным");