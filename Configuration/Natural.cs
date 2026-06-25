using System.ComponentModel;
using Terraria.ModLoader.Config;

namespace DragonsDecorativeMod.Configuration
{
    internal class Natural : ModConfig
    {
        public override ConfigScope Mode => ConfigScope.ServerSide;

        [ReloadRequired]
        [DefaultValue(true)]
        public bool AltarsShadowOrbAndCrimsonHeart { get; set; }

        [ReloadRequired]
        [DefaultValue(true)]
        public bool FakeLarva { get; set; }

        [ReloadRequired]
        [DefaultValue(true)]
        public bool FallenLog { get; set; }

        [ReloadRequired]
        [DefaultValue(true)]
        public bool GranitePots { get; set; }

        [ReloadRequired]
        [DefaultValue(true)]
        public bool MysteriousTablet { get; set; }

        [ReloadRequired]
        [DefaultValue(true)]
        public bool PeacefulPlanteraBulb { get; set; }

    }
}
