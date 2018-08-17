using System;
using System.Collections.Generic;
namespace OpenHouse
{
    public class User
    {
        public string Name { get; private set; } 

        public User(string name)
        {
            Name = name;
        }

    }
}
