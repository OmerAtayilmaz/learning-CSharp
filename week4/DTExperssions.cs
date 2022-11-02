namespace week4;

//SORU VAR - 2 tane
public class DTExperssions
{
    public void getDate()
    {

        DateTime dt = new DateTime();
        Console.WriteLine(dt.ToString());
        Console.WriteLine(dt.Date.ToString());
        Console.WriteLine(dt.Date.Day.ToString());
        Console.WriteLine(dt.Hour);
        Console.WriteLine(dt.Month);
    }

    public void myBirthDate()
    {
        DateTime dt = new DateTime(2001,01,01,0,0,0);
        Console.WriteLine(dt.ToString());
    }

    public void getCurrentTime()
    {
        Console.WriteLine(DateTime.Now);
        Console.WriteLine(DateTime.Today);
        Console.WriteLine(DateTime.UtcNow);
    }

    public int myAge(int birthDate)
    {
        return DateTime.Now.Year - birthDate;
    }

    public void example2()
    {
        string str = "01/01/2001 7:10:24 AM";
        DateTime dt;
        var isValidDate = DateTime.TryParse(str, out dt);
        if(isValidDate)
            Console.WriteLine(dt);
        else
            Console.WriteLine($"{str} is not a valid date string");
    }
}