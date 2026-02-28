using System.Reflection.PortableExecutable;
using System.Text;

public static class Identifier
{
    public static string Clean(string identifier)
    {
        var sanitizedCharacters = identifier
            .Replace(" ", "_")
            .Replace("\0", "CTRL");
        
        var stringBuilder = new StringBuilder();
        var capitalizeNext = false;
        
        foreach (var character in sanitizedCharacters)
        {
            if (character == '-')
            {
                capitalizeNext = true;
            }
            else if (char.IsLetter(character) && character is < 'α' or > 'ω')
            {
                stringBuilder.Append(capitalizeNext ? char.ToUpper(character) : character);
                capitalizeNext = false;
            }
            else if (character == '_')
            {
                stringBuilder.Append(character);
                capitalizeNext = false;
            }
            else
            {
                capitalizeNext = false;
            }
        }
        
        return stringBuilder.ToString();
    }
}
