using System.Data.SqlTypes;

namespace Part1;
public static class Tasks
{
    public static string Task1(int length)
    {
        int per = length * 4;
        return $"Периметр = {per}";
    }

    public static string Task2(int s1, int s2, int s3)
    {
        int volume = s1 * s2 * s3;
        int ploshchaPoverkhni = ((s1 * s3) * 2) + ((s2 * s3) * 2) + ((s1 * s2) * 2);
        return $"Довжина = {volume}, Площа поверхні = {ploshchaPoverkhni}";
    }

    public static string Task3(int x)
    {
        int pcb_area = x*x;
        return $"Площа PCB = {pcb_area}";
    }

    public static string Task4(int x)
    {
        int desiatki = x / 10;
        return $"Десятків: {desiatki}";
    }

    public static string Task5(int x)
    {
        int summ = (x / 10) + (x - (x / 10) * 10);
        int dobutok = (x / 10) * (x - (x / 10) * 10);
        return $"Сума = {summ}, Добуток = {dobutok}";
    }

    public static string Task6(int x)
    {
        int summ = (x / 100) + ((x - (x / 100) * 100) / 10) + (x - (x / 100) * 100) - ((x - (x / 100) * 100) / 10) * 10;
        int dobutok = (x / 100) * ((x - (x / 100) * 100) / 10) * ((x - (x / 100) * 100) - ((x - (x / 100) * 100) / 10) * 10);
        return $"Сума = {summ}, Добуток = {dobutok}";
    }
}
