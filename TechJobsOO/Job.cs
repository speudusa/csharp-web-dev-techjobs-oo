﻿using System;
namespace TechJobsOO
{
    public class Job
    {
        public int Id { get; }
        private static int nextId = 1;

        public string Name { get; set; }
        public Employer EmployerName { get; set; }
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
        
        public Job(string name, string employerName, string employerLocation, string jobType, string jobCoreCompetency ) : this()
        {
            Name = name;
            EmployerName.Value = employerName;
            EmployerLocation.Value = employerLocation;
            JobType.Value = jobType;
            JobCoreCompetency.Value = jobCoreCompetency;

        }

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
