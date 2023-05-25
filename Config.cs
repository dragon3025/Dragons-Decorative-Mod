using System.ComponentModel;
using Terraria.ModLoader.Config;

namespace DragonsDecorativeMod
{
    public class ABlocksWallsConfig : ModConfig
    {
        public override ConfigScope Mode => ConfigScope.ServerSide;

        [Header("BlocksAndWalls")]

        [DefaultValue(true)]
        public bool Vines;

        [DefaultValue(true)]
        public bool WallFlowers;

        [DefaultValue(true)]
        public bool Trellis;

        public override bool AcceptClientChanges(ModConfig pendingConfig, int whoAmI, ref string message)
        {
            message = "Can't change settings in a server.";
            return false;
        }
    }

    public class BFurnitureConfig : ModConfig
    {
        public override ConfigScope Mode => ConfigScope.ServerSide;

        #region Natural
        [Header("Ambient")]
        [DefaultValue(true)]
        public bool Pots;

        [DefaultValue(true)]
        public bool AltarsShadowOrbAndCrimsonHeart;

        [DefaultValue(true)]
        public bool FakeLarva;

        [DefaultValue(true)]
        public bool FallenLog;

        [DefaultValue(true)]
        public bool PeacefulPlanteraBulb;

        [DefaultValue(true)]
        public bool MysteriousTablet;
        #endregion

        #region Christmas
        [Header("Christmas")]

        [DefaultValue(true)]
        public bool ChristmasLights;

        [DefaultValue(true)]
        public bool CandyCane;

        [DefaultValue(true)]
        public bool Snowman;
        #endregion

        #region Easter
        [Header("Easter")]

        [DefaultValue(true)]
        public bool EasterBasket;

        [DefaultValue(true)]
        public bool EasterEgg;

        [DefaultValue(true)]
        public bool EasterEggSingleColor;

        [DefaultValue(true)]
        public bool PlasticEgg;
        #endregion

        #region Garden
        [Header("Garden")]

        [DefaultValue(true)]
        public bool BonsaiTree;

        [DefaultValue(true)]
        public bool Clover;

        [DefaultValue(true)]
        public bool HangingPlants;

        [DefaultValue(true)]
        public bool Mushrooms;

        [DefaultValue(true)]
        public bool Planters;

        [DefaultValue(true)]
        public bool Plants;

        [DefaultValue(true)]
        public bool PottedPlants;
        #endregion

        #region Paintings
        [Header("Paintings")]

        [DefaultValue(true)]
        public bool PaintingLuringToGold;

        [DefaultValue(true)]
        public bool MedusaWatching;
        #endregion

        #region Signs
        [Header("Signs")]

        [DefaultValue(true)]
        public bool SignBag;

        [DefaultValue(true)]
        public bool SignBook;

        [DefaultValue(true)]
        public bool SignCross;

        [DefaultValue(true)]
        public bool SignSwiss;

        [DefaultValue(true)]
        public bool SignHeart;
        #endregion

        #region Other
        [Header("Other")]

        [DefaultValue(true)]
        public bool Aquarium;

        [DefaultValue(true)]
        public bool Balloons;

        [DefaultValue(true)]
        public bool BoxOfArrows;

        [DefaultValue(true)]
        public bool CloverDecal;

        [DefaultValue(true)]
        public bool PaintBottle;

        [DefaultValue(true)]
        public bool Easel;

        [DefaultValue(true)]
        public bool Globe;

        [DefaultValue(true)]
        public bool GolfCart;

        [DefaultValue(true)]
        public bool HorizontalBook;

        [DefaultValue(true)]
        public bool HospitalBed;

        [DefaultValue(true)]
        public bool LargeKeg;

        [DefaultValue(true)]
        public bool LargePot;

        [DefaultValue(true)]
        public bool Lectern;

        [DefaultValue(true)]
        public bool MannequinHead;

        [DefaultValue(true)]
        public bool StaringStatue;

        [DefaultValue(true)]
        public bool PaintBucket;

        [DefaultValue(true)]
        public bool PureSpiritLamp;

        [DefaultValue(true)]
        public bool RopeCoilPlaceable;

        [DefaultValue(true)]
        public bool SkeletonModel;

        [DefaultValue(true)]
        public bool ThreadPlaceable;
        #endregion
        public override bool AcceptClientChanges(ModConfig pendingConfig, int whoAmI, ref string message)
        {
            message = "Can't change settings in a server.";
            return false;
        }
    }
}
