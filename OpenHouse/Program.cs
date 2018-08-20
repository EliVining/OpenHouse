using System;

namespace OpenHouse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to our open house!");
            Console.WriteLine();

            if (UI.UserAnswersYes("This is the living room, would you like to see more?"))
            {
                Console.WriteLine("This room has real hardwood floors.");
                Console.WriteLine("All of the furniture is new.");
                Console.WriteLine("The couch is very nice.");

                if (UI.UserAnswersYes("Wanna try it out?"))
                {
                    Console.WriteLine("There are two seats that recline.");
                }
            }

            if (UI.UserAnswersYes("Ready to go check out the kitchen?"))
            {
                Console.WriteLine("There is alot of cabinet space.");
                Console.WriteLine("The counters are granite.");
                Console.WriteLine("The lights in this room are great.");

                if (UI.UserAnswersYes("Wanna see how dark it is with them off?"))
                {
                    Console.WriteLine("Man you really can not see well with the lights off.");
                }
            }

            if (UI.UserAnswersYes("Wanna see the spare bedroom?"))
            {
                Console.WriteLine("This room has carpet.");
                Console.WriteLine("This one has a full size bed.");
                Console.WriteLine("The blinds work well.");

                if (UI.UserAnswersYes("Would you like to see?"))
                {
                    Console.WriteLine("The view overlooks the front yard.");
                }
            }

            if (UI.UserAnswersYes("Ready to see the bathroom?"))
            {
                Console.WriteLine("The sink has alot of room under it.");
                Console.WriteLine("The vent works great.");
                Console.WriteLine("This bathroom has a shower/bath combo.");

                if (UI.UserAnswersYes("Ready for the best part of the tour?"))
                {
                    Console.WriteLine("This is the master bedroom.");
                    Console.WriteLine("This room has a king sized bed.");
                    Console.WriteLine("The lights in this room are activated by clapping.");

                    Console.WriteLine("Give it a shot! just clap two times.");
                    string userResponse = Console.ReadLine();

                    if (userResponse == "clap clap")
                    {
                        Console.WriteLine("The lights also dim.");
                    }
                }

                if (UI.UserAnswersYes("The bathroom is right through that door, wanna see it?"))
                {
                    Console.WriteLine("There is a walk in shower.");
                    Console.WriteLine("There are two toilets in the master alone.");
                    Console.WriteLine("The floor has heated tile.");

                    if (UI.UserAnswersYes("Feel how hot it is?"))
                    {
                        Console.WriteLine("Alright get off of the floor.");
                    }
                }

                Console.WriteLine("In here is the closet");

                Console.WriteLine("There are two seperate sides.");
                Console.WriteLine("The sides are identical with shelves.");
                Console.WriteLine("The shelves can be adjusted.");

                if (UI.UserAnswersYes("Well, thats the end of the tour, do you like the house?"))
                {
                    if (!UI.UserAnswersYes("So are you going to buy it?"))
                    {
                        Console.WriteLine("Well then get out!");
                    }
                }
            }

            Console.ReadLine();
        }
    }
}
