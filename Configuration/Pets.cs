using System.ComponentModel;
using Terraria.ModLoader.Config;

namespace DragonsDecorativeMod.Configuration
{
    internal class Pets : ModConfig
    {
        public override ConfigScope Mode => ConfigScope.ServerSide;


        [ReloadRequired]
        [DefaultValue(true)]
        public bool Aquarium { get; set; }

        [ReloadRequired]
        [DefaultValue(true)]
        public bool OwlStand { get; set; }
    }
}
