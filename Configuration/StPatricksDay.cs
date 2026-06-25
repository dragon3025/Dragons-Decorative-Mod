using System.ComponentModel;
using Terraria.ModLoader.Config;

namespace DragonsDecorativeMod.Configuration
{
    internal class StPatricksDay : ModConfig
    {
        public override ConfigScope Mode => ConfigScope.ServerSide;

        [ReloadRequired]
        [DefaultValue(true)]
        public bool CloverDecal { get; set; }

        [ReloadRequired]
        [DefaultValue(true)]
        public bool PaintingLuringToGold { get; set; }

    }
}
