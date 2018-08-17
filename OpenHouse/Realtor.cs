using System;
using System.Collections.Generic;
using System.Linq;

namespace OpenHouse
{
    public class Realtor
    {
        public string Name { get; private set; }
        private User Viewer { get; set; }
        public void Greet()
        {
            Console.WriteLine("Hi! I'm " + Name + ", the realtor for this home. Welcome. What's your name?");
            string response = Console.ReadLine();
            Viewer = new User(response);
            Console.WriteLine("Welcome " + Viewer.Name + " to the open house!");
        }
        public Realtor(string name)
        {
            Name = name;
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
            List<string> PositiveResponse = new List<string> { "yes", "yea", "sure", "ok", "si", "ye" };
            List<string> NegativeResponse = new List<string> { "no", "not right now", "no thanks", "no. thanks.", "not today" };

            for (int i = 0; i < House.Rooms.Count;)
            {
                Console.WriteLine("Would you like to see the " + House.Rooms[i].Name + "?");

                string answer = Console.ReadLine();

                foreach (string PossibleNegativeResponse in NegativeResponse)
                {
                    
                    if (answer == PossibleNegativeResponse)
                    {
                         i++;
                    }
                }
                foreach (string PossiblePositiveResponses in PositiveResponse)
                {
                    if (answer == PossiblePositiveResponses)
                    {
                        Console.WriteLine($"Ok. The {House.Rooms[i].Name} has...");
                        GiveRoomDescription(House.Rooms[i]);
                        i++;
                    }

                }
            }
            Console.WriteLine("Well, thats all the rooms inside. Lets walk outside before you go " +
                              "so that may give you a business card.");
            Console.WriteLine("Thanks for coming. Hope to receive an offer from you soon!");
                       
        }

    }
}
