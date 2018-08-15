﻿using System;
using System.Collections.Generic;

namespace OpenHouse
{
    class MainClass
    {

        public static void Main(string[] args)
        {
            House House = new House();
            /*Go back and create classes for each of your rooms and make a 'create' method
            that creates each room and adds it and it's descriptions to the list of rooms.*/

            Room Kitchen = new Room();
            House.Rooms.Add(Kitchen);
            Kitchen.Name = "kitchen";
            Kitchen.Descriptions.Add("ten foot ceilings");
            Kitchen.Descriptions.Add("real hardwood floors");
            Kitchen.Descriptions.Add("marble counters");
            Kitchen.Descriptions.Add("plenty of cabinet space");
            Kitchen.Descriptions.Add("new plumbing");

            Room Den = new Room();
            House.Rooms.Add(Den);
            Den.Name = "den";
            Den.Descriptions.Add("Harwood floors");
            Den.Descriptions.Add("Ten foot ceiling");
            Den.Descriptions.Add("Ceiling fan to conserve energy");
            Den.Descriptions.Add("fresh paint");

            Room LivingRoom = new Room();
            House.Rooms.Add(LivingRoom);
            LivingRoom.Name = "living room";
            LivingRoom.Descriptions.Add("fresh paint");
            LivingRoom.Descriptions.Add("there is space for 2 couches and 2 chairs");
            LivingRoom.Descriptions.Add("new baseboards");
            LivingRoom.Descriptions.Add("Harwood floors");

            Room MasterBedroom = new Room();
            House.Rooms.Add(MasterBedroom);
            MasterBedroom.Name = "master bedroom";
            MasterBedroom.Descriptions.Add("ceiling fan to conserve energy");
            MasterBedroom.Descriptions.Add("huge walk- in closet");
            MasterBedroom.Descriptions.Add("has its own bath");
            MasterBedroom.Descriptions.Add("Can fit California King bed");
            MasterBedroom.Descriptions.Add("energy saving windows");

            Room MasterBath = new Room();
            House.Rooms.Add(MasterBath);
            MasterBath.Name = "master bath";
            MasterBath.Descriptions.Add("Jacuzzi tub");
            MasterBath.Descriptions.Add("seperate shower");
            MasterBath.Descriptions.Add("double vanity");
            MasterBath.Descriptions.Add("two towel racks");
            MasterBath.Descriptions.Add("storage under vanity");

            Room SecondBedroom = new Room();
            House.Rooms.Add(SecondBedroom);
            SecondBedroom.Name = "second bedroom";
            SecondBedroom.Descriptions.Add("ceiling fan");
            SecondBedroom.Descriptions.Add("can fit a queen bed");
            SecondBedroom.Descriptions.Add("space for dresser and chest");
            SecondBedroom.Descriptions.Add("walk-in closet");

            Room GuestBath = new Room();
            House.Rooms.Add(GuestBath);
            GuestBath.Name = "guest bath";
            GuestBath.Descriptions.Add("garden tub");
            GuestBath.Descriptions.Add("Linen Closet");
            GuestBath.Descriptions.Add("new vanity");
            GuestBath.Descriptions.Add("new mirror");
            GuestBath.Descriptions.Add("new harwood floors");
            GuestBath.Descriptions.Add("new plumbing");

            Realtor agent = new Realtor();
            agent.Name = "Evan";
            agent.Greet();
            agent.RealtorScript();

            Console.ReadLine();

        }
    }
}




