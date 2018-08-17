using System;
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

                     
            Realtor agent = new Realtor("Evan");
            agent.Greet();
            agent.RealtorScript();

            Console.ReadLine();

        }
    }
}




