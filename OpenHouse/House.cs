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
            AddDen();
            AddMasterBedRoom();
            AddSecondRoom();
            AddMasterBath();
            AddGuestBath();
        }

        private void AddKitchen()
        {
            Room Kitchen = new Room("Kitchen");
            Rooms.Add(Kitchen);
            Kitchen.Descriptions.Add("ten foot ceilings");
            Kitchen.Descriptions.Add("real hardwood floors");
            Kitchen.Descriptions.Add("marble counters");
            Kitchen.Descriptions.Add("plenty of cabinet space");
            Kitchen.Descriptions.Add("new plumbing");
        }
        private void AddDen()
        {
            Room Den = new Room("Den");
            Rooms.Add(Den);
            Den.Descriptions.Add("Harwood floors");
            Den.Descriptions.Add("Ten foot ceiling");
            Den.Descriptions.Add("Ceiling fan to conserve energy");
            Den.Descriptions.Add("fresh paint");
        }
        private void AddMasterBedRoom()
        {
            Room MasterBedroom = new Room("Master Bedroom");
            Rooms.Add(MasterBedroom);
            MasterBedroom.Descriptions.Add("ceiling fan to conserve energy");
            MasterBedroom.Descriptions.Add("huge walk- in closet");
            MasterBedroom.Descriptions.Add("has its own bath");
            MasterBedroom.Descriptions.Add("Can fit California King bed");
            MasterBedroom.Descriptions.Add("energy saving windows");
        }
        private void AddMasterBath()
        {
            Room MasterBath = new Room("Master Bath");
            Rooms.Add(MasterBath);
            MasterBath.Descriptions.Add("Jacuzzi tub");
            MasterBath.Descriptions.Add("seperate shower");
            MasterBath.Descriptions.Add("double vanity");
            MasterBath.Descriptions.Add("two towel racks");
            MasterBath.Descriptions.Add("storage under vanity");
        }
        private void AddSecondRoom()
        {
            Room SecondBedroom = new Room("Second Bedroom");
            Rooms.Add(SecondBedroom);
            SecondBedroom.Descriptions.Add("ceiling fan");
            SecondBedroom.Descriptions.Add("can fit a queen bed");
            SecondBedroom.Descriptions.Add("space for dresser and chest");
            SecondBedroom.Descriptions.Add("walk-in closet");
        }
        private void AddGuestBath()
        {
            Room GuestBath = new Room("Guest Bath");
            Rooms.Add(GuestBath);
            GuestBath.Descriptions.Add("garden tub");
            GuestBath.Descriptions.Add("Linen Closet");
            GuestBath.Descriptions.Add("new vanity");
            GuestBath.Descriptions.Add("new mirror");
            GuestBath.Descriptions.Add("new harwood floors");
            GuestBath.Descriptions.Add("new plumbing");
        }

    }
}
