using DragonsDecorativeMod.Content.Items.Placeable.Garden;
using DragonsDecorativeMod.Content.Items.Placeable.Garden.PottedPlants;
using Terraria.GameContent.ItemDropRules;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace DragonsDecorativeMod.Common
{
    public class GrabBags : GlobalItem
    {
        public override void ModifyItemLoot(Terraria.Item item, ItemLoot itemLoot)
        {
            if (GetInstance<Configuration.Natural>().MysteriousTablet)
            {
                if (item.type == ItemID.MoonLordBossBag)
                {
                    itemLoot.Add(ItemDropRule.Common(ItemType<Content.Items.Placeable.Natural.MysteriousTablet>(), 5));
                }
            }

            if (GetInstance<Configuration.Garden>().HangingPlants)
            {
                if (item.type == ItemID.LavaCrate || item.type == ItemID.LavaCrateHard)
                {
                    itemLoot.Add(ItemDropRule.OneFromOptions(4,
                        ItemType<HangingPlant>(),
                        ItemType<HangingFernPlant>(),
                        ItemType<HangingLeafyPlant>()));
                }
            }

            if (GetInstance<Configuration.Garden>().PottedPlants)
            {
                if (item.type == ItemID.OasisCrateHard)
                {
                    itemLoot.Add(ItemDropRule.OneFromOptions(2,
                        ItemType<PottedSmallCactus>(),
                        ItemType<PottedOasisPlant>(),
                        ItemType<PottedTallCactus>()));
                }

                if (item.type == ItemID.CorruptFishingCrateHard)
                {
                    itemLoot.Add(ItemDropRule.OneFromOptions(2,
                        ItemType<PottedCedarCorruption>(),
                        ItemType<PottedTreeCorruption>(),
                        ItemType<PottedPalmCorruption>()));
                    itemLoot.Add(ItemDropRule.OneFromOptions(2,
                        ItemType<PottedSmallCactusCorruption>(),
                        ItemType<PottedOasisPlantCorruption>(),
                        ItemType<PottedTallCactusCorrupt>()));
                }

                if (item.type == ItemID.CrimsonFishingCrateHard)
                {
                    itemLoot.Add(ItemDropRule.OneFromOptions(2,
                        ItemType<PottedCedarCrimson>(),
                        ItemType<PottedTreeCrimson>(),
                        ItemType<PottedPalmCrimson>()));
                    itemLoot.Add(ItemDropRule.OneFromOptions(2,
                        ItemType<PottedSmallCactusCrimson>(),
                        ItemType<PottedOasisPlantCrimson>(),
                        ItemType<PottedTallCactusCrimson>()));
                }

                if (item.type == ItemID.HallowedFishingCrateHard)
                {
                    itemLoot.Add(ItemDropRule.OneFromOptions(2,
                        ItemType<PottedOasisPlantHallow>(),
                        ItemType<PottedSmallCactusHallow>(),
                        ItemType<PottedTallCactusHallow>()));
                }

                if (item.type == ItemID.FrozenCrateHard)
                {
                    itemLoot.Add(ItemDropRule.OneFromOptions(2,
                        ItemType<PottedXMasTree>(),
                        ItemType<PottedXMasTreeSnowy>()));
                    itemLoot.Add(ItemDropRule.OneFromOptions(2,
                        ItemType<PottedCedarSnowy>(),
                        ItemType<PottedTreeSnowy>()));
                }
            }
        }
    }
}