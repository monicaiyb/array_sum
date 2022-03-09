using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// namespace declaration
namespace array_sum
{
    // Class declaration
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 2, 3 };
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            // statement
            // printing sum
            Console.WriteLine(sum);

            // To prevents the screen from 
            // running and closing quickly
            Console.ReadKey();
        }
    }
}
