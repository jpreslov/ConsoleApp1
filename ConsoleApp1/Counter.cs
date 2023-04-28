public class InputReader
{
    public void Greeting()
    {
        Console.WriteLine("Please enter the number you wish to count to:");
    }

    public void NumChecks(string countTo, string countBy)
    {
        if (countTo != null && countBy != null && !countTo.Contains(" ") && !countBy.Contains(" "))
        {
            long countToLong = long.Parse(countTo);
            long countByLong = long.Parse(countBy);
            Console.WriteLine("Count to " + countToLong + " in increments of " + countByLong);
        }
        else { Console.WriteLine("fuck you don't put spaces in that shit"); }
    }
}
