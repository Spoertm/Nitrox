using Nitrox.Launcher.Models.Services;
using Nitrox.Model.Helper;

namespace Nitrox.Launcher.ViewModels.Designer;

internal sealed class DesignServersViewModel() : ServersViewModel(KeyValueStore.Instance, null!, new ServerService(null!, KeyValueStore.Instance, null!), null!);
