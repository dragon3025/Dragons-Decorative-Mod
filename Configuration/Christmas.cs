using System.ComponentModel;
using Terraria.ModLoader.Config;

namespace DragonsDecorativeMod.Configuration
{
    public class Christmas : ModConfig
    {
        public override ConfigScope Mode => ConfigScope.ServerSide;

        [ReloadRequired]
        [DefaultValue(true)]
        public bool CandyCane { get; set; }

        [ReloadRequired]
        [DefaultValue(true)]
        public bool ChristmasStocking { get; set; }

        [ReloadRequired]
        [DefaultValue(true)]
        public bool GingerbreadHouse { get; set; }

        [ReloadRequired]
        [DefaultValue(true)]
        public bool LightPaintable { get; set; }

        [ReloadRequired]
        [DefaultValue(true)]
        public bool Mistletoe { get; set; }

        [ReloadRequired]
        [DefaultValue(true)]
        public bool SnowGlobe { get; set; }

        [ReloadRequired]
        [DefaultValue(true)]
        public bool Snowman { get; set; }

        [ReloadRequired]
        [DefaultValue(true)]
        public bool StarSnowGlobe { get; set; }

    }
}
