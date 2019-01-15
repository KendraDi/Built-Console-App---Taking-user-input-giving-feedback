using System;

namespace LabNumberThree
{
    class MainClass
    {
        public static void Main(string[] args)
        {//Prompting & Greeting


            bool runP = true;
            Console.WriteLine("Hello, what is your name?");
            string name = Console.ReadLine();

            while (runP == true)

            {
                Console.WriteLine("Hello, {0} please enter a number between 1 and 100!", name);

                //Do something with the input

                int x = int.Parse(Console.ReadLine());
                {
                    //correct input 

                    //odd & between 1 and 100

                    if (x % 2 != 0 && x >= 1 && x <= 100)

                    {
                        Console.WriteLine("The number entered is an odd number.");


                    }

                    //entered even and between 2 to 25

                    else if (x % 2 == 0 && x >= 2 && x <= 25)

                    {
                        Console.WriteLine("The number entered is an even number and less than 25.");

                    }

                    //entered even and between 26 to 60

                    else if (x % 2 == 0 && x >= 26 && x <= 60)

                    {
                        Console.WriteLine("That is an even number.");
                    }

                    //entered even and greater than 60

                    else if (x % 2 == 0 && x >= 60 && x <= 100)

                    {
                        Console.WriteLine("The number entered is {0}. That is an even number.", x);

                    }

                    //entered odd 

                    else if (x % 2 == 0 && x >= 60 && x <= 100)

                    {
                        Console.WriteLine("The number entered is {0}. That is an odd number.", x);

                    }


                    else  
                    {
                        //wrong input


                        Console.WriteLine("Sorry, please re-enter a correct value. Please enter a number between 1 and 100.");

                    }

                    //need to connect the two loops using runP continue 

                    runP = Continue();
                }
            }

        }
        public static bool Continue()
        {
            Console.WriteLine("Do you wish to Continue? y/n");
            string input = Console.ReadLine().ToLower();

            bool goOn;
            if (input == "y")
            {
                goOn = true;
            }
            else if (input == "n")
            {
                goOn = false;
            }
            else
            {
                Console.WriteLine("I don't understand that, let's try again");
                goOn = Continue();
            }

            return goOn;
        }



    }
    }