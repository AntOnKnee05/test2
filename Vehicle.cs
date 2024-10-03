using System;
using System.Collections.Generic;

namespace task3week1
{
    public class Vehicle : Resource
    {
        public Vehicle(string ID, bool status, DateTime datetimeNeeded)
            : base(ID, status, datetimeNeeded)
        {
        }

        // Overriding the Load method for Vehicle
        public override string Load()
        {
            if (!Status)
            {
                return "Resource is not ready";
            }

            return "Validate the driver’s driving license!";
        }

    }
}