using System;
using System.Collections.Generic;

namespace task3week1
{
    /// <summary>
    /// Represents a project class with a defined fields: start date, duration, and completion status.
    /// </summary>
    class Project
    {
        private DateTime _startDate;
        private int _duration;
        private bool _completionStatus;
        private List<Resource> _resources;

        /// <summary>
        /// Gets the end date of the project, calculated as the start date plus the duration.
        /// </summary>
        private DateTime _endDate
        {
            get { return _startDate.AddDays(_duration); }
        }

        /// <summary>
        /// this is the passby value constructor with a specified start date, duration, and completion status.
        /// </summary>
        /// <param name="startDate">The start date of the project.</param>
        /// <param name="duration">The duration of the project in days.</param>
        /// <param name="completionStatus">The completion status of the project.</param>
        public Project(DateTime startDate, int duration)
        {
            _startDate = startDate;
            _duration = duration;
            _completionStatus = false;
            _resources = new List<Resource>();
        }

        /// <summary>
        /// (read and write property) Gets or sets the completion status of the project.
        /// </summary>
        public bool CompletionStatus
        {
            get { return _completionStatus; }
            set { _completionStatus = value; }
        }

        /// <summary>
        /// Adds a resource to the project if its needed date is before the project end date.
        /// </summary>
        public void AddResource(Resource resource)
        {
            if (resource.DateTimeNeeded < _endDate)
            {
                _resources.Add(resource);
                Console.WriteLine("Resource added");
            }
            else
            {
                Console.WriteLine("Cannot add resource, needed date is after project end date.");
            }
        }

         /// <summary>
        /// Removes a specified resource from the project.
        /// </summary>
        public void RemoveResource(Resource resource)
        {
            _resources.Remove(resource);
        }

        /// <summary>
        /// Displays the details of the project, including the start date, duration, end date, and completion status.
        /// </summary>
        
        // // create a count resource to check the number of resources
        public int CountResource(){
           return _resources.Count;
        }
        public void DisplayDetails()
        {
            Console.WriteLine($"Project Start Date: {_startDate}");
            Console.WriteLine($"Duration in days: {_duration}");
            Console.WriteLine($"Project End Date: {_endDate}");
            Console.WriteLine($"Project Completion Status: {_completionStatus}");

            // print out the resoruce
            foreach (Resource resource in _resources){
                Console.WriteLine(resource.ID);
                Console.WriteLine(resource.Status);
                Console.WriteLine(resource.DateTimeNeeded);
            }
        }

        /// <summary>
        /// The ability to access a Resource at a given index can be implemented as an indexer Gets the resource at the specified index.
        /// </summary>
        public Resource this[int i]
        {
            get { return _resources[i]; }
        }
    }
}