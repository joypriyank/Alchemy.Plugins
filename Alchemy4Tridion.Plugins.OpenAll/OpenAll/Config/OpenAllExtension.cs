
using Alchemy4Tridion.Plugins.GUI.Configuration;

namespace OpenAll.Config
{
    class OpenAllExtension : RibbonToolbarExtension
    {
        public OpenAllExtension()
        {

            // The unique identifier used for the html element created.
            AssignId = "RibbonToolbarOpenAll";

            // The name of the command to execute when clicked
            Command = "OpenAll";

            // The label of the button.
            Name = "Open All";

            // The page tab to assign this extension to. See Constants.PageIds.
            PageId = Constants.PageIds.HomePage;

            // Option GroupId, put this into an existing group
            GroupId = Constants.GroupIds.HomePage.ManageGroup;
            //GroupId = "GoToLocationGroup";

            InsertBefore = "BlueprintHierarchyBtn";

            // The tooltip label that will get applied.
            Title = "Open All";

            // Add a dependency to the resource group that contains the files/commands that this toolbar extension will use.
            Dependencies.Add<OpenAllResourceGroup>();
            
            Apply.ToView(Constants.Views.DashboardView);
           
        }
    }
}

