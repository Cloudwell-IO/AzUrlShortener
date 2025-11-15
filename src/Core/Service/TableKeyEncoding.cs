namespace Cloud5mins.ShortenerTools.Core.Service;

public static class TableKeyEncoding
{
    // Azure Table Storage keys cannot contain "/", "\\", "#", "?" and control characters.
    // Use percent-encoding to store any unsafe characters; reversible with Unescape.
    public static string EncodeKey(string key)
    {
        if (string.IsNullOrEmpty(key)) return key ?? string.Empty;
        return Uri.EscapeDataString(key);
    }

    public static string DecodeKey(string key)
    {
        if (string.IsNullOrEmpty(key)) return key ?? string.Empty;
        return Uri.UnescapeDataString(key);
    }
}
