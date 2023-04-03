namespace Selection_Statements_Exercise_01;

public class Card 
{
    public Card(string suit, string value)
    {
        Suit = suit;
        Value = value;
    }
    public string Suit { get; set; }
    public string Value { get; set; }
}