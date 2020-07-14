using System;
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
        
        
        
        //TODO currently testing the Full Constructor
        public Job(string name, Employer employerName, Location employerLocation, PositionType jobType, CoreCompetency jobCoreCompetency) : this()
        {
            Name = name;
            EmployerName = employerName;
            EmployerLocation = employerLocation;
            JobType = jobType;
            JobCoreCompetency = jobCoreCompetency;

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

/* DUMMY JOB
 * Id assigned by Job() method as int
 * Name = "Product tester"
 * EmployerName.Value = "ACME"
 * EmployerLocation.Value = "Desert"
 * JobType.Value = "Quality control"
 * JobCoreCompetency.Value = "Persistence"
 * */
