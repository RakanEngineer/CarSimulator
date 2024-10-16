using System;
using System.Runtime.ConstrainedExecution;
using System.Threading;
using static System.Console;

namespace CarSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            bool shouldNotExit = true;

            uint carListCurrentIndexPosition = 0;

            while (shouldNotExit)
            {
                WriteLine("1. Add car");
                WriteLine("2. List cars");
                WriteLine("3. Change registration number");
                WriteLine("4. Simulate speed");
                WriteLine("5. Exit");

                ConsoleKeyInfo keyPressed = ReadKey(true);

                Clear();

                switch (keyPressed.Key)
                {
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:
                        {
                            // Nu behöver vi inte sätta in själv brand, model
                            // nu vill vi välja vilken bil är den istället.
                            // nu har vi en class som reperestera TeslaModel3, Volvo240
                            // så ända behöver vi registration number.

                            Write("Registration number: ");

                            string registrationNumber = ReadLine();

                            WriteLine("Choose Car: ");

                            WriteLine("1. Tesla, Model 3");

                            WriteLine("2. Volvo, 240");

                            keyPressed = ReadKey(true);



                            break;

                        }


                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:

                        break;



                    case ConsoleKey.D3:
                    case ConsoleKey.NumPad3:


                        break;

                    case ConsoleKey.D4:
                    case ConsoleKey.NumPad4:



                        break;

                        Clear();
                }
            }
        }
    }
}

        
    
