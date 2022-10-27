using NUnit.Framework;

namespace Part1.Tests;
[TestFixture]
public class Tests
{
    [TestCase(1, "Периметр = 4")]
    [TestCase(4, "Периметр = 16")]
    [TestCase(6, "Периметр = 24")]
    public void Task1_Check(int length, string expected)
    {
        var actual = Tasks.Task1(length);
        Assert.AreEqual(expected, actual, "Task1 повентає некоректне значення.");
    }

    [TestCase(1, 2, 3, "Довжина = 6, Площа поверхні = 22")]
    [TestCase(8, 1, 1, "Довжина = 8, Площа поверхні = 34")]
    [TestCase(1, 4, 8, "Довжина = 32, Площа поверхні = 88")]
    public void Task2_Check(int s1, int s2, int s3, string expected)
    {
        var actual = Tasks.Task2(s1, s2, s3);
        Assert.AreEqual(expected, actual, "Task2 повентає некоректне значення.");
    }


    [TestCase(1,  "Площа PCB = 1")]
    [TestCase(10, "Площа PCB = 100")]
    [TestCase(15, "Площа PCB = 225")]
    public void Task3_Check(int x, string expected)
    {
        var actual = Tasks.Task3(x);
        Assert.AreEqual(expected, actual, "Task3 повентає некоректне значення.");
    }


    [TestCase(13, "Десятків: 1")]
    [TestCase(47, "Десятків: 4")]
    [TestCase(82, "Десятків: 8")]
    public void Task4_Check(int x, string expected)
    {
        var actual = Tasks.Task4(x);
        Assert.AreEqual(expected, actual, "Task4 повентає некоректне значення.");
    }

    [TestCase(13, "Сума = 4, Добуток = 3")]
    [TestCase(47, "Сума = 11, Добуток = 28")]
    [TestCase(82, "Сума = 10, Добуток = 16")]
    public void Task5_Check(int x, string expected)
    {
        var actual = Tasks.Task5(x);
        Assert.AreEqual(expected, actual, "Task5 повентає некоректне значення.");
    }

    [TestCase(133, "Сума = 7, Добуток = 9")]
    [TestCase(472, "Сума = 13, Добуток = 56")]
    [TestCase(828, "Сума = 18, Добуток = 128")]
    public void Task6_Check(int x, string expected)
    {
        var actual = Tasks.Task6(x);
        Assert.AreEqual(expected, actual, "Task6 повентає некоректне значення.");
    }

}