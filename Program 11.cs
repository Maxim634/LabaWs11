using System;
class Program
{
    delegate string GetNextDayOfWeek();

    static void Main()
    {
        string[] daysOfWeek = { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье" };
        int currentDayIndex = -1;

        GetNextDayOfWeek getNextDay = () =>
        {
            currentDayIndex = (currentDayIndex + 1) % daysOfWeek.Length;
            return daysOfWeek[currentDayIndex];
        };

        for (int i = 0; i < 100; i++)
        {
            string nextDay = getNextDay();
            Console.WriteLine("Следующий день недели: " + nextDay);
        }
    }
}