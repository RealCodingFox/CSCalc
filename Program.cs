using System;

namespace Calculator
{
    internal class Program
    {
        static void exit()
        {
            Console.WriteLine("Exiting...");
        }
        static void displayOptions()
        {
            Console.WriteLine("*----------------------------------------------------*");
            Console.WriteLine("|                     CALCULATOR                     |");
            Console.WriteLine("|                     Functions:                     |");
            Console.WriteLine("|                    1:Addition(+)                   |");
            Console.WriteLine("|                   2:Subtraction(-)                 |");
            Console.WriteLine("|                 3:Multiplication(x)                |");
            Console.WriteLine("|                   4:Division(÷)                    |");
            Console.WriteLine("*----------------------------------------------------*");
            Console.WriteLine("Please choose an option, from 1 to 4.");
        }

        static void calc()
        {
            displayOptions();
            string function = Console.ReadLine();
            if (function=="1") {
                Console.WriteLine("You selected addition.");
            }

            else if (function=="2") {
                Console.WriteLine("You selected subtraction.");
            }

            else if (function=="3") {
                Console.WriteLine("You selected multiplication.");
            }

            else if (function=="4") {
                Console.WriteLine("You selected division.");
            }
            else
            {
                Console.WriteLine("Please choose an option from 1 to 4. "+function+" is not a valid option.");
                calc();
            }

            if (function == "1")
            {
                Console.WriteLine("Please type number 1.");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please type number 2.");
                int num2 = Convert.ToInt32(Console.ReadLine());
                int result = num1 + num2;
                Console.WriteLine(num1+"+"+num2+"="+result);
            }
            if (function == "2")
            {
                Console.WriteLine("Please type number 1.");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please type number 2.");
                int num2 = Convert.ToInt32(Console.ReadLine());
                int result = num1 - num2;
                Console.WriteLine(num1+"-"+num2+"="+result);
            }
            if (function == "3")
            {
                Console.WriteLine("Please type number 1.");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please type number 2.");
                int num2 = Convert.ToInt32(Console.ReadLine());
                int result = num1 * num2;
                Console.WriteLine(num1+"x"+num2+"="+result);
            }
            if (function == "4")
            {
                Console.WriteLine("Please type number 1.");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please type number 2.");
                int num2 = Convert.ToInt32(Console.ReadLine());
                int result = num1 / num2;
                Console.WriteLine(num1+"÷"+num2+"="+result);
            }
            Console.WriteLine("Do you want to do another calculation?");
            Console.WriteLine("(Y / N))");
            string yesno = Console.ReadLine();
            if(yesno == "y") {
                calc();
            } else if (yesno == "Y") {
                calc();
            } else if (yesno == "n") {
                exit();
            } else if (yesno == "N") {
                exit();
            } else {
                checkyn();
            }
            
        }

        static void checkyn()
        {
            Console.WriteLine("Please type"+"Y"+"/"+"N");
            string yesno = Console.ReadLine();
            if(yesno == "y") {
                calc();
            } else if (yesno == "Y") {
                calc();
            } else if (yesno == "n") {
                exit();
            } else if (yesno == "N") {
                exit();
            } else {
                checkyn();
            }
        }


        public static void Main(string[] args)
        {
            calc();
        }
    }
}