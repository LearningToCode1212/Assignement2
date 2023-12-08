using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class ConvertToText
    {
        public static string convert(int input)
        {
            string[] unitsMap = {" ", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};
            string[] tensMap = { " ", "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };
            string[] teens = { " ", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };

            if (input == 0)
            {
                return "zero";
            }
            else if (input > 999 & input < 9999)
            {
                if (input % 1000 >= 100 && input % 100 <= 19)
                {
                    return unitsMap[(input / 1000)] + " Thousand " +  unitsMap[input / 1000 % 100] + " Hundred " + teens[input % 10];
                }
                return unitsMap[(input / 1000)] + " Thousand " + unitsMap[input / 100 % 10] + " Hundred " + tensMap[input % 100 / 10] + " " + unitsMap[input % 10];
            }
            else if (input > 99 & input < 999)
            {
                if (input % 100 >= 10 && input % 100 <= 19)
                {
                    return unitsMap[input / 100] + " Hundred " + teens[input % 10];  
                }
                return unitsMap[input / 100] + " Hundred " + tensMap[input % 100 / 10] + " " + unitsMap[input % 10];
            }
            else if (input > 0 & input <= 90)
            {
                return tensMap[input / 10] + " " + unitsMap[input % 10];
            }
            else if (input > 10 & input < 20)
            {
                return teens[input - 10];
            }
            else
            {
                return unitsMap[input];
            }
            //Console.WriteLine(unitsMap[4]);
            return "";
        }
    }
}
