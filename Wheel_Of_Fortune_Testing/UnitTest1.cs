using Microsoft.VisualStudio.TestTools.UnitTesting;
using Wheel_Of_Fortune;

namespace Wheel_Of_Fortune_Testing
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAddMethod()
        {
            TestClass t1 = new TestClass();

            int x = 10;
            int y = 17;
            int expectedResult = x + y;

            // Act
            int result = t1.Add(x, y);

            // Assert
            Assert.AreEqual(result, expectedResult);
        }
    }
}
