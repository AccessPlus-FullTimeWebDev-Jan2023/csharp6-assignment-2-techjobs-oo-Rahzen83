
namespace TechJobs.Tests
{
    [TestClass]
    public class JobTests
    {
        //Testing Objects
        //initalize your testing objects here
        Job job1 = new Job();
        Job job2 = new Job();
        Job job3 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
        Job job4 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));

        [TestMethod]
        public void TestSettingJobId()
        {

            Assert.AreNotEqual(job1, job2, "Unique Id Test");
            Assert.AreEqual(job2, job2, "Should have same Id");

        }
        [TestMethod]
        public void TestJobConstructorSetsAllFields()
        {

            Assert.AreEqual(job3.Name, "Product tester");
            Assert.AreEqual(job3.EmployerName.Value, "ACME");
            Assert.AreEqual(job3.EmployerLocation.Value, "Desert");
            Assert.AreEqual(job3.JobType.Value, "Quality control");
            Assert.AreEqual(job3.JobCoreCompetency.Value, "Persistence");

        }
        [TestMethod]
        public void TestJobsForEquality()
        {
            Assert.IsFalse(job3 == job4);
        }

        // 


        [TestMethod]
        public void TestToStringStartsAndEndsWithNewLine()
        {
            StringAssert.StartsWith(job3.ToString(),Environment.NewLine);
            StringAssert.EndsWith(job3.ToString(), Environment.NewLine);

        }

        [TestMethod]
        public void TestToStringContainsCorrectLabelsAndData()
        {
            StringAssert.Contains(job3.ToString(), "ID: " + job3.Id);
            StringAssert.Contains(job3.ToString(), "Name: " + job3.Name);
            StringAssert.Contains(job3.ToString(), "Employer: " + job3.EmployerName);
            StringAssert.Contains(job3.ToString(), "Location: " + job3.EmployerLocation);
            StringAssert.Contains(job3.ToString(), "Position Type: " + job3.JobType);
            StringAssert.Contains(job3.ToString(), "Core Competency: " + job3.JobCoreCompetency);
        }

         [TestMethod]
         public void TestToStringHandlesEmptyField()
         {
            job3.Name = "" ;

             
             StringAssert.Contains(job3.ToString(), "Name: Data not available");
             
         

         }

    }
}

