using Selection_Statements_Exercise_01;

// TODO: Go into the Methods class and complete all of the TODO's

var emailAddress = Utility.GenerateRandomEmail();
var has_at_symbol = Methods.CheckFor_at_Symbol(emailAddress);
Console.WriteLine(has_at_symbol);


var firstName = Utility.GenerateRandomFirstName();
var lastName = Utility.GenerateRandomLastName();
var isProperlyCapitalized = Methods.CheckIfProperlyCapitalized(firstName, lastName);
Console.WriteLine(isProperlyCapitalized);


var price = Utility.GenerateRandomPrice();
var priceRange = Methods.IsPriceInRange(price);
Console.WriteLine(priceRange);


var value = Utility.GenerateRandomValue();
var isNegative = Methods.IsValueNegative(value);
Console.WriteLine(isNegative);


var temperature = Utility.GetRandomTemperature();
Methods.ColdWarmOrHot(temperature);


var card1 = Utility.GenerateRandomCard();
var card2 = Utility.GenerateRandomCard();
Methods.War(card1, card2);