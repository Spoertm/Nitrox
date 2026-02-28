using Nitrox.Launcher.ViewModels;
using Nitrox.Launcher.Views.Abstract;

namespace Nitrox.Launcher.Views;

internal sealed partial class OptionsView : RoutableViewBase<OptionsViewModel>
{
    public OptionsView()
    {
        InitializeComponent();
    }
}
