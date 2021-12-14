using bntu.vsrpp.dermakov.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GetNumberOfElements_CountOfElements_CountReturned()
        {
            //Arrange
            Library xLib = new Library();
            string xPath = "lab1_example1.xm";
            int expected = 4;

            //Act
            var result = xLib.GetNumberOfElements(xPath);

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void FindIntElements_IntInXml_IntElementsReturned()
        {

            //Arrange
            Library xLib = new Library();
            string xPath = "lab1_example1.xm";
            string expected = "Score";

            //Act
            var result = xLib.FindIntElements(xPath);

            //Assert
            Assert.AreEqual(expected, result[0]);
        }

        [TestMethod]
        public void FindStringElements_StringInXml_StringElementsReturned()
        {

            //Arrange
            Library xLib = new Library();
            string xPath = "lab1_example1.xm";
            string expected = "FirstName";

            //Act
            var result = xLib.FindStringElements(xPath);

            //Assert
            Assert.AreEqual(expected, result[0]);
        }

        [TestMethod]
        public void MaxNumbersValue_MaxOfNumbers_MaxReturned()
        {

            //Arrange
            Library xLib = new Library();
            string xPath = "lab1_example1.xm";
            string name = "Score";
            int expected = 12;

            //Act
            var result = xLib.MaxNumbersValue(xPath, name);

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void MinNumbersValue_MinOfNumbers_MinReturned()
        {

            //Arrange
            Library xLib = new Library();
            string xPath = "lab1_example1.xm";
            string name = "Score";
            int expected = 0;

            //Act
            var result = xLib.MinNumbersValue(xPath, name);

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void AverageNumbersValue_AverageOfNumbers_AverageReturned()
        {

            //Arrange
            Library xLib = new Library();
            string xPath = "lab1_example1.xm";
            string name = "Score";
            int expected = 9;

            //Act
            var result = xLib.AverageNumbersValue(xPath, name);

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void MaxStringsValue_MaxOfStrings_MaxReturned()
        {

            //Arrange
            Library xLib = new Library();
            string xPath = "lab1_example1.xm";
            string name = "FirstName";
            int expected = 6;

            //Act
            var result = xLib.MaxStringsValue(xPath, name);

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void MinStringsValue_MinOfStrings_MinReturned()
        {

            //Arrange
            Library xLib = new Library();
            string xPath = "lab1_example1.xm";
            string name = "FirstName";
            int expected = 0;

            //Act
            var result = xLib.MinStringsValue(xPath, name);

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void AverageStringsValue_AverageOfStrings_AverageReturned()
        {

            //Arrange
            Library xLib = new Library();
            string xPath = "lab1_example1.xm";
            string name = "FirstName";
            int expected = 2;

            //Act
            var result = xLib.AverageStringsValue(xPath, name);

            //Assert
            Assert.AreEqual(expected, result);
        }  
    }
}

