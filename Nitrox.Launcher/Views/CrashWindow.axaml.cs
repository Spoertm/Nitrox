using Nitrox.Launcher.ViewModels;
using Nitrox.Launcher.Views.Abstract;

namespace Nitrox.Launcher.Views;

internal sealed partial class CrashWindow : WindowEx<CrashWindowViewModel>
{
    public CrashWindow()
    {
        InitializeComponent();
    }
}
