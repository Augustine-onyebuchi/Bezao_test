namespace Test.Solutions;

public class LeapYearSolution
{
    public static void Run()
    {
        PrintNext20LeapYears();
    }

    private static void PrintNext20LeapYears()
    {
        var year = DateTime.Now.Year;
        var count = 0;

        Console.WriteLine("===== NEXT LEAP YEARS =====");
        while (count < 20)
        {
            year += 1;
            if (year % 4 == 0)
            {
                Console.WriteLine("{0}. {1}", count + 1, year);
                count += 1;
            }
        }
    }
}