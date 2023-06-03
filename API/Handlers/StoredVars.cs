using CSL.Encryption;
using Gex.Shared.Types;

namespace Gex.API.Handlers;

public static class StoredVars
{
    public static string privKey = "";
    public static AES256KeyBasedProtector? protector { get; set; }
    public static List<Message> messages = new();
}