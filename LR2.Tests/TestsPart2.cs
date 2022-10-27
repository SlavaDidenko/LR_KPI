using NUnit.Framework;

namespace Part2.Tests
{
    public class Tests
    {
        [TestCase(20, 21)]
        [TestCase(-5, -5)]
        [TestCase(0, 0)]
        public void Task1_Check(int T, int expected)
        {
            var actual = Tasks.Task1(T);
            Assert.AreEqual(expected, actual, "Task1 повентає некоректне значення.");
        }

        [TestCase(20, 25)]
        [TestCase(-5, -9)]
        [TestCase(0, 1)]
        public void Task2_Check(int T, int expected)
        {
            var actual = Tasks.Task2(T);
            Assert.AreEqual(expected, actual, "Task2 повентає некоректне значення.");
        }
   

        [TestCase(10, 20, 30, 10)]
        [TestCase(5, 15, -10, -10)]
        [TestCase(10, 0, 25, 0)]
        public void Task3_Check(int t1, int t2, int t3, int expected)
        {
            var actual = Tasks.Task3(t1, t2, t3);
            Assert.AreEqual(expected, actual, "Task3 повентає некоректне значення.");
        }

        [TestCase(3, 5, 12, 17)]
        [TestCase(12, -5, 14, 26)]
        [TestCase(0, -12, 12, 12)]
        [TestCase(-3, -5, -12, -8)]
        public void Task4_Check(int u1, int u2, int u3, int expected)
        {
            var actual = Tasks.Task4(u1, u2, u3);
            Assert.AreEqual(expected, actual, "Task4 повентає некоректне значення.");
        }
    
        [TestCase(5, 3, 12, 3, 5, 12)]
        [TestCase(12, -5, 14, -5, 12, 14)]
        [TestCase(0, -12, 12, -12, 0, 12)]
        public void Task5_Check(int u1, int u2, int u3, int exp_u1, int exp_u2, int exp_u3)
        {
            var (x1, x2, x3) = Tasks.Task5(u1, u2, u3);

            Assert.AreEqual(exp_u1, x1, "Значення u1 некоректне.");
            Assert.AreEqual(exp_u2, x2, "Значення u2 некоректне.");
            Assert.AreEqual(exp_u3, x3, "Значення u3 некоректне.");
        }


        [TestCase(3, 5, 12, 6, 10, 24)]
        [TestCase(14, 7, 3, 28, 14, 6)]
        [TestCase(3, 12, -5, -3, -12, 5)]
        public void Task6_Check(int u1, int u2, int u3, int exp_u1, int exp_u2, int exp_u3)
        {
            var (x1, x2, x3) = Tasks.Task6(u1, u2, u3);

            Assert.AreEqual(exp_u1, x1, "Значення u1 некоректне.");
            Assert.AreEqual(exp_u2, x2, "Значення u2 некоректне.");
            Assert.AreEqual(exp_u3, x3, "Значення u3 некоректне.");
        }
   
        [TestCase(1, 6, 12)]
        [TestCase(5, 15, 50)]
        [TestCase(152, 2435, 1476606)]
        public void Task7_Check(int ri, int rj, int expected)
        {
            var actual = Tasks.Task7(ri, rj);
            Assert.AreEqual(expected, actual, "Task7 повентає некоректне значення.");
        }

        [TestCase(1, 6, 9)]
        [TestCase(5, 15, 60)]
        [TestCase(152, 2435, 1477748)]
        public void Task8_Check(int ri, int rj, int expected)
        {
            var actual = Tasks.Task8(ri, rj);
            Assert.AreEqual(expected, actual, "Task8 повентає некоректне значення.");
        }

        [TestCase(246842646, 0)]
        [TestCase(27827672, 21)]
        [TestCase(127831, 12)]
        public void Task9_Check(int x, int expected)
        {
            var actual = Tasks.Task9(x);
            Assert.AreEqual(expected, actual, "Task9 повентає некоректне значення.");
        }
    }
}