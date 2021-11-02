using System;

namespace Tutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            bool Repeat = true;
            Console.WriteLine("Welcome to the chatbot app\n");
            int userLimit = 5;
            while (Repeat == true)
            {

                Console.WriteLine("To use this app,select the following options\n" +
                    "Hello\n" +
                    "Bye\n" +
                    "Sup\n" +
                    "Hello there\n");


                Console.Write("Enter Your Option: ");
                string userOption = Console.ReadLine();

                //string userchoice = userOption.ToLower();
                

                if (userOption.ToLower() == "hello")
                {
                    if (userLimit == 1)
                    {
                        Console.WriteLine("You've already said that");
                    }
                    else
                    {


                        userLimit = 1;
                        Console.WriteLine("Hi, good to see you!");
                    }
                }
                
                else if (userOption.ToLower() == "sup")
                {
                    if (userLimit == 3)
                    {
                        Console.WriteLine("You've already said that");
                    }
                    else
                    {
                      
                            userLimit = 3;
                            Console.WriteLine("I am good");
                        
                    }
                }
                else if (userOption.ToLower() == "hello there")
                {
                    if (userLimit == 4)
                    {
                        Console.WriteLine("You've already said that");
                    }
                    else
                    {

                        userLimit = 4;
                        Console.WriteLine("General Kenobi");

                    }
                }
                else
                {
                    Console.WriteLine("That is not a option");
                }
                if (userOption.ToLower() == "bye") {
                    Console.WriteLine("goodbye");
                    Repeat = false;
                }




            }
           
        }
    }

    //bool shutdown = false;
    //string inputValue;
    //string outputValue = "";

    //Console.WriteLine("Computer: Hello!");

    //while (!shutdown)
    //{
    //    Console.Write("user: ");
    //    inputValue = Console.ReadLine();

    //    switch (inputValue)
    //    {
    //        case "hello":
    //            outputValue = "I've already said hello.";
    //          break;
    //    }

    //    Console.WriteLine(outputValue);

    //}

}