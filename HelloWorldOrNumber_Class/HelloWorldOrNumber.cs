using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldOrNumber_Class
{
    public class HelloWorldOrNumber
    {

        /// <summary>
        /// Takes an input and checks to see if it has multiples 
        /// </summary>
        /// <param name="input">the int to be checked for multiples</param>
        /// <returns>a string with either the original value or the approriate response for the multiple</returns>
        public string CheckForMultiples(int input)
        {
            //Variables
            //used to contain the return value string
            string result = string.Empty;
            //used to identify if a number is a multiple of three as a boolean
            bool multipleOfThree = false;
            //used to identify if a number is a multiple of five as a boolean
            bool multipleOfFive = false;

            //Check if the input is a multiple of three
            if (IsInputMultipleOfThree(input))
            {
                //set the variable for multipleOfThree to true and result string to "Hello"
                multipleOfThree = true;
                result = "Hello";
            }

            //Check if the input is a multiple of five
            if (IsInputMultipleOfFive(input))
            {
                //set the variable for multipleOfFive to true and result string to "World"
                multipleOfFive = true;
                result = "World";
            }

            //if the two boolean variables multipleOfThree and multipleOfFive are true then set the return string to "HelloWorld" 
            if (multipleOfThree && multipleOfFive)
            {
                result = "HelloWorld";
            }

            //if the two boolean variables multipleOfThree and multipleOfFive are false then set the return string to the input value 
            if (!multipleOfThree && !multipleOfFive)
            {
                result = input.ToString();
            }

            return result;
        }

        /// <summary>
        /// Check to see if an input value is a multiple of 3
        /// </summary>
        /// <param name="input">the input value to be checked as an int</param>
        /// <returns>true or false</returns>
        private bool IsInputMultipleOfThree(int input)
        {
            if (input % 3 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Check to see if an input value is a multiple of 5
        /// </summary>
        /// <param name="input">the input value to be checked as an int</param>
        /// <returns>true or false</returns>
        private bool IsInputMultipleOfFive(int input)
        {
            if (input % 5 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
