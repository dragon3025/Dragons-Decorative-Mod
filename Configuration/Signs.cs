using System.ComponentModel;
using Terraria.ModLoader.Config;

namespace DragonsDecorativeMod.Configuration
{
    internal class Signs : ModConfig
    {
        public override ConfigScope Mode => ConfigScope.ServerSide;

        [ReloadRequired]
        [DefaultValue(true)]
        public bool SignBag { get; set; }

        [ReloadRequired]
        [DefaultValue(true)]
        public bool SignBook { get; set; }

        [ReloadRequired]
        [DefaultValue(true)]
        public bool SignGreenCross { get; set; }

        [ReloadRequired]
        [DefaultValue(true)]
        public bool SignHeart { get; set; }

        [ReloadRequired]
        [DefaultValue(true)]
        public bool SignSwiss { get; set; }
    }
}
