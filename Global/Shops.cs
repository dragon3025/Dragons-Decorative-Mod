using Terraria;
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

                    shop.item[nextSlot].SetDefaults(ItemType<Items.Botanic.HangingAlsobia>());
                    nextSlot++;

                    shop.item[nextSlot].SetDefaults(ItemType<Items.Botanic.HangingFloweredAlsobia>());
                    nextSlot++;

                    shop.item[nextSlot].SetDefaults(ItemType<Items.Botanic.HangingPhilodendron>());
                    nextSlot++;

                    shop.item[nextSlot].SetDefaults(ItemType<Items.Botanic.HangingBirdsNestFern>());
                    nextSlot++;

                    break;
            }
        }
    }
}