using System;
using System.Reflection.Metadata.Ecma335;
using System.Transactions;

namespace simpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            bool loop = true;
            bool firstNum = false;
            int action = 0;
            double firstVal = 0, secondVal = 0;

            Console.WriteLine("     Welcome to Alberts Oversimplified Command Prompt Calculator!\n");                   //into and variables

            while (loop)                                                                                                 //loop to continue with the calulations
            {
                if (firstNum == false)
                {
                    Console.Write("Enter the first value: ");
                    firstVal = Convert.ToDouble(Console.ReadLine());                                                        //will display once untill user selects start over
                    firstNum = true;
                }

                Console.WriteLine("\nWhat Would you like to do with the number " + firstVal + "?\n\n");
      
                Console.WriteLine("     Add:         1");
                Console.WriteLine("     Subtract:    2");
                Console.WriteLine("     Multiply:    3");
                Console.WriteLine("     Divide:      4");
                Console.WriteLine("     Raise Power: 5");                                                                           //prompt menu
                Console.WriteLine("     Square Root: 6");
                Console.WriteLine("     Start Over:  7");
                Console.WriteLine("     QUIT:        8");

                Console.Write("\n\nEnter the number corresponding to the arethmetic opperation you would like to do: ");
                action = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                switch (action)
                {
                    case 1:
                        {
                            Console.Write("Enter the Second Value: ");
                            secondVal = Convert.ToDouble(Console.ReadLine());                                                               //add
                            Console.WriteLine(firstVal + " + " + secondVal + " = " + (add(firstVal, secondVal)));                             
                            firstVal = add(firstVal, secondVal);
                        }
                        break;

                    case 2:
                        {
                            Console.Write("Enter the Second Value: ");
                            secondVal = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine(firstVal + " - " + secondVal + " = " + (subtract(firstVal, secondVal)));                      //subract 
                            firstVal = subtract(firstVal, secondVal);
                        }
                        break;

                    case 3:
                        {
                            Console.Write("Enter the Second Value: ");
                            secondVal = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine(firstVal + " * " + secondVal + " = " + (multiply(firstVal, secondVal)));                      //multiply
                            firstVal = multiply(firstVal, secondVal);
                        }
                        break;

                    case 4:
                        {
                            Console.Write("Enter the Second Value: ");
                            secondVal = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine(firstVal + " / " + secondVal + " = " + (divide(firstVal, secondVal)));                        //divide
                            firstVal = divide(firstVal, secondVal);
                        }
                        break;

                    case 5:
                        {
                            Console.Write("Enter the Second Value: ");
                            secondVal = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine(firstVal + " ^ " + secondVal + " = " + (pow(firstVal, secondVal)));                         //power
                            firstVal = pow(firstVal, secondVal);
                        }
                        break;

                    case 6:
                        {
                            Console.WriteLine(" Square Root of " + firstVal + " is " + (sqrt(firstVal)));                                   //square root
                            firstVal = sqrt(firstVal);
                        }
                        break;

                    case 7:
                        { firstNum = false; }                                                                                               // start over flag
                        break;

                    case 8:
                        { loop = false; }                                                                                                      //exit the loop flag
                        break;

                    default:
                        { firstNum = false; }                                                                                               //incase user selects something else then (1-8) will start over
                        break;
                }
            }
        }

        static double add(double A, double B)
        { return A + B; }

        static double subtract(double A, double B)
        { return A - B; }

        static double multiply(double A, double B)
        { return A * B; }
                                                               //Arethmetic return functions 
        static double divide(double A, double B)
        { return A / B; }

        static double pow(double A, double B)
        { return Math.Pow(A, B); }

        static double sqrt(double A)
        { return Math.Sqrt(A); }

    }
}
