﻿namespace Selection_Statements_Exercise_01;

internal class Methods
{
    // FOREACH OF THE METHODS BELOW DELETE THIS CODE `throw new NotImplementedException();`
    // AND COMPLETE THE TODO'S
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
        //       - if the value is positive return "POSITIVE +"
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
