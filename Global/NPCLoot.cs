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
			if (npc.type == NPCID.Plantera)
            {
				npcLoot.Add(new DropBasedOnExpertMode(ItemDropRule.Common(ItemType<Items.Natural.PeacefulPlanteraBulb>()), ItemDropRule.DropNothing()));
			}
			
			if (npc.type == NPCID.Ghost)
				npcLoot.Add(ItemDropRule.Common(ItemType<Items.StaringStatue>(), 50));

			if (npc.type == NPCID.Medusa)
				npcLoot.Add(ItemDropRule.Common(ItemType<Items.MedusaWatching>(), 25));

			if (npc.type == NPCID.BloodZombie || npc.type == NPCID.Drippler)
				npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<Items.BloodClump>(), 25));
		}
    }
}
