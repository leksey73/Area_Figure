using Area_Figure.Models;
using NUnit.Framework;

namespace Area_Figure_NUnitTest
{
    public class Area_Figure
    {
        [Test]
        public void Are_Triangle_1()
        {
            double Test_A = 10;
            double Test_B = 13;
            double Test_C = 19;

            double expected_S = 60.794736614282655;
            Triangle three = new Triangle(Test_A, Test_B, Test_C);
            double return_S = three.Area();
            Assert.AreEqual(expected_S, return_S);
        }

        [Test]
        public void Are_Triangle_2()
        {
            double Test_A = 3;
            double Test_B = 4;
            double Test_C = 5;

            double expected_S = 6;
            Triangle three = new Triangle(Test_A, Test_B, Test_C);
            double return_S = three.Area();
            Assert.AreEqual(expected_S, return_S);
        }

        [Test]
        public void Are_Circle_1()
        {
            double Test_R = 5;
            double expected_S = 78.539816339744831;
            Circle circ = new Circle(Test_R);
            double return_S = circ.Area();
            Assert.AreEqual(expected_S, return_S);
        }

        [Test]
        public void Are_Circle_2()
        {
            double Test_R = 23;
            double expected_S = 1661.9025137490005;
            Circle circ = new Circle(Test_R);
            double return_S = circ.Area();
            Assert.AreEqual(expected_S, return_S);
        }

    }
}