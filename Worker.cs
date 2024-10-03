using System;
using System.Collections.Generic;

namespace task3week1
{
    public class Worker:Resource
    {
       private double _hoursWorked;
       private float _ratePerHour;


       public Worker(string ID, bool status, DateTime datetimeNeeded, double hoursWorked, float ratePerHour):base(ID, status, datetimeNeeded)
       {
           _hoursWorked = hoursWorked;
           _ratePerHour = ratePerHour;
       }

       public override string Load()
        {
            if (!Status)
            {
                return "Resource is not ready";
            }

            double totalSalary = _hoursWorked * _ratePerHour;
            return "Total salary is: " + totalSalary;
        }
    }
}
