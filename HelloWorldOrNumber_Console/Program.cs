using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldOrNumber_Console
{
    class Program
    {
        public static void Main()
        {
            //Create a new instance of the HelloWorldOrNumber_Class 
            HelloWorldOrNumber_Class.HelloWorldOrNumber helloClass = new HelloWorldOrNumber_Class.HelloWorldOrNumber();

            //Starting at 1 count up to 100
            for (var i = 1; i <= 100; i++)
            {
                //Check the input value and write the result to the screen
                Console.WriteLine(helloClass.CheckForMultiples(i));
            }
            //Put in place to allow the results to be read before the console window closes
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
