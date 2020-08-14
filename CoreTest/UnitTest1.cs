using Core;
using NUnit.Framework;

namespace CoreTest
{
    public class Tests
    {
        private Class1 class1;

        [SetUp]
        public void Setup()
        {
            class1 = new Class1();
        }

        [Test]
        public void Test_Lies()
        {
            // Arrange
            var boolean = false;

            // Act
            var actual = class1.IsTrue(boolean);

            // Assert
            Assert.IsFalse(actual);
        }

        [Test]
        public void Test_TheTruth()
        {
            // Arrange
            var boolean = true;

            // Act
            var actual = class1.IsTrue(boolean);

            // Assert
            Assert.IsTrue(actual);
        }
    }
}