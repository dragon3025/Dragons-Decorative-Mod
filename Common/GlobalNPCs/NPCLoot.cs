using DragonsDecorativeMod.Configuration;
using DragonsDecorativeMod.Content.Items.Placeable.Other;
using System.Linq;
using Terraria;
using Terraria.GameContent.ItemDropRules;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace DragonsDecorativeMod.Common.GlobalNPCs
{
    public class NPCLoot : GlobalNPC
    {
        private static readonly Other other = GetInstance<Other>();

        public override void ModifyNPCLoot(NPC npc, Terraria.ModLoader.NPCLoot npcLoot)
        {
            switch (npc.type)
            {
                case NPCID.Ghost:
                    if (other.StaringStatue)
                    {
                        npcLoot.Add(ItemDropRule.Common(ItemType<StaringStatue>(), 50));
                    }
                    return;
                case NPCID.Medusa:
                    if (other.MedusaWatching)
                    {
                        npcLoot.Add(ItemDropRule.Common(ItemType<MedusaWatching>(), 25));
                    }
                    return;
                case NPCID.DesertDjinn:
                    if (other.PureSpiritLamp)
                    {
                        npcLoot.Add(ItemDropRule.Common(ItemType<PureSpiritLamp>(), 40));
                    }
                    return;
            }

            if (other.SlimeTrophy)
            {
                int[] Slimes =
                [
                    59, 537, -4, 1, 16, 138, 141, 147, 184, 187, 433, 204, 302, 333, 334, 335, 336, 535, 658, 659, 660,
                    -6, -7, -8, -9, NPCID.KingSlime
                ];

                if (Slimes.Contains(npc.type))
                {
                    ItemDropWithConditionRule ruleForNormalMode = new(ItemType<SlimeTrophy>(), 10000, 1, 1, new DontShowInBestiary());
                    ItemDropWithConditionRule ruleForExpertMode = new(ItemType<SlimeTrophy>(), 7000, 1, 1, new DontShowInBestiary());
                    npcLoot.Add(new DropBasedOnExpertMode(ruleForNormalMode, ruleForExpertMode));
                    return;
                }
            }
        }
    }

    public class DontShowInBestiary : IItemDropRuleCondition, IProvideItemConditionDescription
    {
        public bool CanDrop(DropAttemptInfo info) => true;
        public bool CanShowItemDropInUI() => false;
        public string GetConditionDescription() => "";
    }
}
