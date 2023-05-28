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

            if (npc.type == NPCID.MoonLordCore && furnitureConfig.MysteriousTablet)
            {
                LeadingConditionRule ruleNotExpert = new LeadingConditionRule(new Conditions.NotExpert());
                ruleNotExpert.OnSuccess(ItemDropRule.Common(ItemType<Items.Natural.MysteriousTablet>(), 5));
                npcLoot.Add(ruleNotExpert);
            }
        }
    }
}
