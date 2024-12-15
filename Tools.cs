//Programando en mas de un .cs
class Tools
{
    public static bool ValidDay(int day, int month, int year)
    {
        if (year == 1582 && month == 10 && day >= 5 && day <= 14) return false;

        else if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12)
        {
            if (day >= 1 && day <= 31) return true;

            else return false;
        }

        else if (month == 4 || month == 6 || month == 9 || month == 11)
        {
            if (day >= 1 && day <= 30) return true;

            else return false;
        }

        else if (month == 2)
        {
            if (day >= 1 && day <= 29 && IsLeap(year)) return true;

            else if (day >= 1 && day <= 28 && !IsLeap(year)) return true;

            else return false;
        }

        else return false;
    }

    public static bool IsLeap(int year)
    {
        return ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0);
    }

    public static int NumberOfDays(int day, int month, int year)
    {
        int totalDays = 0;
        for (int i = 1; i < year; i++)
        {
            totalDays += IsLeap(i) ? 366 : 365;
        }

        int[] arrayMonth = { 31, IsLeap(year) ? 29 : 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

        for (int i = 0; i < month - 1; i++)
        {
            totalDays += arrayMonth[i];
        }

        return totalDays += day;
    }
}