using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Tokenize string as per the example
 * Input
 * This is a "Sample Text" You can modify it
 * Output
 * This
 * is 
 * a
 * "Sample Text"
 * You
 * can
 * modify
 * it
 */

namespace Siemens
{
    class TokenizeString
    {
        public static void Main(string[] args)
        {
            string data = Console.ReadLine();
            var stringValues = GetTokenizedString(data);

            foreach(var s in stringValues)
            {
                Console.WriteLine(s);
            }
        }

        public static IList<string> GetTokenizedString(string data)
        {
            return data.Split('"').Select((val, i) => i % 2 == 0
                                           ? val.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                                           : new string[] { '"' + val + '"' })
                .SelectMany(val => val).ToList();
        }
    }
}
