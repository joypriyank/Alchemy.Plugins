using Alchemy4Tridion.Plugins.GUI.Configuration;

namespace OpenAll.Config
{
    class OpenAllContextMenu : ContextMenuExtension
    {
        OpenAllContextMenu()
        {
            AssignId = "OpenAllContextMenu";
            Name = "OpenAllContextMenu";
            InsertBefore = "cm_refresh";
            
            AddItem("cm_openall", "Open All", "OpenAll");

            Dependencies.Add<OpenAllResourceGroup>();

            Apply.ToView(Constants.Views.DashboardView);
        }
    }
}
