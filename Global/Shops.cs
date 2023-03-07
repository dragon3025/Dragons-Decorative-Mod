using DragonsDecorativeMod.Items;
using DragonsDecorativeMod.Items.Garden;
using DragonsDecorativeMod.Tiles;
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
                case NPCID.Merchant:
                    if (GetInstance<BFurnitureConfig>().Globe)
                    {
                        shop.item[nextSlot].SetDefaults(ItemType<Items.Globe>());
                        nextSlot++;
                    }
                    break;
                case NPCID.Dryad:
                    if (GetInstance<BFurnitureConfig>().Clover)
                    {
                        Player player = Main.LocalPlayer;
                        if (player.luckPotion > 0)
                        {
                            shop.item[nextSlot].SetDefaults(ItemType<Clover>());
                            nextSlot++;
                        }
                    }

                    if (GetInstance<BFurnitureConfig>().Plants)
                    {
                        shop.item[nextSlot].SetDefaults(ItemType<Plant>());
                        nextSlot++;

                        shop.item[nextSlot].SetDefaults(ItemType<Plant2>());
                        nextSlot++;

                        shop.item[nextSlot].SetDefaults(ItemType<Plant3>());
                        nextSlot++;

                        shop.item[nextSlot].SetDefaults(ItemType<Plant4>());
                        nextSlot++;

                        shop.item[nextSlot].SetDefaults(ItemType<FloweryPlant>());
                        nextSlot++;
                    }

                    if (GetInstance<BFurnitureConfig>().BonsaiTree)
                    {
                        shop.item[nextSlot].SetDefaults(ItemType<BonsaiTree>());
                        nextSlot++;
                    }

                    if (GetInstance<BFurnitureConfig>().Mushrooms)
                    {
                        shop.item[nextSlot].SetDefaults(ItemType<BleedingCrownMushroom>());
                        nextSlot++;

                        shop.item[nextSlot].SetDefaults(ItemType<BrownMushroom>());
                        nextSlot++;

                        shop.item[nextSlot].SetDefaults(ItemType<RedMushroom>());
                        nextSlot++;

                        shop.item[nextSlot].SetDefaults(ItemType<WhiteMushroom>());
                        nextSlot++;
                    }

                    break;
                case NPCID.SantaClaus:
                    if (GetInstance<BFurnitureConfig>().ChristmasLights)
                    {
                        shop.item[nextSlot].SetDefaults(ItemType<Items.Christmas.LightCyan>());
                        nextSlot++;
                        shop.item[nextSlot].SetDefaults(ItemType<Items.Christmas.LightOrange>());
                        nextSlot++;
                        shop.item[nextSlot].SetDefaults(ItemType<Items.Christmas.LightPink>());
                        nextSlot++;
                        shop.item[nextSlot].SetDefaults(ItemType<Items.Christmas.LightPurple>());
                        nextSlot++;
                        shop.item[nextSlot].SetDefaults(ItemType<Items.Christmas.LightWhite>());
                        nextSlot++;
                        shop.item[nextSlot].SetDefaults(ItemType<Items.Christmas.LightYellow>());
                        nextSlot++;
                    }

                    if (GetInstance<BFurnitureConfig>().CandyCane)
                    {
                        shop.item[nextSlot].SetDefaults(ItemType<Items.Christmas.CandyCane>());
                        nextSlot++;
                    }

                    if (GetInstance<BFurnitureConfig>().Snowman)
                    {
                        shop.item[nextSlot].SetDefaults(ItemType<Items.Christmas.SnowmanLeft>());
                        nextSlot++;
                        shop.item[nextSlot].SetDefaults(ItemType<Items.Christmas.SnowmanRight>());
                        nextSlot++;
                    }

                    break;
                case NPCID.Painter:
                    if (GetInstance<BFurnitureConfig>().PaintingLuringToGold)
                    {
                        Player player = Main.LocalPlayer;
                        if (player.luckPotion > 0)
                        {
                            shop.item[nextSlot].SetDefaults(ItemType<Items.LuringToGold>());
                            nextSlot++;
                        }
                    }
                    if (GetInstance<BFurnitureConfig>().PaintBottle)
                    {
                        shop.item[nextSlot].SetDefaults(ItemType<Items.PaintBottleSingle>());
                        nextSlot++;
                    }
                    break;
                case NPCID.PartyGirl:
                    if (GetInstance<BFurnitureConfig>().CloverDecal)
                    {
                        Player player = Main.LocalPlayer;
                        if (player.luckPotion > 0)
                        {
                            shop.item[nextSlot].SetDefaults(ItemType<Items.CloverDecal>());
                            nextSlot++;
                        }
                    }
                    break;
                case NPCID.BestiaryGirl:
                    BestiaryUnlockProgressReport bestiaryProgressReport = Main.GetBestiaryProgressReport();
                    if (bestiaryProgressReport.CompletionPercent >= 0.5f)
                    {
                        shop.item[nextSlot].SetDefaults(ItemType<MoonGlobe>());
                        nextSlot++;
                    }
                    break;
                case NPCID.Truffle:
                    if (GetInstance<BFurnitureConfig>().PottedPlants)
                    {
                        shop.item[nextSlot].SetDefaults(ItemType<Items.Garden.PottedPlants.PottedMushroomTreeShort>());
                        nextSlot++;

                        shop.item[nextSlot].SetDefaults(ItemType<Items.Garden.PottedPlants.PottedMushroomTreeTall>());
                        nextSlot++;
                    }

                    break;
                case NPCID.Stylist:
                    shop.item[nextSlot].SetDefaults(ItemType<Items.Shampoo>());
                    nextSlot++;
                    break;
            }
        }
    }
}