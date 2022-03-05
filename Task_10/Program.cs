/* Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1 */


void Get2ndLetter (int number)
{
int result = number/10%10;
Console.WriteLine("Вторая цифра числа " + result);
}
 
 
Console.WriteLine("Введите трехзначное число");
int inputNumber= Convert.ToInt32(Console.ReadLine());
Get2ndLetter(inputNumber);




/*  Альтернативное решение

void Get2ndLetter (string number)
{
string result =  number.Remove(0, 1);
result = result.Remove(1, 1);
Console.WriteLine("Вторая цифра числа " + result);
}

string inputNumber = Console.ReadLine();
Get2ndLetter(inputNumber); */