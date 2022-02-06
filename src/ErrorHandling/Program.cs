using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ErrorHandling
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Dictionary<int, string> movies = new Dictionary<int, string>();
            //try
            //{
                movies.Add(1, "a");
                movies.Add(1, "b");
                movies.Add(2, "c");
            //}
            //catch
            //{
            //    throw new ArgumentException("Houston, we have a problem.");
            //}
            //finally
            //{
            //    Console.WriteLine("You have reached the 'finally' statement.");
            //}
        }
    }
}
