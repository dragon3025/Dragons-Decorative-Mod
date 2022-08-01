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
        }
    }
}