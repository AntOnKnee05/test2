using System;

namespace task3week1
{   
    /// <summary>
    /// enumeration for resource category in the resource class --> is a special "class" that represents a group of constants which values
    /// </summary>

    /// <summary>
    /// This is the resource class with 4 fields: (ID, status, category and datetime)
    /// </summary>
    public abstract class Resource
    {
        private string _ID;
        private bool _Status;
        private DateTime _datetimeNeeded;

        /// <summary>
        /// this is the Resource constructor which has the parameters ID, status, category and datetime
        /// </summary>
        /// <param name="ID"></param>
        /// <param name="status"></param>
        /// /// <param name="datetimeNeeded"></param>
        

        public Resource(string ID, bool status,  DateTime datetimeNeeded){
            _ID = ID;
            _Status = status;
            _datetimeNeeded = datetimeNeeded;
        }

        /// <summary>
        /// This is a read and write property for ID, to set and get the ID value
        /// </summary>
        /// <value></value>
        public string ID { 
            get { return _ID;}
            set { _ID = value; }
        }
        
        /// <summary>
        /// this is a read and write property for the Status, to set and get the Status
        /// </summary>
        /// <value></value>
        public bool Status {
            get { return _Status;}
            set { _Status = value; }
        }

        /// <summary>
        /// this is a read only property for the datetimeneeded, to get only the datetimeneeded
        /// </summary>
        /// <value></value>
        public DateTime DateTimeNeeded { 
            get { return _datetimeNeeded;}
        }

        /// <summary>
        /// this is a method to load the resource which checks the status, the category and the datetime
        /// </summary>
        /// <returns></returns>
        public abstract string Load();    
    }
}
