using System;
using System.Collections.Generic;

namespace task3week1
{

    public class Product:Resource
    {
        private int _availability;

        // Constructor, setting default availability to 5
        public Product(string ID, bool status, DateTime datetimeNeeded):base(ID, status, datetimeNeeded )
        {
            _availability = 5;
        }
    
        // Overriding the Load method for Product
        public override string Load()
        {
            if (!Status)
            {
                return "Resource is not ready";
            }

            if (_availability > 0)
            {
                _availability--; // Decrease availability
                return "Successfully loaded";
            }
            else
            {
                return "Product is not available";
            }
        }
    }
}