using Imc.Models;

namespace Imc;

public static class AppState
{
    public static List<ImcModel> History { get; set; } = new();
    public static event EventHandler<EventArgs> OnChanged;

    public static void NotifyChanges(object? sender, EventArgs args)
    {
        OnChanged.Invoke(sender, args);
    }
}