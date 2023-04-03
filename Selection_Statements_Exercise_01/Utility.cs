using System.CodeDom.Compiler;

internal class Utility
{
    #region Utility Methods
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
    internal static decimal GenerateRandomValue() => (decimal)(new Random().Next(-1,-2));
    internal static double GetRandomTemperature() => ((new Random().Next(-1000, 4000) / 100.0) * 9 / 5) + 32;
    #endregion

    // Foreach of the methods below delete the `throw new NotImplementedException();` bit of code and complete the TODO's

    internal static bool CheckFor_at_Symbol(string? emailAddress)
    {
        // TODO: Check that the email address contains an @ symbol in the proper place
        //       - if the string is Null or Empty return false
        //       - if the @ symbol is not in the proper spot or there are multiple return false  ex: @123.com  ex: j@ck.b@uer@gmail.com
        //       - if the email address is in a proper format return true ex: JohnDoe123@gmail.com
        throw new NotImplementedException();
    }

    internal static string CheckIfProperlyCapitalized(string firstName, string lastName)
    {
        // TODO: Check that firstName and lastName are properly capitlized
        //       - if any of the names are null return "NULL"
        //       - if any of the names are empty return "EMPTY"
        //       - if any are un-capitalized return "NOT CAPITALIZED CORRECTLY"
        //       - if the names are already properly capitalized return them concatenated together ex: "John Smith"
        throw new NotImplementedException();
    }

    internal static string IsPriceInRange(double value)
    {
        #region Ranges
        // Range 1 - 0.00 -> 9.99
        // Range 2 - 10.00 -> 19.99
        // Range 3 - 20.00 -> 29.99
        // Range 4 - 30.00 -> 39.99
        // Range 5 - 40.00 -> 49.99
        // Range 6 - 50.00 -> 59.99
        // Range 7 - 60.00 -> 69.99
        // Range 8 - 70.00 -> 79.99
        // Range 9 - 80.00 -> 89.99
        // Range 10 - 90.00 -> 100.00
        #endregion
        // TODO: Check if the value is within the following ranges (include 0.00 and 100.00),
        //       - if it is Null or Empty return "NO VALUE"
        //       - if it's not in any of the ranges return "Out of Range"
        //       - if it is within 1 of the ranges above then return "RANGE #" (replace the # with the range number)

        throw new NotImplementedException();
    }

    internal static string IsValueNegative(decimal value)
    {
        // TODO: Determine if the value is negative
        //       - if the value is negative return "NEGATIVE -"
        //       - if the value is positive return "POSTIVIE +"
        //       - if the value is zero return "ZERO 0"
        throw new NotImplementedException();
    }

    internal static void ColdWarmOrHot(double temperature)
    {
        // TODO: Determine if it's Cold, Warm, or Hot outside
        //       - if the tempereature is under 54.99 print "COLD" to the console
        //       - if the temperature is 55 -> 78.6 print "WARM" to the console
        //       - if the temperature is 78.7 or above print "HOT" to the console
        throw new NotImplementedException();
    }

    internal static void War(Card player1Card, Card player2Card)
    {
        // TODO: Print the winner of this hand (Ace is highest)
        //       - if player 1's card is higher print "Player 1 WON!!!"
        //       - if player 2's card is higher print "Player 2 WON!!!"
        //       - if there is a tie print "WAR!!!"
        throw new NotImplementedException();
    }



}
