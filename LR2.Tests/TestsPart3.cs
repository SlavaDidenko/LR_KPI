using NUnit.Framework;

namespace Part3.Tests;

[TestFixture]
public class Tests
{
    [TestCase(8, new[] { 30, -15, 70, 1 }, 100)]
    [TestCase(-5, new[] { 2, 1, -10, -3 }, 0)]
    [TestCase(-20, new[] { 64, 98, -24, -20, 1, -41, -48, -14, 52, 54 }, 255)]
    [TestCase(50, new[] { 68, 0, 72, -16, 86, 37, 99, 100, 91, 36,
                          29, -17, -1, -36, -30, 75, 84, 79, 53, 71 }, 878)]
    public void Task1_Check(int x, int[] array, int expected)
    {
        var actual = Tasks.Task1(x, array);
        Assert.AreEqual(expected, actual, "Task1 повентає некоректне значення.");
    }

    [TestCase(new[] { 30, -15, 70, 1 }, 1)]
    [TestCase(new[] { 2, 1, -10, -3 }, 2)]
    [TestCase(new[] { -49, 99, -18, 29, 17, -32, 83, -75, -97, 97, -79, 67, -4, -100, -38, 92, 66, 43, 81, 74 }, 9)]
    [TestCase(new[] { -62, 39, 21, -38, -72, -27, -33, 28, -52, -86, 49, 22, -93, -64, -66, -42, -54, 25, -63, -10 }, 14)]
    public void Task2_Check(int[] array, int expected)
    {
        var actual = Tasks.Task2(array);
        Assert.AreEqual(expected, actual, "Task2 повентає некоректне значення.");
    }


    [TestCase(new[] { 1, 6, 2, 10, 4, 3, 5, 0, 7 }, 2)]
    [TestCase(new[] { 0, 4, 7, 9, 1, 8, 5, 10, 6, 3 }, 1)]
    [TestCase(new[] { 0, 7, 4, 2, 8, 1, 5, 3, 6, 9, 10 }, 3)]
    public void Task3_Check(int[] array, int expected)
    {
        var actual = Tasks.Task3(array);
        Assert.AreEqual(expected, actual, "Task3 повентає некоректне значення.");
    }

    [TestCase(new[] { 1, 5, 2, 10, 4, 3, 8, 0, 7 }, 40, 8)]
    [TestCase(new[] { 0, 4, 7, 9, 0, 0, 5, 10, 0, 3 }, 38, 6)]
    [TestCase(new[] { 0, 7, 0, 2, 8, 1, 0, 3, 6, 9, 0 }, 36, 7)]
    public void Task4_Check(int[] array, int ex1, int ex2)
    {
        var actual = Tasks.Task4(array);
        var expected = (ex1, ex2);
        Assert.AreEqual(expected, actual, "Task4 повентає некоректне значення.");
    }


    [TestCase(new[] { 1, 6, 2, 10, 4, 3, 5, 0, 7 }, 10)]
    [TestCase(new[] { 0, 4, -7, 9, -1, 8, 5, -10, 6, 3 }, 19)]
    [TestCase(new[] { 0, 7, -4, 2, 8, 1, -5, 3, 6, 9, 10 }, 15)]
    public void Task5_Check(int[] array, int expected)
    {
        var actual = Tasks.Task5(array);
        Assert.AreEqual(expected, actual, "Task5 повентає некоректне значення.");
    }

    [TestCase(5, new[] { 1, 6, 2, 10, 4, 3, 5, 0, 7 }, new[] { 0, 12, 0, 20, 0, 0, 0, 0, 14 })]
    [TestCase(0, new[] { 0, 4, -7, 9, -1, 8, 5, -10, 6, 3 }, new[] { 0, 8, 0, 18, 0, 16, 10, 0, 12, 6 })]
    [TestCase(8, new[] { 0, 7, -4, 2, 8, 1, -5, 3, 6, 9, 10 }, new[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 18, 20 })]
    public void Task6_Check(int x, int[] array, int[] expected)
    {
        var actual = Tasks.Task6(x, array);
        Assert.AreEqual(expected, actual, "Task6 повентає некоректне значення.");
    }
}
