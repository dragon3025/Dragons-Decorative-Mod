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
            if (item.type == ItemID.PlanteraBossBag)
                itemLoot.Add(ItemDropRule.Common(ItemType<Items.Natural.PeacefulPlanteraBulb>()));

            if (item.type == ItemID.LavaCrate || item.type == ItemID.LavaCrateHard)
                itemLoot.Add(ItemDropRule.OneFromOptions(2, ItemType<Items.Garden.HangingPlant>(), ItemType<Items.Garden.HangingFernPlant>(), ItemType<Items.Garden.HangingLeafyPlant>()));
        }
    }
}