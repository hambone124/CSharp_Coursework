using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            //string myString = "What if I need a \nnew line";
            //string myString = "Got to your C:\\ drive";
            //string myString = @"Got to your C:\ drive";
            //string myString = String.Format("{0} = {1}", "First", "Second");
            //string myString = String.Format("{0:C}", 123.45);
            //string myString = String.Format("{0:N}", 12312312421445);
            //string myString = String.Format("{0:P}",.45);
            //string myString = String.Format("{0:(###) ###-####}", 1231231245);
            string myString = " That summer we took threes across the board ";
            //myString = myString.Substring(6,14);
            //myString = myString.ToUpper();
            myString = string.Format("Length before: {0} -- Length after: {1}",
                myString.Length,
                myString.Trim().Length
            );
            Console.WriteLine(myString);
            Console.ReadLine();
        }
    }
    class Ham
    {

    }
}
