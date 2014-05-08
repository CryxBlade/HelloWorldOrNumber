using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldOrNumber_Class
{
    [TestFixture]
    public class HelloWorldOrNumberTestPart2
    {
        [Test]
        public void TestUsingCorrectInteger01()
        {
            //The value of 50 should return the string "World"
            HelloWorldOrNumberPart2 source = new HelloWorldOrNumberPart2();
            string testResult = source.CheckForMultiplesPart2(50);
            Assert.AreEqual(testResult, "World");
        }

        [Test]
        public void TestUsingCorrectString01()
        {
            //The value of 50 should return the string "World"
            HelloWorldOrNumberPart2 source = new HelloWorldOrNumberPart2();
            string testResult = source.CheckForMultiplesPart2("50");
            Assert.AreEqual(testResult, "World");
        }

        [Test]
        public void TestUsingCorrectInteger02()
        {
            //The value of 300 should return the string "HelloWorld"
            HelloWorldOrNumberPart2 source = new HelloWorldOrNumberPart2();
            string testResult = source.CheckForMultiplesPart2(300);
            Assert.AreEqual(testResult, "HelloWorld");
        }

        [Test]
        public void TestUsingCorrectString02()
        {
            //The value of 300 should return the string "HelloWorld"
            HelloWorldOrNumberPart2 source = new HelloWorldOrNumberPart2();
            string testResult = source.CheckForMultiplesPart2("300");
            Assert.AreEqual(testResult, "HelloWorld");
        }


        [Test]
        public void TestUsingCorrectInteger03()
        {
            //The value of 1 should return the string "1"
            HelloWorldOrNumberPart2 source = new HelloWorldOrNumberPart2();
            string testResult = source.CheckForMultiplesPart2(1);
            Assert.AreEqual(testResult, "1");
        }

        [Test]
        public void TestUsingCorrectString03()
        {
            //The value of 1 should return the string "1"
            HelloWorldOrNumberPart2 source = new HelloWorldOrNumberPart2();
            string testResult = source.CheckForMultiplesPart2("1");
            Assert.AreEqual(testResult, "1");
        }

        [Test]
        public void TestUsingInvalidInteger()
        {
            HelloWorldOrNumberPart2 source = new HelloWorldOrNumberPart2();
            string testResult = source.CheckForMultiplesPart2(-95);
            Assert.AreEqual(testResult, "Not a Positive Number");
        }

        [Test]
        public void TestUsingInvalidString()
        {
            HelloWorldOrNumberPart2 source = new HelloWorldOrNumberPart2();
            string testResult = source.CheckForMultiplesPart2("hello");
            Assert.AreEqual(testResult, "hello is not a valid number");
        }


    }

    public class HelloWorldOrNumberPart2
    {

        /// <summary>
        /// Overload that takes a string input and passes to check for multiple conditions.
        /// </summary>
        /// <param name="inputString">the input string which should convert to an integer</param>
        /// <returns>the result as either invalid or valid response</returns>
        public string CheckForMultiplesPart2(string inputString)
        {
            //Variables
            //used to contain the parsed string as an integer if valid
            int outputNumber;
            //attempts to parse the input string and sets as true or false
            bool stringIsValid = Int32.TryParse(inputString, out outputNumber);

            //if the string is a valid integer pass it to the CheckForMultiples method. if invalid returns a response
            if (stringIsValid)
            {
                return CheckForMultiplesPart2(outputNumber);
            }
            else
            {
                return inputString += " is not a valid number";
            }
        }

        /// <summary>
        /// Takes an input and checks to see if it has multiples 
        /// </summary>
        /// <param name="input">the int to be checked for multiples</param>
        /// <returns>a string with either the original value or the approriate response for the multiple</returns>
        public string CheckForMultiplesPart2(int input)
        {
            //Variables
            //used to contain the return value string
            string result = string.Empty;
            //used to identify if a number is a multiple of three as a boolean
            bool multipleOfThree = false;
            //used to identify if a number is a multiple of five as a boolean
            bool multipleOfFive = false;

            //Check to see if the value being passed is a positive number
            if (input >= 0)
            {
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
            }
            else
            {
                //Number is not positive so return error message
                result = "Not a Positive Number";
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
