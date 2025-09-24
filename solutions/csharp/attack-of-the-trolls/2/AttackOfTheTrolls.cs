static class Permissions
{
    public static Permission2 Default(AccountType accountType)
    {
        return accountType switch
        {
            AccountType.Guest => Permission2.Read,
            AccountType.User => Permission2.Read | Permission2.Write,
            AccountType.Moderator => Permission2.Read | Permission2.Write | Permission2.Delete,
            _ => Permission2.None
        };
    }

    public static Permission2 Grant(Permission2 current, Permission2 grant)
    {
        return current | grant;
    }

    public static Permission2 Revoke(Permission2 current, Permission2 revoke)
    {
        return current & ~revoke;
    }

    public static bool Check(Permission2 current, Permission2 check)
    {
        return (current & check) == check;
    }
}
