using System.Runtime.InteropServices;
using System;

namespace CSharpPractice
{
    internal class Program
    {
        // Accessable from this program only
        enum Days
        {
            Sunday,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday
        };

        enum Colors: short
        {
            Red,
            Green,
            Blu,
            Yellow
        };

        enum EmptyEnum
        {
            
        };

        static void Main(string[] args)
        {
            //Enum data type?
            Days today = Days.Monday;
            Console.WriteLine(today); // Monday
            Console.WriteLine((int)today); // 1
            Console.WriteLine(sizeof(Days)); // 4 bytes, 32 bits int by default
            Console.WriteLine(sizeof(Colors)); // 2 bytes, 16 bits short
            Console.WriteLine(sizeof(EmptyEnum)); // 4 bytes, 32 bits int by default
           
            // - Each value is stored as a byte(1 byte) in memory.
            // - By default, the first enumerator has the value 0, and the value of each successive enumerator is increased by 1.
            Days day = (Days)1;
            Console.WriteLine(day); // Monday
            // We can also cast an integer to an enum

            Days newDay = (Days)99;
            Console.WriteLine(newDay); // 99 (As no name associated)
        }
    }
}
