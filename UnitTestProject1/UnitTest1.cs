using Microsoft.VisualStudio.TestTools.UnitTesting;
using RegexExample;
using Moq;
using System.IO;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ReadTextFile()
        {
            //Arrange
            var obj = new Program(new FileReader());
            string path = @"C:\Users\rajes\OneDrive\Desktop\BridgeLabzProjects\RegexExample\RegexExample\TextFile1.txt";


            //Act
            var actual=obj.ReadTextFile(path);

            //Assert
            Assert.AreEqual("Good Evening", actual);
        }

        [TestMethod]
        public void WriteAllTextFile()
        {
            //Arrange
            var obj = new Program(new FileReader());
            string path = @"C:\Users\rajes\OneDrive\Desktop\BridgeLabzProjects\RegexExample\RegexExample\TextFile1.txt";


            //Act
            var actual = obj.WriteAllTextFile(path,"Hello Rajesha");

            //Assert
            Assert.AreEqual("Success", actual);
        }

        [TestMethod]
        public void ReadTextFileWithMock()
        {
            //Arrange
            string path = @"C:\Users\rajes\OneDrive\Desktop\BridgeLabzProjects\RegexExample\RegexExample\TextFile1.txt";

            Mock<IFileReader> mock = new Mock<IFileReader>();
            mock.Setup(x=>x.Exists(path)).Returns(true);
            mock.Setup(x => x.ReadAllText(path)).Returns("Hi Guys");
            var obj = new Program(mock.Object);


            //Act
            var actual = obj.ReadTextFile(path);

            //Assert
            Assert.AreEqual("Hi Guys", actual);
        }

        [TestMethod]
        public void WriteAllTextFileWithMock()
        {
            //Arrange
            string path = @"C:\Users\rajes\OneDrive\Desktop\BridgeLabzProjects\RegexExample\RegexExample\TextFile1.txt";

            Mock<IFileReader> mock = new Mock<IFileReader>();
            mock.Setup(x => x.Exists(path)).Returns(true);
            mock.Setup(x => x.WriteAllText(path,"Hello Ashok"));
            var obj = new Program(mock.Object);


            //Act
            var actual = obj.WriteAllTextFile(path, "Hello Ashok");

            //Assert
            Assert.AreEqual("Success", actual);
        }
    }
}
