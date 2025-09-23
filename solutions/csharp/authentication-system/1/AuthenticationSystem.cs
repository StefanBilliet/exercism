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
        Admin = admin;
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

    public Identity Admin { get; }

    public IDictionary<string, Identity> GetDevelopers()
    {
        return _developers.AsReadOnly();
    }
}

public struct Identity
{
    public string Email { get; init; }

    public string EyeColor { get; init; }
}
