public class Authenticator
{
    private class EyeColor
    {
        public const string Blue = "blue";
        public const string Green = "green";
        public const string Brown = "brown";
        public const string Hazel = "hazel";
        public const string Grey = "grey";
    }

    public Authenticator(Identity admin)
    {
        _admin = admin;
    }

    private readonly IDictionary<string, Identity> _developers
        = new Dictionary<string, Identity>
        {
            ["Bertrand"] = new()
            {
                Email = "bert@ex.ism",
                EyeColor = "blue"
            },

            ["Anders"] = new()
            {
                Email = "anders@ex.ism",
                EyeColor = "brown"
            }
        };

    private readonly Identity _admin;

    public Identity Admin => new() { Email = _admin.Email, EyeColor = _admin.EyeColor };

    public IDictionary<string, Identity> GetDevelopers()
    {
        return _developers.AsReadOnly();
    }
}

public record Identity
{
    public required string Email { get; set; }

    public required string EyeColor { get; init; }
}