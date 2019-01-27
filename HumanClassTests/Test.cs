using NUnit.Framework;
using System;
namespace SortingApp
{
    [TestFixture()]
    public class Test
    {
        [Test()]

        public void Human_FromString_test()
        {
            //arrange
            string testNameString = "John Gilber Romero Albert Doe";
            string TestedFirstName = "John";
            string TestedFirstGivenName = "Gilber";
            string TestedSecondGivenName = "Romero";
            string TestedThirdGivenName = "Albert";
            string TestedLastName = "Doe";

            //act
            Human TestHuman = new Human();
            TestHuman.FromString(testNameString);

            //assert
            Assert.AreEqual(TestedFirstName, TestHuman.FirstName);
            Assert.AreEqual(TestedFirstGivenName, TestHuman.FirstGivenName);
            Assert.AreEqual(TestedSecondGivenName, TestHuman.SecondGivenName);
            Assert.AreEqual(TestedThirdGivenName, TestHuman.ThirdGivenName);
            Assert.AreEqual(TestedLastName, TestHuman.LastName);
        }

        [Test()]

        public void Human_ToString_test()
        {
            //arrange
            string testNameString = "John Gilber Romero Albert Doe";
            Human TestHuman = new Human
            {
                FirstName = "John",
                FirstGivenName = "Gilber",
                SecondGivenName = "Romero",
                ThirdGivenName = "Albert",
                LastName = "Doe"
            };
            //assert
            Assert.AreEqual(testNameString, TestHuman.ToString());
        }
    }
}

