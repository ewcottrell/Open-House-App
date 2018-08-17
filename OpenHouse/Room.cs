using System;
using System.Collections.Generic;
namespace OpenHouse
{
    public class Room
    {
        
        public string Name { get;private set; }
        public List<string> Descriptions { get; set; } = new List<string>();

        public Room(string name)
        {
            Name = name;
        }

    }
}
