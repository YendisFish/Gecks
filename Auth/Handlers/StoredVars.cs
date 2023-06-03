namespace Gex.Auth.Handlers;

public static class StoredVars
{
    public static Dictionary<Guid, Tuple<string, string>> Authenticated = new();
    internal static string privKey = "";

    internal static bool IsAuthed(Guid uuid)
    {
        return Authenticated.ContainsKey(uuid);
    }
}