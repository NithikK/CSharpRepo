using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Threading.Tasks;

namespace Frame1.Day_4
{
    public class DateDemo
    {
        public static void FirstMethod(){
            System.Console.WriteLine(DateTime.Now);
            DateTime d1 = new DateTime(2018, 04, 10); //yyyy, mm.dd
            System.Console.WriteLine(d1.ToLongDateString());//month in words
            System.Console.WriteLine(d1.ToShortDateString());//month in numbers
        }
        public static void SecondMethod()
        {
            Console.WriteLine("What is your Date of Birth (yyyy/mm/dd)");
            String strdob = Console.ReadLine();
            DateTime d1 = DateTime.Parse(strdob);
            int year = d1.Year;
            Console.WriteLine("Year OF Dob " + year);
            int month = d1.Month;
            Console.WriteLine("Month OF Dob " + month);
            int day = d1.Day;
            Console.WriteLine("Day OF Dob " + day);
            DateTime d2 = d1.AddMonths(10);
            Console.WriteLine("AddMonths(10) " + d2.ToShortDateString());
            DateTime d3 = d1.AddDays(5);
            Console.WriteLine("AddDays(5) " + d3.ToShortDateString());
            DateTime d4 = d1.AddYears(58);
            Console.WriteLine("AddYears(58) " + d4.ToShortDateString());
            DateTime d5 = d1.AddYears(-5);
            Console.WriteLine("AddYears(-5) " + d5.ToShortDateString());
        }
        public static void ThirdMethod()
        {
            try{
                Console.WriteLine("What is your Date of Birth (yyyy/mm/dd)");
                String strdob = Console.ReadLine();
                DateTime d1 = DateTime.Parse(strdob);
                DateTime d2 = DateTime.Now;
                TimeSpan ts = d2.Subtract(d1);
                DateTime age = new DateTime(ts.Ticks);
                Console.WriteLine($"Your Age is : {age.Year-1}Years, {age.Month-1}Months, {age.Day-1}Days");
            }
            catch(Exception ex){

            }
        }
        public static void ForthMethod(){
            // Prompt the user for their date of birth
            Console.WriteLine("Enter your date of birth (YYYY-MM-DD):");
            string dobString = String.Empty;
            try
            {
                dobString = Console.ReadLine();
                if (dobString == null)
                {
                    Console.WriteLine("Date Of Birth is NULL!!!");
                    return;
                }
                // Parse the date of birth
                DateTime dob = DateTime.Parse(dobString);
                // Calculate the age
                DateTime now = DateTime.Now;
                int ageYears = now.Year - dob.Year;
                if (now < dob.AddYears(ageYears))
                {
                    ageYears--;
                }
                int ageMonths = 12+(now.Month - dob.Month);
                if (now < dob.AddMonths(ageMonths).AddDays(now.Day - dob.Day))
                {
                    ageMonths--;
                }
                int ageDays = now.Day - dob.Day;
                if (now.Day < dob.Day)
                {
                    ageDays += DateTime.DaysInMonth(now.Year, now.Month);
                }
                // Print the age
                Console.WriteLine(
                    $"You are {ageYears} years, {ageMonths} months, and {ageDays} days old."
                );
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public static void FifthMethod()
        {
            try{
                Console.WriteLine("What is your Date of Birth (yyyy/mm/dd)");
                String strdob = Console.ReadLine();
                DateTime d1 = DateTime.Parse(strdob);
                int month, year, day;
                year = d1.Year+60;
                month = d1.Month;
                day = DateTime.DaysInMonth(year, month);
                /*
                Datetime nextMonth = new DateTime(d1.Year + 60, d1.Month + 1, 1);
                Datetime retier = nextMonth.AddDays(-1);
                this wont work for last month
                */
                /*
                so this
                DateTime nextMonth = dob.AddYears(60).AddMonth(1);
                DateTime retire = new DateTime(nextMonth.Year, nextMonth.Month, 1).AddDays(-1);
                */
                DateTime d2 = new DateTime(year,month,day);

                TimeSpan ts = d2.Subtract(d1);
                DateTime age = new DateTime(ts.Ticks);
                String retire = d2.ToShortDateString();
                // Print the age
                Console.WriteLine(
                    $"You are {age.Year-1} years old " +
                    $"So will retire on {retire}"
                );
                Console.WriteLine($"Your Age is : {age.Year-1}Years, {age.Month-1}Months, {age.Day-1}Days");
            }
            catch(Exception ex){
                Console.WriteLine(ex.Message);
            }
        }
    }
}