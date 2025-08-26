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

        enum Colors : short
        {
            Red,
            Green,
            Blu,
            Yellow
        };

        enum EmptyEnum
        {

        };

        // Tuples fuction example, a function can return multiple values
        static (bool success, string message) ValidateLogin(string username, string password)
        {
            if (username == "admin" && password == "1234")
                return (true, "Login successful");
            else
                return (false, "Invalid username or password");
        }

        // Local Functions. A function defined inside another function
        static decimal CalculateInvoiceTotal(decimal[] prices, decimal discountRate)
        {
            decimal ApplyDiscount(decimal price) => price - (price * discountRate);
            decimal ApplyTax(decimal subtotal) => subtotal * 1.1m; // 10% tax

            decimal subtotal = 0;
            foreach (var price in prices)
                subtotal += ApplyDiscount(price);

            return ApplyTax(subtotal);
        }

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

            // Tuple example
            var result = ValidateLogin("admin", "1234");
            Console.WriteLine($"Success: {result.success}, Message: {result.message}");


            decimal total = CalculateInvoiceTotal(new decimal[] { 100, 200, 50 }, 0.1m);
            Console.WriteLine(total);
        }
    }
}
