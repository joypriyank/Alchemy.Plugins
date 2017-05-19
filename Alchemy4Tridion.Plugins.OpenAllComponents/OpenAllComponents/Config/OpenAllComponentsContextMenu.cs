using Alchemy4Tridion.Plugins.GUI.Configuration;

namespace OpenAllComponents.Config
{
    class OpenAllComponentsContextMenu : ContextMenuExtension
    {
        OpenAllComponentsContextMenu()
        {
            AssignId = "OpenAllComponentsContextMenu";
            Name = "OpenAllComponentsContextMenu";
            InsertBefore = "cm_refresh";
            
            AddItem("cm_openallcomponents", "Open All", "OpenAllComponents");

            Dependencies.Add<OpenAllComponentsResourceGroup>();

            Apply.ToView(Constants.Views.DashboardView);
        }
    }
}
