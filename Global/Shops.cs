using DragonsDecorativeMod.Items.Garden;
using DragonsDecorativeMod.Items.StPatricksDay;
using Terraria;
using Terraria.GameContent.Bestiary;
using Terraria.ID;
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
                    if (GetInstance<BFurnitureConfig>().Globe)
                    {
                        shop.Add(ItemType<Items.Globe>());
                    }
                    break;
                case NPCID.Dryad:
                    if (GetInstance<BFurnitureConfig>().Clover)
                    {
                        shop.Add(ItemType<Clover>());
                        shop.Add(ItemType<FourLeafClover>());
                    }

                    if (GetInstance<BFurnitureConfig>().Plants)
                    {
                        shop.Add(ItemType<Plant>());
                        shop.Add(ItemType<Plant2>());
                        shop.Add(ItemType<Plant3>());
                        shop.Add(ItemType<Plant4>());
                        shop.Add(ItemType<FloweryPlant>());
                    }

                    if (GetInstance<BFurnitureConfig>().BonsaiTree)
                    {
                        shop.Add(ItemType<BonsaiTree>());
                    }

                    if (GetInstance<BFurnitureConfig>().Mushrooms)
                    {
                        shop.Add(ItemType<BleedingCrownMushroom>());
                        shop.Add(ItemType<BrownMushroom>());
                        shop.Add(ItemType<RedMushroom>());
                        shop.Add(ItemType<WhiteMushroom>());
                    }

                    break;
                case NPCID.SantaClaus:
                    if (GetInstance<BFurnitureConfig>().LightPaintable)
                    {
                        shop.Add(ItemType<Items.Christmas.LightPaintable>());
                    }

                    if (GetInstance<BFurnitureConfig>().CandyCane)
                    {
                        shop.Add(ItemType<Items.Christmas.CandyCane>());
                    }

                    if (GetInstance<BFurnitureConfig>().Snowman)
                    {
                        shop.Add(ItemType<Items.Christmas.SnowmanLeft>());
                        shop.Add(ItemType<Items.Christmas.SnowmanRight>());
                    }
                    break;
                case NPCID.Painter:
                    if (GetInstance<BFurnitureConfig>().PaintBottle)
                    {
                        shop.Add(ItemType<Items.PaintBottleSingle>());
                    }
                    break;
                case NPCID.PartyGirl:
                    if (GetInstance<BFurnitureConfig>().LightPaintable && Main.halloween)
                    {
                        shop.Add(ItemType<Items.Christmas.LightPaintable>());
                    }
                    break;
                case NPCID.Truffle:
                    if (GetInstance<BFurnitureConfig>().PottedPlants)
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