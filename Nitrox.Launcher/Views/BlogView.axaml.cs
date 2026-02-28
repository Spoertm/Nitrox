using Nitrox.Launcher.ViewModels;
using Nitrox.Launcher.Views.Abstract;

namespace Nitrox.Launcher.Views;

internal sealed partial class BlogView : RoutableViewBase<BlogViewModel>
{
    public BlogView()
    {
        InitializeComponent();
    }
}
