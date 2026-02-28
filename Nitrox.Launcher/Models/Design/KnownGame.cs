using Nitrox.Model.Platforms.Discovery.Models;

namespace Nitrox.Launcher.Models.Design;

public sealed class KnownGame
{
    public required string PathToGame { get; init; }
    public required Platform Platform { get; init; }
}
