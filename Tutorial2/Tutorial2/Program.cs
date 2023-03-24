using System;
using System.Drawing;

namespace Tutorial2
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type a number for date 1 in (yyyy/mm/dd) format ");
            DateTime date1 = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Type a number for date 1 in (yyyy/mm/dd) format ");
            DateTime date2 = Convert.ToDateTime(Console.ReadLine());

            TimeSpan diff = (date2 - date1);
            int total = diff.Days;
            int year = total / 365;
            int month = (total % 365) / 30;
            int day = (total % 365) % 30;
            string result = "";
            if (year > 0)
            {
                if(year == 1)
                {
                    result += Convert.ToString(year) + "year ";
                }
                else {
                    result += Convert.ToString(year) + "years ";
                }
                
            }
            if (month > 0)
            {
                if (month == 1)
                {
                    result += Convert.ToString(month) + "month ";
                }
                else
                {
                    result += Convert.ToString(month) + "months ";
                }

            }
            if (day > 0)
            {
                if (day == 1)
                {
                    result += Convert.ToString(day) + "day ";
                }
                else
                {
                    result += Convert.ToString(day) + "days ";
                }

            }
            Console.WriteLine(result);


        }
    }
}