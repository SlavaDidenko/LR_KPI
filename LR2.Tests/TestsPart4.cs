using NUnit.Framework;
using System.Collections.Generic;

namespace Part4.Tests;

[TestFixture]
public class Tests
{
    [Test]
    public void Task1_Check()
    {
        List<int[,]> arrayList = new List<int[,]>();

        arrayList.Add(new int[,] { { -1, 2, -3 }, { 4, -5, -6 }, { -7, 8, -9 } });
        arrayList.Add(new int[,] { { -5, -7,  5 }, { -1,  5, -2 }, {  1,  3, -9 }, {  3,  2,  7 }, {  5,  9, -9 } });
        arrayList.Add(new int[,] { {-10, 2, 10, -6, 5 }, {-5, -9, 2, 10, -10}, {4, -6, 10, -8, -9}});

        int[] expected = { 14, 40, 43 };

        for (int i = 0; i < expected.Length; i++)
        {
            var actual = Tasks.Task1(arrayList[i]);
            Assert.AreEqual(expected[i], actual, "Task1 повертає некоректне значення.");
        }
    }


    [Test]
    public void Task2_Check()
    {
        List<int[,]> arrayList = new List<int[,]>();

        arrayList.Add(new int[,] { { 1, 2, 3 },{ 4, 5, 6 },{ 7, 8, 9 } });
        arrayList.Add(new int[,] { { 13, 18, 29, 34 }, { 15, -36, -13, 41 },{ 20, -9, 8, 9 } });
        arrayList.Add(new int[,] { { -44, 37, -21, 20 }, { -30, -29, 32, -44 }, { 38, 17, 33, 10 }, { 43, 36, 46, 29 } });

        List<int[,]> expected = new List<int[,]>();

        expected.Add(new int[,] { { 1, 2, 3 }, { 3, 4, 5 }, { 5, 6 ,7 } });
        expected.Add(new int[,] { { 13, 18, 29, 34 }, { 14, -37, -14, 40 }, { 18, -11, 6, 7 } });
        expected.Add(new int[,] { { -44, 37, -21, 20 }, { -31, -30, 31, -45 }, { 36, 15, 31, 8 }, { 40, 33, 43, 26 } });

        for (int i = 0; i < expected.Count; i++)
        {
            Tasks.Task2(arrayList[i]);
            Assert.AreEqual(expected[i], arrayList[i], "Task2 повентає некоректне значення.");
        }
    }
    
    [Test]
    public void Task3_Check()
    {
        List<int[,]> arrayList = new List<int[,]>();

        arrayList.Add(new int[,] { { -1, 2, -3 }, { 4, -5, -6 }, { -7, 8, -9 } });
        arrayList.Add(new int[,] { { -5, -4, -10, 5 }, { -3, 3, -1, 0 }, { -1, -2, 2, 9 }, { 4, 1, -7, 2 } });
        arrayList.Add(new int[,] { { -10, 10, -8, 9, 5 }, { 2, 3, -2, -4, 0 }, { 5, 1, 4, 6, 8 }, { 7, -4, -9, -8, -10 }, { 10, 1, 8, 2, 7 } });

        int[] expected = { 32, 180, 423360000 };
        int[] x_array = { 2, 3, 4 };

        for (int i = 0; i < expected.Length; i++)
        {
            var actual = Tasks.Task3(x_array[i], arrayList[i]);
            Assert.AreEqual(expected[i], actual, "Task3 повентає некоректне значення.");
        }
    }

    [Test]
    public void Task4_Check()
    {
        int[,] arr1 = new int[,] { { -1, 2, -3 }, { -14, -5, -6 }, { 7, 1, 9 } };
        int[,] arr2 = new int[,] { { -8, 7, -7, 10 }, { -3, -10, 10, -9 }, { -1, -7, -5, 4 }, { 5, 9, 2, 0 } };
        int[,] arr3 = new int[,] { { -9, 1, 0, 6, -1 }, { 0, -1, 2, -9, 9 }, { 2, 7, 5, 1, -4 }, { 6, -8, -7, -1, 1 }, { 10, 5, 0, -9, -3 } };

        var actual1 = Tasks.Task4(arr1);
        var actual2 = Tasks.Task4(arr2);
        var actual3 = Tasks.Task4(arr3);
        
        int[] exp1 = { -3, -14, 1 };
        int[] exp2 = { -8, -10, -7, 0 };
        int[] exp3 = { -9, -9, -4, -8, -9 };

        Assert.AreEqual(exp1, actual1, "Task4 повентає некоректне значення.");
        Assert.AreEqual(exp2, actual2, "Task4 повентає некоректне значення.");
        Assert.AreEqual(exp3, actual3, "Task4 повентає некоректне значення.");
    }

    [Test]
    public void Task5_Check()
    {
        int[,] arr1 = new int[,] { { -1, 2, -3 }, { -14, -5, -6 }, { 7, 1, 9 } };
        int[,] arr2 = new int[,] { { 1, 8, 7, 10 }, { 4, -3, -10, -6 }, { 5, -1, -6, 1 }, { 8, 0, -7, 1 } };
        int[,] arr3 = new int[,] { { -3, -10, 7, 5, 4 }, { -1, -5, -4, 2, 7 }, { 1, -9, -7, 9, -8 }, { 5, -6, -4, -10, -3 }, { 10, 5, 7, -7, 1 } };

        var actual1 = Tasks.Task5(arr1);
        var actual2 = Tasks.Task5(arr2);
        var actual3 = Tasks.Task5(arr3);

        int exp1 = 45;
        int exp2 = 18;
        int exp3 = 1050;

        Assert.AreEqual(exp1, actual1, "Task5 повентає некоректне значення.");
        Assert.AreEqual(exp2, actual2, "Task5 повентає некоректне значення.");
        Assert.AreEqual(exp3, actual3, "Task5 повентає некоректне значення.");
    }
}
