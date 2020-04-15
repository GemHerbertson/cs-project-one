using System;

namespace cSharpProjectOne
{

    class Room {
        public double length;
        public double height;
        public double width;
    }

    class Program
    {
        static void Main(string[] args)
        {
            // declared room1 and room2 to be instances of the Room class
            Room Room1 = new Room();
            Room Room2 = new Room();
            double total = 0.0;
            String name = "Turing";

            // room1 details
            Room1.height = 5.0;
            Room1.length = 20.0;
            Room1.width = 40.9;

            // room2 details
            Room2.height = 30.3;
            Room2.length = 12.6;
            Room2.width = 26.8;

            total = Room1.height + Room1.length + Room1.width;
            Console.WriteLine("The total room size is {0} and the room name is {1}", total, name);
            Console.WriteLine("The total is: " + total + ".");

            if (name == "Turing")
            {
                Console.WriteLine("Hello {0}", name);
            }

            // prompts end of running of application through user pressing key - good for debugging
            Console.ReadKey();

        }
    }
}
