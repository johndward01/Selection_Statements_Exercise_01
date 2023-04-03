using Selection_Statements_Exercise_01;

internal class Utility
{
    private static string GenerateRandomString(int length, string characters)
    {
        char[] result = new char[length];
        Random random = new();
        for (int i = 0; i < length; i++)
        {
            result[i] = characters[random.Next(characters.Length)];
        }
        return new string(result);
    }

    private static string GenerateRandomCardSuit()
    {
        var suits = new List<string>() { "Clubs", "Diamonds", "Spades", "Hearts" };
        return suits[new Random().Next(suits.Count)];
    }

    private static string GenerateRandomCardValue()
    {
        var cardValues = new List<string>() { "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King", "Ace" };
        return cardValues[new Random().Next(cardValues.Count)];
    }

    internal static Card GenerateRandomCard() => new(GenerateRandomCardSuit(), GenerateRandomCardValue());
    
    internal static string GenerateRandomEmail()
    {
        // Generate a random username
        string username = GenerateRandomString(10, "abcdefghijklmnopqrstuvwxyz0123456789");
        // Generate a random domain name
        string domain = GenerateRandomString(10, "abcdefghijklmnopqrstuvwxyz");
        // Generate a random top-level domain
        string[] topLevelDomains = { "com", "net", "org", "edu", "gov", "mil" };
        string topLevelDomain = topLevelDomains[new Random().Next(topLevelDomains.Length)];
        // Concatenate the username, domain, and top-level domain to form the email address
        string email = $"{username}@{domain}.{topLevelDomain}";
        
        var emails = new List<string>() { "Empty", null, email };

        return emails[new Random().Next(0, 3)];

    }

    internal static string GenerateRandomFirstName() => new Bogus.Person().FirstName;
    
    internal static string GenerateRandomLastName() => new Bogus.Person().LastName;
    
    internal static double GenerateRandomPrice() => Convert.ToDouble(new Bogus.DataSets.Commerce().Price(-1, 101));
    
    internal static int GenerateRandomValue() => (new Random().Next(-1,-2));
    
    internal static double GetRandomTemperature() => ((new Random().Next(-1000, 4000) / 100.0) * 9 / 5) + 32; 
}
