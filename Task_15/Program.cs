/* Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет */

void isWeekend (int dayNum)
{
    if (dayNum == 6 || dayNum == 7)
    {
        Console.WriteLine("да");
    }
    else if (dayNum <6 &  dayNum > 0)
    {
        Console.WriteLine("нет");
    }
    else 
    {
        Console.WriteLine("В неделе 7 дней =)");
    }

}

Console.WriteLine("Введите порядковый номер дня недели");
int day = Convert.ToInt32(Console.ReadLine());
isWeekend(day);
