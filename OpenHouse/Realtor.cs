using System;
using System.Collections.Generic;
using System.Linq;

namespace OpenHouse
{
    public class Realtor
    {
        public string Name { get; set; }

        public void Greet()
        {
            Console.WriteLine("Hi! I'm Evan, the realtor for this home. Welcome. What's your name?");
            Console.ReadLine();
        }

        public void Speak(string message)
        {
            Console.WriteLine(message);
        }

        public void GiveRoomDescription(Room room)
        {
            foreach (string description in room.Descriptions)
            {
                Console.WriteLine(description);

            }
        }

        public void RealtorScript()
        {
            
            foreach(Room room in House.Rooms)
            {
                if (User.YesToQuestion("Would you like to see the " + room.Name + "?"))
                {
                    Console.WriteLine($"Ok. The {room.Name} has...");
                    GiveRoomDescription(room);
                }
            }
            Console.WriteLine("Well, thats all the rooms inside. Lets walk outside before you go " +
                              "so that may give you a business card.");
            Console.WriteLine("Thanks for coming. Hope to receive an offer from you soon!");

            Console.ReadLine();
        }

    }
}
