using System;

internal class Program
{
    private static void Main(string[] args)
    {
        int d = Convert.ToInt32(Console.ReadLine());
        Weekdays selectedDay;
        DayTime selectedTime;

        if (d == 1)
        {
            selectedDay = Weekdays.Monday;
        }
        else if (d == 2)
        {
            selectedDay = Weekdays.Tuesday;
        }
        else if (d == 3)
        {
            selectedDay = Weekdays.Wednesday;
        }
        else if (d == 4)
        {
            selectedDay = Weekdays.Thursday;
        }
        else if (d == 5)
        {
            selectedDay = Weekdays.Friday;
        }
        else if (d == 6)
        {
            selectedDay = Weekdays.Saturday;
        }
        else if (d == 7)
        {
            selectedDay = Weekdays.Sunday;
        }
        else
        {
            Console.WriteLine("некорректные данные!!!!!!!");
            Environment.Exit(0);
            selectedDay = Weekdays.Monday; // Пусть по умолчанию будет понедельник
        }

        int t = Convert.ToInt32(Console.ReadLine());

        if (t >= 7 && t <= 12)
        {
            selectedTime = DayTime.Morning;
        }
        else if (t >= 13 && t <= 18)
        {
            selectedTime = DayTime.Afternoon;
        }
        else if (t >= 19 && t <= 23)
        {
            selectedTime = DayTime.Evening;
        }
        else if (t >= 0 && t <= 6)
        {
            selectedTime = DayTime.Night;
        }
        else
        {
            Console.WriteLine("некорректные данные!!!!!!!!");
            Environment.Exit(0);
            selectedTime = DayTime.Morning; // Пусть по умолчанию будет утро
        }

        PrintM(selectedDay);
        PrintMessage(selectedTime);
    }

    static void PrintM(Weekdays weekday)
    {
        switch (weekday)
        {
            case Weekdays.Monday:
                Console.WriteLine("понедельник");
                break;
            case Weekdays.Tuesday:
                Console.WriteLine("вторник");
                break;
            case Weekdays.Wednesday:
                Console.WriteLine("среда");
                break;
            case Weekdays.Thursday:
                Console.WriteLine("четверг");
                break;
            case Weekdays.Friday:
                Console.WriteLine("пятница");
                break;
            case Weekdays.Saturday:
                Console.WriteLine("суббота");
                break;
            case Weekdays.Sunday:
                Console.WriteLine("воскресенье");
                break;
        }
    }

    static void PrintMessage(DayTime time)
    {
        switch (time)
        {
            case DayTime.Morning:
                Console.WriteLine("cейчас утро");
                break;
            case DayTime.Afternoon:
                Console.WriteLine("cейчас день");
                break;
            case DayTime.Evening:
                Console.WriteLine("cейчас вечер");
                break;
            case DayTime.Night:
                Console.WriteLine("cейчас ночь");
                break;
        }
    }
}

enum Weekdays
{
    Monday,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday,
    Sunday
}

enum DayTime
{
    Morning,
    Afternoon,
    Evening,
    Night
}