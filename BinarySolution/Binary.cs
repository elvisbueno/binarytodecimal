using System;
namespace BinarySolution
{
    public class Binary
    {
        
        public static int input_1;
        public static int input_2;
        public static int input_3;
        public static int input_4;
        public static int input_5;
        public static int input_6;
        public static int input_7;
        public static int input_8;

        public static int record_input_1;
        public static int record_input_2;
        public static int record_input_3;
        public static int record_input_4;
        public static int record_input_5;
        public static int record_input_6;
        public static int record_input_7;
        public static int record_input_8;

        public static void getDecimalValue()
        {
            Console.WriteLine("Welcome to ELvis Bueno \"Get Your Binary Value Program\".");
            Console.WriteLine("Enter, 1st binary number:");
            while (!int.TryParse(Console.ReadLine(), out input_1) || (input_1 < 0 || input_1 > 1))
            {
                Console.WriteLine("Invalid Entry, enter a 1 or a 0:");
            }
            record_input_1 = input_1;
            if (input_1 == 1)
            {
                input_1 = 1;
            }
            else
            {
                input_1 = 0;
               
            }

            Console.WriteLine("Enter, 2nd binary number:");
            while (!int.TryParse(Console.ReadLine(), out input_2) || (input_2 < 0 || input_2 > 1))
            {
                Console.WriteLine("Invalid Entry, enter a 1 or a 0:");
            }
            record_input_2 = input_2;
            if (input_2 == 1)
            {
                input_2 = 2;
            }
            else
            {
                input_2 = 0;

            }

            Console.WriteLine("Enter, 3rd binary number:");
            while (!int.TryParse(Console.ReadLine(), out input_3) || (input_3 < 0 || input_3 > 1))
            {
                Console.WriteLine("Invalid Entry, enter a 1 or a 0:");
            }
            record_input_3 = input_3;
            if (input_3 == 1)
            {
                input_3 = 4;
            }
            else
            {
                input_3 = 0;

            }

            Console.WriteLine("Enter, 4th binary number:");
            while (!int.TryParse(Console.ReadLine(), out input_4) || (input_4 < 0 || input_4 > 1))
            {
                Console.WriteLine("Invalid Entry, enter a 1 or a 0:");
            }
            record_input_4 = input_4;
            if (input_4 == 1)
            {
                input_4 = 8;
            }
            else
            {
                input_4 = 0;

            }

            Console.WriteLine("Enter, 5th binary number:");
            while (!int.TryParse(Console.ReadLine(), out input_5) || (input_5 < 0 || input_5 > 1))
            {
                Console.WriteLine("Invalid Entry, enter a 1 or a 0:");
            }
            record_input_5 = input_5;
            if (input_5 == 1)
            {
                input_5 = 16;
            }
            else
            {
                input_5 = 0;

            }

            Console.WriteLine("Enter, 6th binary number:");
            while (!int.TryParse(Console.ReadLine(), out input_6) || (input_6 < 0 || input_6 > 1))
            {
                Console.WriteLine("Invalid Entry, enter a 1 or a 0:");
            }
            record_input_6 = input_6;
            if (input_6 == 1)
            {
                input_6 = 32;
            }
            else
            {
                input_6 = 0;

            }

            Console.WriteLine("Enter, 7th binary number:");
            while (!int.TryParse(Console.ReadLine(), out input_7) || (input_7 < 0 || input_7 > 1))
            {
                Console.WriteLine("Invalid Entry, enter a 1 or a 0:");
            }
            record_input_7 = input_7;
            if (input_7 == 1)
            {
                input_7 = 64;
            }
            else
            {
                input_7 = 0;

            }

            Console.WriteLine("Enter, 8th binary number:");
            while (!int.TryParse(Console.ReadLine(), out input_8) || (input_8 < 0 || input_8 > 1))
            {
                Console.WriteLine("Invalid Entry, enter a 1 or a 0:");
            }
            record_input_8 = input_8;
            if (input_8 == 1)
            {
                input_8 = 128;
            }
            else
            {
                input_8 = 0;

            }



            int results = input_1 + input_2 + input_3 + input_4 + input_5 + input_6 + input_7 + input_8;
            Console.WriteLine("\n"+"(128)"+record_input_8 + " " +"(64)"+ record_input_7 + " " +"(32)"+ record_input_6 + " " +"(16)"+ record_input_5 + " " +"(8)"+ record_input_4 + " " +"(4)"+ record_input_3 + " " +"(2)"+ record_input_2 + " " +"(1)"+ record_input_1 + " = " + results);
            Console.WriteLine("---------Process Completed--------------------");




        }
    }
}
