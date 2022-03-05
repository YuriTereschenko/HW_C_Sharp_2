/* Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6 */


void get2ndNumber (int number)
{
    string result = Convert.ToString(number);
    if (number > 99)
    {
        while (number > 999) 
        {
            number /= 10;
        }
        
        number = number %100 %10;
        Console.WriteLine("Третья цифра " + number);
    }
    else
    {
        Console.WriteLine("Третьей цифры нет");
    } 
} 


Console.WriteLine("Введите число");
int inputNumber = Convert.ToInt32(Console.ReadLine());
get2ndNumber(inputNumber); 