using System;
using System.Collections.Generic;

namespace OpenHouse
{
    public class House
    {
        public string Address { get; set; }
        public static List<Room> Rooms{ get; set; } = new List<Room>();

        public House()
        {
            AddKitchen();
        }

        private void AddKitchen()
        {
            Room Kitchen = new Room();
            Rooms.Add(Kitchen);
            Kitchen.Name = "kitchen";
            Kitchen.Descriptions.Add("ten foot ceilings");
            Kitchen.Descriptions.Add("real hardwood floors");
            Kitchen.Descriptions.Add("marble counters");
            Kitchen.Descriptions.Add("plenty of cabinet space");
            Kitchen.Descriptions.Add("new plumbing");
        }
        private void AddDen()
        {
            Room Den = new Room();
            Rooms.Add(Den);
            Den.Name = "den";
            Den.Descriptions.Add("Harwood floors");
            Den.Descriptions.Add("Ten foot ceiling");
            Den.Descriptions.Add("Ceiling fan to conserve energy");
            Den.Descriptions.Add("fresh paint");
        }
    }
}
