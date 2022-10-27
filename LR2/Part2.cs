namespace Part2;
public static class Tasks
{
    public static int Task1(int T)
    {
        if (T > 0) 
        {
            return ++T;
        }
        else 
        {
            return T;
        }
    }

    public static int Task2(int T)
    {
        if (T > 0) 
        {
            return T + 5;
        }
        else if (T < 0) 
        {
            return T - 4;
        }
        else 
        {
            return 1;
        }
    }

    public static int Task3(int t1, int t2, int t3)
    {
        int min_t = 0;

        if (t1 < t2 && t1 < t3) 
        {
            min_t = t1;
        } else if (t2 < t1 && t2 < t3) 
        {
            min_t = t2;
        } else if (t3 < t1 && t3 < t1) 
        {
            min_t = t3;
        }
            
        return min_t;
    }

    public static int Task4(int u1, int u2, int u3)
    {
        int min_u = 0;

        if (u1 < u2 && u1 < u3)
        {
            min_u = u1;
        }
        else if (u2 < u1 && u2 < u3)
        {
            min_u = u2;
        }
        else if (u3 < u1 && u3 < u1)
        {
            min_u = u3;
        }

        return u1 + u2 + u3 - min_u;
    }

    public static (int, int, int) Task5(int u1, int u2, int u3)
    {
        int min_u = 0;

        if (u1 < u2 && u1 < u3)
        {
            min_u = u1;
        }
        else if (u2 < u1 && u2 < u3)
        {
            min_u = u2;
        }
        else if (u3 < u1 && u3 < u1)
        {
            min_u = u3;
        }

        int max_u = 0;

        if (u1 > u2 && u1 > u3)
        {
            max_u = u1;
        }
        else if (u2 > u1 && u2 > u3)
        {
            max_u = u2;
        }
        else if (u3 > u1 && u3 > u1)
        {
            max_u = u3;
        }

        return (min_u, u1+u2+u3-min_u-max_u, max_u);
    }

    public static (int, int, int) Task6(int u1, int u2, int u3)
    {
        if (u1 > u2 && u2 > u3)
        {
            return (u1 * 2, u2 * 2, u3 * 2);
        }
        else if (u3 > u2 && u2 > u1)
        {
            return (u1 * 2, u2 * 2, u3 * 2);
        }
        else
        {
            return (0 - u1, 0 - u2, 0 - u3);
        }
    }
    
    public static int Task7(int ri, int rj)
    {
        int sum = 0;

        for (int i = 0; i <= rj - ri; i++)
        {
            if ((ri + i) % 2 == 0)
            {
                sum += ri + i;
            }
        }
        return sum;
    }

    public static int Task8(int ri, int rj)
    {
        int sum = 0;

        for (int i = 0; i <= rj - ri; i++)
        {
            if ((ri + i) % 2 != 0)
            {
                sum += ri + i;
            }
        }
        return sum;
    }

    static int getNumber(int value)
    {
        if (value < 10)
        {
            if (value % 2 != 0)
            {
                return value;
            }
        }
        if (value == 0)
        {
            return value;
        }

        int digit = value % 10;
        int nextValue = value / 10;

        if (digit % 2 != 0)
        {
            return digit + getNumber(nextValue);
        }
        else
        {
            return getNumber(nextValue);
        }
    }

    public static int Task9(int x)
    {
        int ret_value = 0;

        ret_value = getNumber(x);

        return ret_value;
    }
}