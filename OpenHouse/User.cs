using System;
using System.Collections.Generic;
using System.Linq;

namespace OpenHouse
{
    public class User
    {
        public List<string> Name { get; set; }

        public static bool YesToQuestion(string question)
        {
            List<string> PositiveResponses = new List<string> { "yes", "yea", "sure", "ok", "si", "ye" };
            List<string> NegativeResponses = new List<string> { "no", "not right now", "no thanks", "no. thanks.", "not today" };

            while (true)
            {
                Console.WriteLine(question);
                string answer = Console.ReadLine().ToLower();

                if (PositiveResponses.Contains(answer))
                    return true;

                if (NegativeResponses.Contains(answer))
                    return false;
            }
        }
    }
}
