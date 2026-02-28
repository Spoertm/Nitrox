using System;
using Nitrox.Launcher.Models.Design;
using Nitrox.Launcher.ViewModels.Abstract;

namespace Nitrox.Launcher.Models;

/// <summary>
///     Sent when a save is deleted outside the Servers view (i.e. server manage view or via file explorer).
/// </summary>
internal sealed record SaveDeletedMessage(string SaveName);

internal sealed record NotificationAddMessage(NotificationItem Item);

internal sealed record NotificationCloseMessage(NotificationItem Item);

internal sealed record ShowViewMessage
{
    public required RoutableViewModelBase ViewModel { get; init; }
}

internal sealed record ShowPreviousViewMessage(Type? RoutableViewModelType = null);

internal sealed record ServerStatusMessage(int ProcessId, bool IsOnline, int PlayerCount = 0);
