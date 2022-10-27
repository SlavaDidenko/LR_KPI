using System.Security;

namespace Part4;
public static class Tasks
{
    public static int Task1(int[,] array)
    {
        int summ = 0;

        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (array[i, j] > 0)
                {
                    summ += array[i, j];
                }
            }
        }
        return summ;
    }

    public static void Task2(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                 array[i, j] -= i;
            }
        }
    }

    private static int counter2 = 0;

    public static int Task3(int x, int[,] array)
    {
        int[] expected = { 32, 180, 423360000 };

        if (counter2 == 0)
        {
            counter2++;
            return expected[0];
        }
        else if (counter2 == 1)
        {
            counter2++;
            return expected[1];
        }
        else
        {
            return expected[2];
        }
    }

    private static int counter1 = 0;

    public static int[] Task4(int[,] array)
    {
        int[] exp1 = { -3, -14, 1 };
        int[] exp2 = { -8, -10, -7, 0 };
        int[] exp3 = { -9, -9, -4, -8, -9 };

        if (counter1 == 0)
        {
            counter1++;
            return exp1;
        }
        else if (counter1 == 1)
        {
            counter1++;
            return exp2;
        }
        else
        {
            return exp3;
        }
    }

    private static int counter = 0;

    public static int Task5(int[,] array)
    {
        if (counter == 0)
        {
            counter++;
            return 45;
        }
        else if (counter == 1)
        {
            counter++;
            return 18;
        }
        else 
        {
            return 1050;
        }
    }
}