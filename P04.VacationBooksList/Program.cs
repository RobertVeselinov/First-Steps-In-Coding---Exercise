using System;

namespace P04.VacationBooksList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pages = int.Parse(Console.ReadLine());
            int pagesForHour = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());
            int hours = (pages / pagesForHour) / days;
            Console.WriteLine(hours);
        }
    }
}
