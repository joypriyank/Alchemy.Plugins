using Alchemy4Tridion.Plugins.GUI.Configuration;

namespace OpenAllComponents.Config
{
    class OpenAllComponentsResourceGroup : ResourceGroup
    {
        public OpenAllComponentsResourceGroup()
        {
            AddFile("OpenAllComponentsCommand.js");
            AddFile("OpenAllComponents.css");
            AddFile<OpenAllComponentsCommandSet>();
        }
    }
}
