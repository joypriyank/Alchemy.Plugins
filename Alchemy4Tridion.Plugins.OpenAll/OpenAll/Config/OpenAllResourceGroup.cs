using Alchemy4Tridion.Plugins.GUI.Configuration;

namespace OpenAll.Config
{
    class OpenAllResourceGroup : ResourceGroup
    {
        public OpenAllResourceGroup()
        {
            AddFile("OpenAllCommand.js");
            AddFile("OpenAll.css");
            AddFile<OpenAllCommandSet>();
        }
    }
}
