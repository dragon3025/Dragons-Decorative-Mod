using System.ComponentModel;
using Terraria.ModLoader.Config;

namespace DragonsDecorativeMod
{
    [Label("Blocks + Walls")]
    public class ABlocksWallsConfig : ModConfig
    {
        public override ConfigScope Mode => ConfigScope.ServerSide;

        [Header("If an item below is disabled, it wont be obtainable.")]

        [Label("[i:DragonsDecorativeMod/Vines] Wall Vines")]
        [DefaultValue(true)]
        public bool Vines;

        [Label("[i:DragonsDecorativeMod/WallFlowers] Wall Flowers")]
        [DefaultValue(true)]
        public bool WallFlowers;

        [Label("[i:DragonsDecorativeMod/Trellis] Trellis")]
        [DefaultValue(true)]
        public bool Trellis;

        public override bool AcceptClientChanges(ModConfig pendingConfig, int whoAmI, ref string message)
        {
            message = "Can't change settings in a server.";
            return false;
        }
    }

    [Label("Furniture")]
    public class BFurnitureConfig : ModConfig
    {
        public override ConfigScope Mode => ConfigScope.ServerSide;

        [Header("If an item below is disabled, it wont be obtainable.\n\nAmbient Objects")]

        [Label("[i:DragonsDecorativeMod/ForestPot] Pots")]
        [DefaultValue(true)]
        public bool Pots;

        [Label("[i:DragonsDecorativeMod/LargeStoneStalactite] Stalagmites and Stalactites")]
        [Tooltip("Fake version of vanilla object.")]
        [DefaultValue(true)]
        public bool StalagmitesAndStalactites;

        [Label("[i:DragonsDecorativeMod/FakeDemonAltar] Altars Shadow Orb and Crimson Heart")]
        [Tooltip("Fake version of vanilla object.")]
        [DefaultValue(true)]
        public bool AltarsShadowOrbAndCrimsonHeart;

        [Label("[i:DragonsDecorativeMod/FakeLarva] Larva")]
        [Tooltip("Fake version of vanilla object.")]
        [DefaultValue(true)]
        public bool FakeLarva;

        [Label("[i:DragonsDecorativeMod/FallenLog] Fallen Log")]
        [Tooltip("Places vanilla Fallen Log.")]
        [DefaultValue(true)]
        public bool FallenLog;

        [Label("[i:DragonsDecorativeMod/PeacefulPlanteraBulb] Peaceful Plantera Bulb")]
        [Tooltip("Wont spawn Plantera.")]
        [DefaultValue(true)]
        public bool PeacefulPlanteraBulb;

        [Label("[i:DragonsDecorativeMod/AnimalBones] Other")]
        [Tooltip("Fake version of vanilla object.")]
        [DefaultValue(true)]
        public bool OtherAmbient;

        [Header("Christmas")]

        [Label("[i:DragonsDecorativeMod/LightYellow] Christmas Lights")]
        [Tooltip("" +
            "Terraria has Red, Blue, and Green lights. Enabling this will add Cyan, Orange,\n" +
            "Pink, Purple, White, and Yellow Lights")]
        [DefaultValue(true)]
        public bool ChristmasLights;

        [Label("[i:DragonsDecorativeMod/CandyCane] Lawn Candy Cane")]
        [DefaultValue(true)]
        public bool CandyCane;

        [Label("[i:DragonsDecorativeMod/SnowmanLeft] Snowman")]
        [DefaultValue(true)]
        public bool Snowman;

        [Header("Garden")]

        [Label("[i:DragonsDecorativeMod/BonsaiTree] Bonsai Tree")]
        [DefaultValue(true)]
        public bool BonsaiTree;

        [Label("[i:DragonsDecorativeMod/HangingPlant] Hanging Plants")]
        [DefaultValue(true)]
        public bool HangingPlants;

        [Label("[i:DragonsDecorativeMod/RedMushroom] Mushrooms")]
        [DefaultValue(true)]
        public bool Mushrooms;

        [Label("[i:DragonsDecorativeMod/Planter] Planters")]
        [DefaultValue(true)]
        public bool Planters;

        [Label("[i:DragonsDecorativeMod/Plant] Plants")]
        [DefaultValue(true)]
        public bool Plants;

        [Label("[i:DragonsDecorativeMod/PottedMushroomTreeTall] Potted Plants")]
        [DefaultValue(true)]
        public bool PottedPlants;

        [Header("Signs")]

        [Label("[i:DragonsDecorativeMod/SignBag] BagSign")]
        [DefaultValue(true)]
        public bool SignBag;

        [Label("[i:DragonsDecorativeMod/SignBook] BookSign")]
        [DefaultValue(true)]
        public bool SignBook;

        [Label("[i:DragonsDecorativeMod/SignHealthyCross] Healthy Cross Sign")]
        [DefaultValue(true)]
        public bool SignCross;

        [Label("[i:DragonsDecorativeMod/SignHealthySwiss] Healthy Swiss Sign")]
        [DefaultValue(true)]
        public bool SignSwiss;

        [Label("[i:DragonsDecorativeMod/SignHeart] Heart Sign")]
        [DefaultValue(true)]
        public bool SignHeart;

        [Header("Other")]

        [Label("[i:DragonsDecorativeMod/Aquarium] Aquarium")]
        [DefaultValue(true)]
        public bool Aquarium;

        [Label("[i:DragonsDecorativeMod/BoxOfArrows] Box of Arrows")]
        [DefaultValue(true)]
        public bool BoxOfArrows;

        [Label("[i:DragonsDecorativeMod/PaintBottleSingle] Paint Bottle")]
        [DefaultValue(true)]
        public bool PaintBottle;

        [Label("[i:DragonsDecorativeMod/Easel] Easel")]
        [DefaultValue(true)]
        public bool Easel;

        [Label("[i:DragonsDecorativeMod/GolfCart] Golf Cart")]
        [DefaultValue(true)]
        public bool GolfCart;

        [Label("[i:DragonsDecorativeMod/HorizontalBook] Horizontal Book")]
        [DefaultValue(true)]
        public bool HorizontalBook;

        [Label("[i:DragonsDecorativeMod/HospitalBed] Hospital Bed")]
        [DefaultValue(true)]
        public bool HospitalBed;

        [Label("[i:DragonsDecorativeMod/LargeKeg] Large Keg")]
        [DefaultValue(true)]
        public bool LargeKeg;

        [Label("[i:DragonsDecorativeMod/Lectern] Lectern")]
        [DefaultValue(true)]
        public bool Lectern;

        [Label("[i:DragonsDecorativeMod/MannequinHeadRight] Mannequin Head")]
        [DefaultValue(true)]
        public bool MannequinHead;

        [Label("[i:DragonsDecorativeMod/MedusaWatching] Medusa Watching")]
        [DefaultValue(true)]
        public bool MedusaWatching;

        [Label("[i:DragonsDecorativeMod/StaringStatue] Ned the Nosey")]
        [DefaultValue(true)]
        public bool StaringStatue;

        [Label("[i:DragonsDecorativeMod/PaintBucket] Paint Bucket")]
        [DefaultValue(true)]
        public bool PaintBucket;

        [Label("[i:DragonsDecorativeMod/PureSpiritLamp] Pure Spirit Bottle")]
        [DefaultValue(true)]
        public bool PureSpiritLamp;

        [Label("[i:DragonsDecorativeMod/RopeCoilPlaceable] Placeable Rope Coil")]
        [DefaultValue(true)]
        public bool RopeCoilPlaceable;

        [Label("[i:DragonsDecorativeMod/SkeletonModel] Skeleton Model")]
        [DefaultValue(true)]
        public bool SkeletonModel;

        [Label("[i:DragonsDecorativeMod/ThreadPlaceable] Placeable Thread")]
        [DefaultValue(true)]
        public bool ThreadPlaceable;

        public override bool AcceptClientChanges(ModConfig pendingConfig, int whoAmI, ref string message)
        {
            message = "Can't change settings in a server.";
            return false;
        }
    }
}
