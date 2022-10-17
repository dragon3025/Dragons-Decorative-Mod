using Terraria.GameContent.ItemDropRules;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace DragonsDecorativeMod.Global
{
    public class Item : GlobalItem
    {

        public override void ModifyItemLoot(Terraria.Item item, ItemLoot itemLoot)
        {
            if (GetInstance<BFurnitureConfig>().HangingPlants)
            {
                if (item.type == ItemID.LavaCrate || item.type == ItemID.LavaCrateHard)
                    itemLoot.Add(ItemDropRule.OneFromOptions(4,
                        ItemType<Items.Garden.HangingPlant>(),
                        ItemType<Items.Garden.HangingFernPlant>(),
                        ItemType<Items.Garden.HangingLeafyPlant>()));
            }

            if (GetInstance<BFurnitureConfig>().PottedPlants)
            {
                if (item.type == ItemID.OasisCrateHard)
                    itemLoot.Add(ItemDropRule.OneFromOptions(2,
                        ItemType<Items.Garden.PottedPlants.PottedSmallCactus>(),
                        ItemType<Items.Garden.PottedPlants.PottedOasisPlant>(),
                        ItemType<Items.Garden.PottedPlants.PottedTallCactus>()));

                if (item.type == ItemID.CorruptFishingCrateHard)
                {
                    itemLoot.Add(ItemDropRule.OneFromOptions(2,
                        ItemType<Items.Garden.PottedPlants.PottedCedarCorruption>(),
                        ItemType<Items.Garden.PottedPlants.PottedTreeCorruption>(),
                        ItemType<Items.Garden.PottedPlants.PottedPalmCorruption>()));
                    itemLoot.Add(ItemDropRule.OneFromOptions(2,
                        ItemType<Items.Garden.PottedPlants.PottedSmallCactusCorruption>(),
                        ItemType<Items.Garden.PottedPlants.PottedOasisPlantCorruption>(),
                        ItemType<Items.Garden.PottedPlants.PottedTallCactusCorrupt>()));
                }

                if (item.type == ItemID.CrimsonFishingCrateHard)
                {
                    itemLoot.Add(ItemDropRule.OneFromOptions(2,
                        ItemType<Items.Garden.PottedPlants.PottedCedarCrimson>(),
                        ItemType<Items.Garden.PottedPlants.PottedTreeCrimson>(),
                        ItemType<Items.Garden.PottedPlants.PottedPalmCrimson>()));
                    itemLoot.Add(ItemDropRule.OneFromOptions(2,
                        ItemType<Items.Garden.PottedPlants.PottedSmallCactusCrimson>(),
                        ItemType<Items.Garden.PottedPlants.PottedOasisPlantCrimson>(),
                        ItemType<Items.Garden.PottedPlants.PottedTallCactusCrimson>()));
                }

                if (item.type == ItemID.HallowedFishingCrateHard)
                    itemLoot.Add(ItemDropRule.OneFromOptions(2,
                        ItemType<Items.Garden.PottedPlants.PottedOasisPlantHallow>(),
                        ItemType<Items.Garden.PottedPlants.PottedSmallCactusHallow>(),
                        ItemType<Items.Garden.PottedPlants.PottedTallCactusHallow>()));

                if (item.type == ItemID.FrozenCrateHard)
                {
                    itemLoot.Add(ItemDropRule.OneFromOptions(2,
                        ItemType<Items.Garden.PottedPlants.PottedXMasTree>(),
                        ItemType<Items.Garden.PottedPlants.PottedXMasTreeSnowy>()));
                    itemLoot.Add(ItemDropRule.OneFromOptions(2,
                        ItemType<Items.Garden.PottedPlants.PottedCedarSnowy>(),
                        ItemType<Items.Garden.PottedPlants.PottedTreeSnowy>()));
                }
            }
        }
    }
}