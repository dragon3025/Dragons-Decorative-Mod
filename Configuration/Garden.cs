using System.ComponentModel;
using Terraria.ModLoader.Config;

namespace DragonsDecorativeMod.Configuration
{
    internal class Garden : ModConfig
    {
        public override ConfigScope Mode => ConfigScope.ServerSide;

        [Header("BlocksAndWalls")]

        [ReloadRequired]
        [DefaultValue(true)]
        public bool Trellis { get; set; }

        [ReloadRequired]
        [DefaultValue(true)]
        public bool Vines { get; set; }

        [ReloadRequired]
        [DefaultValue(true)]
        public bool WallFlowers { get; set; }


        [Header("Other")]

        [ReloadRequired]
        [DefaultValue(true)]
        public bool BonsaiTree { get; set; }

        [ReloadRequired]
        [DefaultValue(true)]
        public bool Clover { get; set; }

        [ReloadRequired]
        [DefaultValue(true)]
        public bool HangingPlants { get; set; }

        [ReloadRequired]
        [DefaultValue(true)]
        public bool Mushrooms { get; set; }

        [ReloadRequired]
        [DefaultValue(true)]
        public bool NatureGlobe { get; set; }

        [ReloadRequired]
        [DefaultValue(true)]
        public bool Planters { get; set; }

        [ReloadRequired]
        [DefaultValue(true)]
        public bool Plants { get; set; }

        [ReloadRequired]
        [DefaultValue(true)]
        public bool PottedPlants { get; set; }

    }
}
