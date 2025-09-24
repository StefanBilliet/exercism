static class Permissions
{
    [Flags]
    public enum Permission
    {
        All    = Read | Write | Delete,
        None   = 0,
        Read   = 1,
        Write  = 2,
        Delete = 4
    }
    
    public enum AccountType
    {
        Guest,
        User,
        Moderator
    }
    
    public static Permission Default(AccountType accountType)
    {
        return accountType switch
        {
            AccountType.Guest => Permission.Read,
            AccountType.User => Permission.Read | Permission.Write,
            AccountType.Moderator => Permission.Read | Permission.Write | Permission.Delete,
            _ => Permission.None
        };
    }

    public static Permission Grant(Permission current, Permission grant)
    {
        return current | grant;
    }

    public static Permission Revoke(Permission current, Permission revoke)
    {
        return current & ~revoke;
    }

    public static bool Check(Permission current, Permission check)
    {
        return (current & check) == check;
    }
}
