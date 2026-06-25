using System.ComponentModel;
using Terraria.ModLoader.Config;

namespace DragonsDecorativeMod.Configuration
{
    public class Easter : ModConfig
    {
        public override ConfigScope Mode => ConfigScope.ServerSide;

        [ReloadRequired]
        [DefaultValue(true)]
        public bool EasterBasket { get; set; }

        [ReloadRequired]
        [DefaultValue(true)]
        public bool EasterEggs { get; set; }
    }
}
