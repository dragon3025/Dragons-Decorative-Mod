using System.ComponentModel;
using Terraria.ModLoader.Config;

namespace DragonsDecorativeMod.Configuration
{
    public class DragonsDecoModConfig : ModConfig
    {
        public override ConfigScope Mode => ConfigScope.ServerSide;

        [DefaultValue(false)]
        public bool RequireCraftingKey;

        [Expand(false)]
        public DropDownBoxes.Natural Natural;

        [Expand(false)]
        public DropDownBoxes.Christmas Christmas;

        [Expand(false)]
        public DropDownBoxes.Easter Easter;

        [Expand(false)]
        public DropDownBoxes.Garden Garden;

        [Expand(false)]
        public DropDownBoxes.Pets Pets;

        [Expand(false)]
        public DropDownBoxes.StPatricksDay StPatricksDay;

        [Expand(false)]
        public DropDownBoxes.Signs Signs;

        [Expand(false)]
        public DropDownBoxes.Other Other;

        public DragonsDecoModConfig()
        {
            Natural = new DropDownBoxes.Natural() { };
            Christmas = new DropDownBoxes.Christmas() { };
            Easter = new DropDownBoxes.Easter() { };
            Garden = new DropDownBoxes.Garden() { };
            Pets = new DropDownBoxes.Pets() { };
            StPatricksDay = new DropDownBoxes.StPatricksDay() { };
            Signs = new DropDownBoxes.Signs() { };
            Other = new DropDownBoxes.Other() { };
        }

        public override bool AcceptClientChanges(ModConfig pendingConfig, int whoAmI, ref string message)
        {
            message = "Can't change settings in a server.";
            return false;
        }
    }
}
