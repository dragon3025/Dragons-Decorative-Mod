using Terraria;
using Terraria.GameContent.Bestiary;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using DragonsDecorativeMod.Items.Garden;

namespace DragonsDecorativeMod.Global
{
    public class Shops : GlobalNPC
    {

        public override void SetupShop(int type, Chest shop, ref int nextSlot)
        {
            switch (type)
            {
                case NPCID.Dryad:
                    shop.item[nextSlot].SetDefaults(ItemType<Plant>());
                    nextSlot++;

                    shop.item[nextSlot].SetDefaults(ItemType<Plant2>());
                    nextSlot++;

                    shop.item[nextSlot].SetDefaults(ItemType<Plant3>());
                    nextSlot++;

                    shop.item[nextSlot].SetDefaults(ItemType<Plant4>());
                    nextSlot++;

                    shop.item[nextSlot].SetDefaults(ItemType<BonsaiTree>());
                    nextSlot++;

                    shop.item[nextSlot].SetDefaults(ItemType<BleedingCrownMushroom>());
                    nextSlot++;

                    shop.item[nextSlot].SetDefaults(ItemType<BrownMushroom>());
                    nextSlot++;

                    shop.item[nextSlot].SetDefaults(ItemType<RedMushroom>());
                    nextSlot++;

                    shop.item[nextSlot].SetDefaults(ItemType<WhiteMushroom>());
                    nextSlot++;

                    break;
                case NPCID.BestiaryGirl:
                    BestiaryUnlockProgressReport bestiaryProgressReport = Main.GetBestiaryProgressReport();
                    if (bestiaryProgressReport.CompletionPercent >= 0.5f)
                    {
                        shop.item[nextSlot].SetDefaults(ItemType<Items.MoonGlobe>());
                        nextSlot++;
                    }
                    break;
            }
        }
    }
}