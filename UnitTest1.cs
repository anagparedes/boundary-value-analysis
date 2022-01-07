using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RandomTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestConstructor()
        {
            Person Ana = new Person("Ana","Paredes",21);
            Person result = Ana;
            Assert.AreEqual(Ana, result);
        }
        [TestMethod]
        public void TestBoundaryName()
        {
            Person Ana = new Person("Nathalie", "Lopez", 21);
            Person result = Ana;
            Assert.AreEqual(Ana, result);
        }
        [TestMethod]
        public void TestBoundaryLastName()
        {
            Person Ana = new Person("Pablo", "Martinez", 21);
            Person result = Ana;
            Assert.AreEqual(Ana, result);
        }
        [TestMethod]
        public void TestBoundaryAge()
        {
            Person Ana = new Person("Monica", "Ricart", 21);
            Person result = Ana;
            Assert.AreEqual(Ana, result);
        }

    }

    
}
