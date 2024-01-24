using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            //string name = "Jesse";
            //string quote = "The man said, \\Hello\", Jesse. \n Hello on a new line. \n \t Hello on a tab.";   // double quotes within a string without throwing an error
            //string filename = "C:\\Users\\lily";  // double backslash tells compiler doesn't think it's an escape sequence
            //string filename2 = @"C:\Users\lily";   // @ tells compiler that everything inside double quotes is going to be a regular backslash, this works for things like really long file names

            //bool trueOrFalse = name.Contains("s");
            //trueOrFalse = name.EndsWith("s");

            //int length = name.Length;

            //name = name.ToUpper();

            //Console.WriteLine(name);
            //Console.ReadLine();

            StringBuilder sb = new StringBuilder();

            sb.Append("My name is Jesse");

            Console.WriteLine(sb);
            Console.ReadLine();

        }
    }
}
