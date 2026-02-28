using Nitrox.Model.Configuration;

namespace Nitrox.Launcher.ViewModels.Designer;

internal sealed class DesignObjectPropertyEditorViewModel : ObjectPropertyEditorViewModel
{
    public DesignObjectPropertyEditorViewModel() : base(null!)
    {
        OwnerObject = new SubnauticaServerOptions();
    }
}
