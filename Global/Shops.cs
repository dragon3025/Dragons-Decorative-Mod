using DragonsDecorativeMod.Items;
using DragonsDecorativeMod.Items.Garden;
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
                        Player player = Main.LocalPlayer;
                        if (player.luckPotion > 0)
                        {
                            shop.Add(ItemType<Clover>());
                        }
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
                    if (GetInstance<BFurnitureConfig>().ChristmasLights)
                    {
                        shop.Add(ItemType<Items.Christmas.LightCyan>());
                        shop.Add(ItemType<Items.Christmas.LightOrange>());
                        shop.Add(ItemType<Items.Christmas.LightPink>());
                        shop.Add(ItemType<Items.Christmas.LightPurple>());
                        shop.Add(ItemType<Items.Christmas.LightWhite>());
                        shop.Add(ItemType<Items.Christmas.LightYellow>());
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
                    if (GetInstance<BFurnitureConfig>().PaintingLuringToGold)
                    {
                        Player player = Main.LocalPlayer;
                        if (player.luckPotion > 0)
                        {
                            shop.Add(ItemType<Items.LuringToGold>());
                        }
                    }
                    if (GetInstance<BFurnitureConfig>().PaintBottle)
                    {
                        shop.Add(ItemType<Items.PaintBottleSingle>());
                    }
                    break;
                case NPCID.PartyGirl:
                    if (GetInstance<BFurnitureConfig>().CloverDecal)
                    {
                        Player player = Main.LocalPlayer;
                        if (player.luckPotion > 0)
                        {
                            shop.Add(ItemType<Items.CloverDecal>());
                        }
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