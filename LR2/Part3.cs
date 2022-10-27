namespace Part3;
public static class Tasks
{
    public static int Task1(int x, int[] array)
    {
        int max_val = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > x)
            { 
                max_val += array[i];
            }
        }
        return max_val;
    }
    
    public static int Task2(int[] array)
    {
        int result = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0)
            {
                result++;
            }
        }

        return result;
    }

    public static int Task3(int[] array)
    {
        int result = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] ==  i)
            {
                result++;
            }
        }

        return result;
    }
    public static (int, int) Task4(int[] array)
    {
        int result = 0;
        int suma = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] != 0)
            {
                suma += array[i];
                result++;
            }
        }

        return (suma, result);
    }

    public static int Task5(int[] array)
    {
        int max_val = 0;
        int min_val = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max_val) 
            {
                max_val = array[i];
            }   
        }

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] <= min_val)
            {
                min_val = array[i];
            }
        }

        return max_val - min_val;
    }
   
    public static int[] Task6(int x, int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > x)
            {
                array[i] *= 2;
            }
            else
            {
                array[i] = 0;
            }
            
        }
        return array;
    }
}
