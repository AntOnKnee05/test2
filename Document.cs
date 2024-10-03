using System;
using System.Collections.Generic;

namespace task3week1
{
    public class Document:Resource
    {
        private string _subject;
        private DateTime _creationDateTime;

        public Document(string ID, bool status, DateTime datetimeNeeded, string Subject, DateTime creationDateTime):base(ID, status, datetimeNeeded)
        {
            _subject = Subject;
            _creationDateTime = creationDateTime;
        }

         public override string Load()
        {
            if (!Status)
            {
                return "Resource is not ready";
            }

            TimeSpan remainingDays =  DateTimeNeeded - _creationDateTime;
            
            return "Remaining days to complete: " + remainingDays.Days;
            
        }
    }
}