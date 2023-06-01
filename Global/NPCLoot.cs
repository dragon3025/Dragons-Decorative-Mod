using Terraria;
using Terraria.GameContent.ItemDropRules;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace DragonsDecorativeMod.Global
{
    public class NPCLoot : GlobalNPC
    {
        readonly static BFurnitureConfig furnitureConfig = GetInstance<BFurnitureConfig>();

        public override void ModifyNPCLoot(NPC npc, Terraria.ModLoader.NPCLoot npcLoot)
        {
            if (npc.type == NPCID.Ghost && furnitureConfig.StaringStatue)
            {
                npcLoot.Add(ItemDropRule.Common(ItemType<Items.StaringStatue>(), 50));
            }

            if (npc.type == NPCID.Medusa && furnitureConfig.MedusaWatching)
            {
                npcLoot.Add(ItemDropRule.Common(ItemType<Items.MedusaWatching>(), 25));
            }
        }
    }
}
