using System.ComponentModel;
using Terraria.ModLoader.Config;

namespace DragonsDecorativeMod.Configuration
{
    internal class Other : ModConfig
    {
        public override ConfigScope Mode => ConfigScope.ServerSide;

        [Header("CraftedWithWood")]

        [ReloadRequired]
        [DefaultValue(true)]
        public bool BoxOfArrows { get; set; }

        [ReloadRequired]
        [DefaultValue(true)]
        public bool Easel { get; set; }

        [ReloadRequired]
        [DefaultValue(true)]
        public bool LargeKeg { get; set; }

        [ReloadRequired]
        [DefaultValue(true)]
        public bool Lectern { get; set; }

        [ReloadRequired]
        [DefaultValue(true)]
        public bool MannequinHead { get; set; }

        [ReloadRequired]
        [DefaultValue(true)]
        public bool StepStoolPlaceable { get; set; }

        [Header("Trophies")]

        [ReloadRequired]
        [DefaultValue(true)]
        public bool BestiaryTrophy { get; set; }

        [ReloadRequired]
        [DefaultValue(true)]
        public bool SlimeTrophy { get; set; }

        [Header("Other")]

        [ReloadRequired]
        [DefaultValue(true)]
        public bool Balloons { get; set; }

        [ReloadRequired]
        [DefaultValue(true)]
        public bool Globe { get; set; }

        [ReloadRequired]
        [DefaultValue(true)]
        public bool GolfCart { get; set; }

        [ReloadRequired]
        [DefaultValue(true)]
        public bool HorizontalBook { get; set; }

        [ReloadRequired]
        [DefaultValue(true)]
        public bool HospitalBed { get; set; }

        [ReloadRequired]
        [DefaultValue(true)]
        public bool LargePot { get; set; }

        [ReloadRequired]
        [DefaultValue(true)]
        public bool MedusaWatching { get; set; }

        [ReloadRequired]
        [DefaultValue(true)]
        public bool PaintBottle { get; set; }

        [ReloadRequired]
        [DefaultValue(true)]
        public bool PaintBucket { get; set; }

        [ReloadRequired]
        [DefaultValue(true)]
        public bool PureSpiritLamp { get; set; }

        [ReloadRequired]
        [DefaultValue(true)]
        public bool RopeCoilPlaceable { get; set; }

        [ReloadRequired]
        [DefaultValue(true)]
        public bool Shampoo { get; set; }

        [ReloadRequired]
        [DefaultValue(true)]
        public bool SkeletonModel { get; set; }

        [ReloadRequired]
        [DefaultValue(true)]
        public bool StaringStatue { get; set; }

        [ReloadRequired]
        [DefaultValue(true)] public bool ThreadPlaceable { get; set; }
    }
}
