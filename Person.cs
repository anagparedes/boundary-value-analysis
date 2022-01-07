using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RandomTest
{
    [TestClass]
    public class Person
    {
        public string Name { get; set; }
        public string Lastname { get; set; }
        public int Age { get; set; }
       
        public Person(string name, string lastname, int age)
        {
            name = this.Name;
            lastname = this.Lastname;
            age = this.Age;
        }

        [TestMethod]
        public void TestConstructor()
        {
            Person Ana = new Person("Ana","Paredes",21);
            Person result = Ana;
            Assert.AreEqual(Ana, result);
        }

    }

    
}
