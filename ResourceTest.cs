using System;
using NUnit.Framework;

namespace task3week1{
    [TestFixture]
    public class ResourceTest{
        // test for Document
        [Test]
        public void TestCategoryDocument(){
            //setup 
            Resource resource = new Document("W700", true, new DateTime(2024, 11, 5, 10, 15, 0),"Subject", 
            new DateTime(2024, 11, 4, 10, 15, 0));
            // check + execute
            Assert.AreEqual("Remaining days to complete: 1", resource.Load());
        }
        
        // test for Worker
        [Test]
        public void TestCategoryWorker(){
            Resource resource2 = new Worker("W700", true, new DateTime(2024, 11, 3, 10, 15, 0), 10, 10);
            Assert.AreEqual("Total salary is: 100", resource2.Load());
        }

        // test for Product
        [Test]
        public void TestCategoryProduct(){
            Resource resource3 = new Product("W700", true, new DateTime(2024, 11, 3, 10, 15, 0));
            Assert.AreEqual("Successfully loaded", resource3.Load());
        }

        // test for Vehicle
        [Test] 
        public void TestCategoryVechile(){
            Resource resource4 = new Vehicle("W700", true, new DateTime(2024, 11, 3, 10, 15, 0));
            Assert.AreEqual("Validate the driver’s driving license!", resource4.Load());
        }

        [Test]
        public void TestChangeStatus(){
             Resource resource5 = new Document("W700", true, new DateTime(2024, 11, 3, 10, 15, 0),"Subject", 
            new DateTime(2023, 11, 3, 10, 15, 0));

            resource5.Status = false;

            Assert.AreEqual("Resource is not ready", resource5.Load());
        }
        
        [Test]
        public void TestAddResource()
        {
            Project p1 = new Project(new DateTime(2024, 11, 3, 10, 15, 0), 5);
            Resource resource = new Document("W700", true, new DateTime(2024, 11, 3, 10, 15, 0), "Subject",
            new DateTime(2023, 11, 3, 10, 15, 0));

            p1.AddResource(resource);

            Assert.AreEqual(resource, p1[0]);
        }
        public void TestAddResourceAfterDate()
        {
            Project p1 = new Project(new DateTime(2024, 11, 3, 10, 15, 0), 5);
            Resource resource1 = new Document("W700", true, new DateTime(2024, 11, 10, 10, 15, 0), "Subject",
            new DateTime(2023, 11, 3, 10, 15, 0));

            p1.AddResource(resource1);

            // create a count resource to check the number of resources
            Assert.AreEqual(0, p1.CountResource());

        }
        [Test]
        public void TestRemoveResource()
        {

            Project p1 = new Project(new DateTime(2024, 11, 11, 10, 15, 0), 5);
            Resource resource2 = new Document("W700", true, new DateTime(2024, 11, 10, 10, 15, 0), "Subject",
            new DateTime(2023, 11, 3, 10, 15, 0));
            Resource resource3 = new Document("W700", true, new DateTime(2024, 11, 10, 10, 15, 0), "Subject",
            new DateTime(2023, 11, 3, 10, 15, 0));

            p1.AddResource(resource2);
            p1.AddResource(resource3);

            p1.RemoveResource(resource3);

            Assert.AreEqual(resource2, p1[0]);
        }

        [Test]
        public void TestIndexer()
        {
            Project p1 = new Project(new DateTime(2024, 11, 3, 10, 15, 0), 5);
            Resource resource4 = new Document("D001", true, new DateTime(2024, 11, 3, 10, 15, 0), "Subject 1", new DateTime(2023, 11, 3, 10, 15, 0));
            Resource resource5 = new Document("D002", true, new DateTime(2024, 11, 3, 10, 15, 0), "Subject 2", new DateTime(2023, 11, 3, 10, 15, 0));

            p1.AddResource(resource4);
            p1.AddResource(resource5);

            // Assert: Ensure the indexer returns the correct resources at the specified indexes
            Assert.AreEqual(resource4, p1[0]);  // First resource should be at index 0
            Assert.AreEqual(resource5, p1[1]);  // Second resource should be at index 1
        }
        
    }
}

