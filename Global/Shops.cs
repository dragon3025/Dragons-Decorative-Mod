using DragonsDecorativeMod.Configuration;
using DragonsDecorativeMod.Items.Garden;
using DragonsDecorativeMod.Items.Garden.Mushrooms;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace DragonsDecorativeMod.Global
{
    public class Shops : GlobalNPC
    {

        public override void ModifyShop(NPCShop shop)
        {
            switch (shop.NpcType)
            {
                case NPCID.Merchant:
                    if (GetInstance<DragonsDecoModConfig>().Other.Globe)
                    {
                        shop.Add(ItemType<Items.Globe>());
                    }
                    break;
                case NPCID.Dryad:
                    if (GetInstance<DragonsDecoModConfig>().Garden.Clover)
                    {
                        shop.Add(ItemType<Clover>());
                        shop.Add(ItemType<FourLeafClover>());
                    }

                    if (GetInstance<DragonsDecoModConfig>().Garden.Plants)
                    {
                        shop.Add(ItemType<Plant>());
                        shop.Add(ItemType<Plant2>());
                        shop.Add(ItemType<Plant3>());
                        shop.Add(ItemType<Plant4>());
                        shop.Add(ItemType<FloweryPlant>());
                    }

                    if (GetInstance<DragonsDecoModConfig>().Garden.BonsaiTree)
                    {
                        shop.Add(ItemType<BonsaiTree>());
                    }

                    if (GetInstance<DragonsDecoModConfig>().Garden.Mushrooms)
                    {
                        shop.Add(ItemType<BleedingCrownMushroom>());
                        shop.Add(ItemType<BrownMushroom>());
                        shop.Add(ItemType<RedMushroom>());
                        shop.Add(ItemType<WhiteMushroom>());
                    }

                    break;
                case NPCID.SantaClaus:
                    if (GetInstance<DragonsDecoModConfig>().Christmas.CandyCane)
                    {
                        shop.Add(ItemType<Items.Christmas.CandyCane>());
                    }
                    if (GetInstance<DragonsDecoModConfig>().Christmas.GingerbreadHouse)
                    {
                        shop.Add(ItemType<Items.Christmas.GingerbreadHouse>());
                    }
                    if (GetInstance<DragonsDecoModConfig>().Christmas.LightPaintable)
                    {
                        shop.Add(ItemType<Items.Christmas.LightPaintable>());
                    }
                    if (GetInstance<DragonsDecoModConfig>().Christmas.Mistletoe)
                    {
                        shop.Add(ItemType<Items.Christmas.Mistletoe>());
                    }
                    break;
                case NPCID.Painter:
                    if (GetInstance<DragonsDecoModConfig>().Other.PaintBottle && shop.Name == Language.GetTextValue("GameUI.PainterDecor"))
                    {
                        shop.Add(ItemType<Items.PaintBottleSingle>());
                    }
                    break;
                case NPCID.PartyGirl:
                    if (GetInstance<DragonsDecoModConfig>().Christmas.LightPaintable)
                    {
                        shop.Add(ItemType<Items.Christmas.LightPaintable>());
                    }
                    break;
                case NPCID.Truffle:
                    if (GetInstance<DragonsDecoModConfig>().Garden.PottedPlants)
                    {
                        shop.Add(ItemType<Items.Garden.PottedPlants.PottedMushroomTreeShort>());

                        shop.Add(ItemType<Items.Garden.PottedPlants.PottedMushroomTreeTall>());
                    }

                    break;
                case NPCID.Stylist:
                    shop.Add(ItemType<Items.Shampoo>());
                    break;
            }
        }
    }
}