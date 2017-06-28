/**
 * Creates an anguilla command using a wrapper shorthand.
 *
 * Note the ${PluginName} will get replaced by the actual plugin name.
 */
//Intialize purpose variable
Alchemy.command("${PluginName}", "OpenAll", {
    /**
    * If an init function is created, this will be called from the command's constructor when a command instance
    * is created.
    */
    init: function () {
        console.log("Init Method");
    },

    /**
     * Whether or not the command is enabled for the user (will usually have extensions displayed but disabled).
     * @returns {boolean}
     */
    isEnabled: function (selection) {
        return this.isAvailable(selection);
    },

    /**
     * Whether or not the command is available to the user.
     * @returns {boolean}
     */
    isAvailable: function (selection) {

        if (selection.getCount() > 1) {
            var item = $models.getItem(selection.getItem(0));
            var itemType = item.getItemType();
            if (itemType == $const.ItemType.COMPONENT || itemType == $const.ItemType.SCHEMA
                || itemType == $const.ItemType.COMPONENT_TEMPLATE || itemType == $const.ItemType.PAGE_TEMPLATE
                || itemType == $const.ItemType.PAGE) {
                return true;
            }
        }
        return false;
    },

    /**
     * Executes the command.
     */
    execute: function (selection) {
        for (var i = 0; i < selection.getCount() ; i++) {
            var select = new Tridion.Cme.Selection();
            select.addItem(selection.getItem(i));
            $commands.executeCommand("Open", select);
        }
    }
});