namespace Gex.Shared.Types;

public record Message(Guid messageId, string username, string content, DateTime sendtime);