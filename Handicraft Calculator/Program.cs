using System;

namespace Handicraft_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            main_calc_menu();
        }

        static void main_calc_menu ()
        {
            int operand1, operand2, result, choice;
            Console.WriteLine("Welcom to Handicraft Calculator!!! ");
        link1:
            try
            {
                Console.Write("\n"+"    Please, enter first number: ");
                operand1 = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("\n"+"    ERROR. INCORRECT VALUE OF FIRST NUMBER!");
                goto link1;
            }
        link2:
            try
            {
                Console.Write("\n"+"    Please, enter second number: ");
                operand2 = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("\n"+"    ERROR. INCORRECT VALUE OF SECOND NUMBER!");
                goto link2;
            }
        link3:
            try
            {
                Console.WriteLine("\n" + "    1 - Addition" + "\n" + "    2 - Subtraction" + "\n" + "    3 - Multiplication" + "\n" + "    4 - Division (Print the remainder)" + "\n" + "    5 - Division (Print the integer part)"+ "\n"+"\n"  + "    6 - Return on enter first operand"+ "\n" + "    7 - Return on enter second operand" + "\n"+ "    8 - Close Handicraft Calculator");
                Console.Write("\n" + "    Please, select an operation from the list and enter the relevant number: ");
                choice = Convert.ToInt32(Console.ReadLine());
                if (choice>8 | choice<1) { Console.WriteLine("\n" + "    ERROR. INCORRECT NUMBER OF CHOICE!"); goto link3; }
                if (choice == 1) 
                {
                    try { result = operand1 + operand2; } catch { Console.WriteLine("\n" + "    ERROR. CAN'T CALCULATE!"); goto link3; }
                    Console.WriteLine("\n" + $"     {operand1} + {operand2} = {operand1+operand2} ");
                    Console.WriteLine("\n" + "     Press any key to make a new calculation..");
                    Console.ReadKey();
                    goto link1;
                }
                else if (choice == 2)
                {
                    try { result = operand1 - operand2; } catch { Console.WriteLine("\n" + "    ERROR. CAN'T CALCULATE!"); goto link3; }
                    Console.WriteLine("\n" + $"     {operand1} - {operand2} = {operand1 - operand2} ");
                    Console.WriteLine("\n" + "    Press any key to make a new calculation..");
                    Console.ReadKey();
                    goto link1;
                }
                else if (choice == 3)
                {
                    try { result = operand1 * operand2; } catch { Console.WriteLine("\n" + "    ERROR. CAN'T CALCULATE!"); goto link3; }
                    Console.WriteLine("\n" + $"     {operand1} * {operand2} = {operand1 * operand2} ");
                    Console.WriteLine("\n" + "    Press any key to make a new calculation..");
                    Console.ReadKey();
                    goto link1;
                }
                else if (choice == 4)
                {
                    try { result = operand1 % operand2; } catch { Console.WriteLine("\n" + "    ERROR. CAN'T CALCULATE!"); goto link3; }
                    Console.WriteLine("\n" + $"     {operand1} % {operand2} = {operand1 % operand2} ");
                    Console.WriteLine("\n" + "    Press any key to make a new calculation..");
                    Console.ReadKey();
                    goto link1;
                }
                else if (choice == 5)
                {
                    try { result = operand1 / operand2; } catch { Console.WriteLine("\n" + "    ERROR. CAN'T CALCULATE!"); goto link3; }
                    Console.WriteLine("\n" + $"     {operand1} / {operand2} = {operand1 / operand2} ");
                    Console.WriteLine("\n" + "    Press any key to make a new calculation..");
                    Console.ReadKey();
                    goto link1;
                }
                else if (choice == 6)
                {
                    goto link1;
                }
                else if (choice == 7)
                {
                    goto link2;
                }
                else if (choice == 8)
                {        
                    Environment.Exit(0);
                }
            }
            catch
            {
                Console.WriteLine("\n" + "    ERROR Incorrect number of choice!");
                goto link3;
            }
        
            
        }
    }
}
