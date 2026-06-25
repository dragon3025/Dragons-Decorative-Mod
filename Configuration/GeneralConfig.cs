using System.ComponentModel;
using Terraria.ModLoader.Config;

namespace DragonsDecorativeMod.Configuration
{
    public enum CraftingKeyEnums
    {
        Disabled,
        Ingredient,
        Tile,
        Both,
    }

    public class GeneralConfig : ModConfig
    {
        public override ConfigScope Mode => ConfigScope.ServerSide;

        [ReloadRequired]
        [DefaultValue(CraftingKeyEnums.Disabled)]
        public CraftingKeyEnums RequireCraftingKey { get; set; }

        [ReloadRequired]
        [DefaultValue(true)]
        public bool Inclinometer { get; set; }
    }
}
