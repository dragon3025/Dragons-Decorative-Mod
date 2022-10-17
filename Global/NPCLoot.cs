using Terraria;
using Terraria.GameContent.ItemDropRules;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace DragonsDecorativeMod.Global
{
    public class NPCLoot : GlobalNPC
    {
        public override void ModifyNPCLoot(NPC npc, Terraria.ModLoader.NPCLoot npcLoot)
        {
            if (GetInstance<BFurnitureConfig>().StaringStatue)
                return;
            {
                if (npc.type == NPCID.Ghost)
                    npcLoot.Add(ItemDropRule.Common(ItemType<Items.StaringStatue>(), 50));
            }

            if (GetInstance<BFurnitureConfig>().MedusaWatching)
            {
                if (npc.type == NPCID.Medusa)
                    npcLoot.Add(ItemDropRule.Common(ItemType<Items.MedusaWatching>(), 25));
            }
        }
    }
}
