using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TechJobsOO;

namespace TechJobsTests
{
    [TestClass]
    public class JobTests
    {
        //Testing for uniqie IDs for each unique job
        [TestMethod]
        public void TestSettingJobId()
        {
            Job testjob1 = new Job();
            Job testjob2 = new Job();

            testjob1.Id.Equals(testjob2.Id);
            Assert.IsFalse(testjob1.Id == testjob2.Id);  //verification that the Id numbers are NOT equal
        }

        //testing to see if each constructor will correctly set each field  --CF
        [TestMethod]
        public void TestJobConstructorSetsAllFields()
        {
            Employer e = new Employer("ACME"); //ref to object, but can also just pass the whole thing in the constructor
            Job testjob3 = new Job("Product tester", e, new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));


            Assert.AreEqual("Product tester", testjob3.Name);
            Assert.AreEqual("ACME", testjob3.EmployerName.Value);
            Assert.AreEqual("Desert", testjob3.EmployerLocation.Value);
            Assert.AreEqual("Quality control", testjob3.JobType.Value);
            Assert.AreEqual("Persistence", testjob3.JobCoreCompetency.Value);
        }

        //testing of Equals() method  --CF
        //testing to see if id values are not equal
        [TestMethod]
        public void TestJobsForEquality()
        {
            Job testjob3 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            Job testjob4 = new Job("Web Developer", new Employer("LaunchCode"), new Location("St. Louis"), new PositionType("Front-end developer"), new CoreCompetency("JavaScript"));

            Assert.IsFalse(testjob3.Id == testjob4.Id);  //returns false becuase UNIQUE IDs.
            Equals(testjob3.Name, testjob4.Name);
            Equals(testjob3.EmployerName.Value, testjob4.EmployerName.Value);
            Equals(testjob3.EmployerLocation.Value, testjob4.EmployerLocation.Value);
            Equals(testjob3.JobType.Value, testjob4.JobType.Value);
            Equals(testjob3.JobCoreCompetency.Value, testjob4.JobCoreCompetency.Value);

        }


        [TestMethod]
        public void TestToString()  //bool
        {
            Job testjob6 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            //Job testjob7 = new Job("", new Employer(""), new Location(""), new PositionType(""), new CoreCompetency(""));

            //string literal  ${this guy}  and then compare ${} to ${}  //<-- THE WHOLE TIME

            
            string expected = "ID: 6 \n" 
                + "Name: Product tester \n" 
                + "Employer: ACME \n" 
                + "Location: Desert \n" 
                + "Position Type: Quality control \n" 
                + "Core Competency: Persistence \n";

            Assert.AreEqual(expected, testjob6.ToString());




            //TODO:NEED TO ADD CONDITIONAL for blanks and nulls  --> IsEmptyOrNull Method???
            //https://docs.microsoft.com/en-us/dotnet/api/system.string.isnullorempty?view=netcore-3.1

        }
    }

}
/* DUMMY JOB
 * Name = "Product tester"
 * EmployerName.Value = "ACME"
 * EmployerLocation.Value = "Desert"
 * JobType.Value = "Quality control"
 * JobCoreCompetency.Value = "Persistence"
 * */
