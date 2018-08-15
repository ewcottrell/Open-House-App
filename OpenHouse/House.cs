using System;
using System.Collections.Generic;

namespace OpenHouse
{
    public class House
    {
        public string Address { get; set; }
        public static List<Room> Rooms{ get; set; } = new List<Room>();
    }
}
