using Terraria;
using Terraria.GameContent.Bestiary;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace DragonsDecorativeMod.Global
{
    public class Shops : GlobalNPC
    {

        public override void SetupShop(int type, Chest shop, ref int nextSlot)
        {
            switch (type)
            {
                case NPCID.Dryad:
                    shop.item[nextSlot].SetDefaults(ItemType<Items.Botanic.BonsaiTree>());
                    nextSlot++;

                    shop.item[nextSlot].SetDefaults(ItemType<Items.Botanic.HangingPlant>());
                    nextSlot++;

                    shop.item[nextSlot].SetDefaults(ItemType<Items.Botanic.HangingLeafyPlant>());
                    nextSlot++;

                    shop.item[nextSlot].SetDefaults(ItemType<Items.Botanic.HangingFernPlant>());
                    nextSlot++;

                    shop.item[nextSlot].SetDefaults(ItemType<Items.Botanic.BleedingCrownMushroom>());
                    nextSlot++;

                    shop.item[nextSlot].SetDefaults(ItemType<Items.Botanic.BrownMushroom>());
                    nextSlot++;

                    shop.item[nextSlot].SetDefaults(ItemType<Items.Botanic.RedMushroom>());
                    nextSlot++;

                    shop.item[nextSlot].SetDefaults(ItemType<Items.Botanic.WhiteMushroom>());
                    nextSlot++;

                    break;
                case NPCID.BestiaryGirl:
                    BestiaryUnlockProgressReport bestiaryProgressReport = Main.GetBestiaryProgressReport();
                    if (bestiaryProgressReport.CompletionPercent >= 0.5f)
                    {
                        shop.item[nextSlot].SetDefaults(ModContent.ItemType<Items.MoonGlobe>());
                        nextSlot++;
                    }
                    break;
            }
        }
    }
}