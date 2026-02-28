using CommunityToolkit.Mvvm.Input;
using Nitrox.Launcher.ViewModels.Abstract;

namespace Nitrox.Launcher.ViewModels;

internal sealed partial class CommunityViewModel : RoutableViewModelBase
{
    [RelayCommand]
    private static void DiscordLink()
    {
        OpenUri("discord.gg/E8B4X9s");
    }

    [RelayCommand]
    private static void XLink()
    {
        OpenUri("x.com/modnitrox");
    }

    [RelayCommand]
    private static void RedditLink()
    {
        OpenUri("reddit.com/r/SubnauticaNitrox");
    }

    [RelayCommand]
    private static void BlueskyLink()
    {
        OpenUri("bsky.app/profile/nitroxmod.bsky.social");
    }

    [RelayCommand]
    private static void GithubLink()
    {
        OpenUri("github.com/SubnauticaNitrox/Nitrox");
    }
}
