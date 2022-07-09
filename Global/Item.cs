using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using DragonsDecor.Items;

namespace DragonsDecor.Global
{
    public class Item : GlobalItem
    {
        public override void OpenVanillaBag(string context, Terraria.Player player, int arg)
        {
            var source = player.GetSource_OpenItem(arg);

            if (arg == ItemID.PlanteraBossBag)
                player.QuickSpawnItem(source, ItemType<Items.Natural.PeacefulPlanteraBulb>());
        }
    }
}