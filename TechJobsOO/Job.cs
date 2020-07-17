using System;
using System.Collections.Generic;

namespace TechJobsOO
{
    public class Job
    {
        public int Id { get; }
        public static int nextId = 1;

        public string Name { get; set; }
        public Employer EmployerName { get; set; }  //employerName held by employer OBJECT
        public Location EmployerLocation { get; set; }
        public PositionType JobType { get; set; }
        public CoreCompetency JobCoreCompetency { get; set; }

        //Added constructor to initialize id field --CF 
        //Added constructor that initalizes properties, and will used Job() to assign id to job object --CF
        public Job()
        {
            Id = nextId;
            nextId++;
        }
                        
        //Tested Full Constructor --CF
        public Job(string name, Employer employerName, Location employerLocation, PositionType jobType, CoreCompetency jobCoreCompetency) : this()
        {
            Name = name;
            EmployerName = employerName;
            EmployerLocation = employerLocation;
            JobType = jobType;
            JobCoreCompetency = jobCoreCompetency;
        }

        //Added the ToString() method --CF

        public override string ToString()               //override to create our my own methods
        {
            string thing = "Data not available.";
            string nameCheck = Name; 
            string employerCheck = EmployerName.Value; 
            string locationCheck = EmployerLocation.Value;
            string jobtypeCheck = JobType.Value;
            string coreTypeCheck = JobCoreCompetency.Value;


            return $"ID: {Id} \n Name: {(!string.IsNullOrEmpty(nameCheck) ? nameCheck : thing)} \n Employer: {(!string.IsNullOrEmpty(employerCheck) ? employerCheck : thing)} \n Location: {(!string.IsNullOrEmpty(locationCheck) ? locationCheck : thing)} \n  Position Type: {(!string.IsNullOrEmpty(jobtypeCheck) ? jobtypeCheck : thing)} \n Core Competency: {(!string.IsNullOrEmpty(coreTypeCheck) ? coreTypeCheck : thing)} \n";    
            
        }              
        //ternary operators  1 (bool) ? 2 (true --> return new message) : 3 false (return as is)


        //Added Equals() method --CF
        //Added GetHashCode() method --CF
        public override bool Equals(object obj)
        {
            return obj is Job job &&
                Id == job.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

        
    }
}

