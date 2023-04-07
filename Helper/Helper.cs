using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Struct.Helper
{
    internal static class Helper
    {

        public static void CheckMail(this string email)
        {
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            if (regex.IsMatch(email))
            {
                Console.WriteLine("Email is correct");
            }
            else
            {
                Console.WriteLine("Something went wrong Email is incorrect...");
            }
        }

        public static void MatchCount(this string sentence, string word )
        {
            string[] arr = sentence.Split(' ');
            int Count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].ToLower() == word.ToLower())
                {
                    Count++;
                }
            }
            Console.WriteLine(Count);
        }

       
        public static void CheckPolimor(this int number)
        {
            int copy = number;
            int newnum = 0;
            int mertebe;
            while(number > 0)
            {
                mertebe = number % 10;
                newnum = newnum *10 + mertebe;
                number /= 10;
            }
            if(copy == newnum)
            {
                Console.WriteLine("Polemdromdur");
            }else
            {
                Console.WriteLine("Polemdrom deyil");
            }
        }
    }
}
