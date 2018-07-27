using System;

namespace OpenHouse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to our open house!");
            Console.WriteLine();

            Console.WriteLine("This is the living room, would you like to see more?");
            string userResponse = Console.ReadLine();

            if (userResponse == "yes")
            {
                Console.WriteLine("This room has real hardwood floors.");
                Console.WriteLine("All of the furniture is new.");
                Console.WriteLine("The couch is very nice.");

                Console.WriteLine("Wanna try it out?");
                userResponse = Console.ReadLine();

                if (userResponse == "yes")
                {
                    Console.WriteLine("There are two seats that recline.");
                }
            }

            Console.WriteLine("Ready to go check out the kitchen?");
            userResponse = Console.ReadLine();

            if (userResponse == "yes")
            {
                Console.WriteLine("There is alot of cabinet space.");
                Console.WriteLine("The counters are granite.");
                Console.WriteLine("The lights in this room are great.");

                Console.WriteLine("Wanna see how dark it is with them off?");
                userResponse = Console.ReadLine();

                if (userResponse == "yes")
                {
                    Console.WriteLine("Man you really can not see well with the lights off.");
                }
            }

            Console.WriteLine("Wanna see the spare bedroom?");
            userResponse = Console.ReadLine();

            if (userResponse == "yes")
            {
                Console.WriteLine("This room has carpet.");
                Console.WriteLine("This one has a full size bed.");
                Console.WriteLine("The blinds work well.");

                Console.WriteLine("Would you like to see?");
                userResponse = Console.ReadLine();

                if (userResponse == "yes")
                {
                    Console.WriteLine("The view overlooks the front yard.");
                }
            }

            Console.WriteLine("Ready to see the bathroom?");
            userResponse = Console.ReadLine();

            if (userResponse == "yes")
            {
                Console.WriteLine("The sink has alot of room under it.");
                Console.WriteLine("The vent works great.");
                Console.WriteLine("This bathroom has a shower/bath combo.");

                Console.WriteLine("Ready for the best part of the tour?");
                userResponse = Console.ReadLine();

                if (userResponse == "yes")
                {
                    Console.WriteLine("This is the master bedroom.");
                    Console.WriteLine("This room has a king sized bed.");
                    Console.WriteLine("The lights in this room are activated by clapping.");

                    Console.WriteLine("Give it a shot! just clap two times.");
                    userResponse = Console.ReadLine();

                    if (userResponse == "clap clap")
                    {
                        Console.WriteLine("The lights also dim.");
                    }
                }

                Console.WriteLine("The bathroom is right through that door, wanna see it?");
                userResponse = Console.ReadLine();

                if (userResponse == "yes")
                {
                    Console.WriteLine("There is a walk in shower.");
                    Console.WriteLine("There are two toilets in the master alone.");
                    Console.WriteLine("The floor has heated tile.");

                    Console.WriteLine("Feel how hot it is?");
                    userResponse = Console.ReadLine();

                    if (userResponse == "yes")
                    {
                        Console.WriteLine("Alright get off of the floor.");
                    }
                }

                Console.WriteLine("In here is the closet");
                
                {
                    Console.WriteLine("There are two seperate sides.");
                    Console.WriteLine("The sides are identical with shelves.");
                    Console.WriteLine("The shelves can be adjusted.");

                    Console.WriteLine("Well," +
                        "" +
                        " thats the end of the tour, do you like the house?");
                    userResponse = Console.ReadLine();

                    if (userResponse == "yes")
                    {
                        Console.WriteLine("So are you going to buy it?");
                        userResponse = Console.ReadLine();

                        if (userResponse == "no")
                        {
                            Console.WriteLine("Well then get out!");
                            userResponse = Console.ReadLine();
                        }

                    }
                }
            }
        }
    }
}
