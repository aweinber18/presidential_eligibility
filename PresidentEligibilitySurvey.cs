// See https://aka.ms/new-console-template for more information
public class PresidentEligibilitySurvey
{
    private bool isNaturalBornCitizen
    {
        get
        {
            Console.WriteLine("Are you a citizen of the US and born in the US?");
            return Console.ReadLine().ToLower().StartsWith("y");
        }
    }
    private short birthYear
    {
        get
        {
            Console.WriteLine("What is your year of birth?");
            return short.Parse(Console.ReadLine());
        }
    }
    private short yearsInUS
    {
        get
        {
            Console.WriteLine("How many years have you resided in the US?");
            return short.Parse(Console.ReadLine());
        }
    }
    private short termsServed
    {
        get
        {
            Console.WriteLine("How many prior terms have you served in office?");
            return short.Parse(Console.ReadLine());
        }
    }
    private bool hasRebelled
    {
        get
        {
            Console.WriteLine("Have you rebelled against the US?");
            return Console.ReadLine().ToLower().StartsWith("y");
        }
    }

    public bool isEligibleToBePresident()
    {
        return isNaturalBornCitizen 
            && short.Parse(DateTime.Now.Year.ToString()) - birthYear >= 35 
            && yearsInUS >= 14 
            && termsServed < 2 
            && ! hasRebelled;
    }

    public static void Main(string[] args)
    {
        if (new PresidentEligibilitySurvey().isEligibleToBePresident())
            Console.WriteLine("You are eligible to run for president.");
        else
            Console.WriteLine("You are ineligible to run for president.");
    }

}