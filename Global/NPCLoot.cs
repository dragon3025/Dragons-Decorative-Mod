using Terraria;
using Terraria.GameContent.ItemDropRules;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace DragonsDecor.Global
{
    public class NPCLoot : GlobalNPC
    {
        public override void ModifyNPCLoot(NPC npc, Terraria.ModLoader.NPCLoot npcLoot)
		{
			if (npc.type == NPCID.Ghost)
				npcLoot.Add(ItemDropRule.Common(ItemType<Items.StaringStatue>(), 100));

			if (npc.type == NPCID.Medusa)
				npcLoot.Add(ItemDropRule.Common(ItemType<Items.MedusaWatching>(), 100));

			if (npc.type == NPCID.SandSlime)
				npcLoot.Add(ItemDropRule.NormalvsExpert(ItemType<Items.SlimeTrophy>(), 8000, 5600));

			if (npc.type == NPCID.Pinky)
				npcLoot.Add(ItemDropRule.NormalvsExpert(ItemType<Items.SlimeTrophy>(), 100, 70));

			int[] NPCsWithLowSlimeStaffDrop = new int[22]
			{
				1,
				16,
				138,
				141,
				147,
				184,
				187,
				433,
				204,
				302,
				333,
				334,
				335,
				336,
				535,
				658,
				659,
				660,
				-6,
				-7,
				-8,
				-9
			};

			foreach (int i in NPCsWithLowSlimeStaffDrop)
            {
				if (npc.type == i)
					npcLoot.Add(ItemDropRule.NormalvsExpert(ItemType<Items.SlimeTrophy>(), 10000, 7000));
			}

			if (npc.type == NPCID.Plantera)
            {
				npcLoot.Add(new DropBasedOnExpertMode(ItemDropRule.Common(ItemType<Items.Natural.PeacefulPlanteraBulb>()), ItemDropRule.DropNothing()));
			}
		}
    }
}
