using DragonsDecorativeMod.Configuration;
using DragonsDecorativeMod.Content.Items;
using DragonsDecorativeMod.Content.Items.Placeable.Christmas;
using DragonsDecorativeMod.Content.Items.Placeable.Garden;
using DragonsDecorativeMod.Content.Items.Placeable.Garden.Mushrooms;
using DragonsDecorativeMod.Content.Items.Placeable.Garden.PottedPlants;
using DragonsDecorativeMod.Content.Items.Placeable.Other;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace DragonsDecorativeMod.Common.GlobalNPCs
{
    public class Shops : GlobalNPC
    {
        public override void ModifyShop(NPCShop shop)
        {
            Other other = GetInstance<Other>();
            Garden garden = GetInstance<Garden>();
            Christmas christmas = GetInstance<Christmas>();
            switch (shop.NpcType)
            {
                case NPCID.Merchant:
                    if (other.Globe)
                    {
                        shop.Add(ItemType<Globe>());
                    }
                    break;
                case NPCID.Dryad:
                    if (garden.Clover)
                    {
                        shop.Add(ItemType<Clover>());
                        shop.Add(ItemType<FourLeafClover>());
                    }

                    if (garden.Plants)
                    {
                        shop.Add(ItemType<Plant>());
                        shop.Add(ItemType<Plant2>());
                        shop.Add(ItemType<Plant3>());
                        shop.Add(ItemType<Plant4>());
                        shop.Add(ItemType<FloweryPlant>());
                    }

                    if (garden.BonsaiTree)
                    {
                        shop.Add(ItemType<BonsaiTree>());
                    }

                    if (garden.Mushrooms)
                    {
                        shop.Add(ItemType<BleedingCrownMushroom>());
                        shop.Add(ItemType<BrownMushroom>());
                        shop.Add(ItemType<RedMushroom>());
                        shop.Add(ItemType<WhiteMushroom>());
                    }

                    if (garden.NatureGlobe)
                    {
                        shop.Add(ItemType<NatureGlobe>());
                    }

                    break;
                case NPCID.SantaClaus:
                    if (christmas.CandyCane)
                    {
                        shop.Add(ItemType<CandyCane>());
                    }
                    if (christmas.GingerbreadHouse)
                    {
                        shop.Add(ItemType<GingerbreadHouse>());
                    }
                    if (christmas.LightPaintable)
                    {
                        shop.Add(ItemType<LightPaintable>());
                    }
                    if (christmas.Mistletoe)
                    {
                        shop.Add(ItemType<Mistletoe>());
                    }
                    break;
                case NPCID.Painter:
                    if (other.PaintBottle && shop.Name == Language.GetTextValue("GameUI.PainterDecor"))
                    {
                        shop.Add(ItemType<PaintBottleSingle>());
                    }
                    break;
                case NPCID.PartyGirl:
                    if (christmas.LightPaintable)
                    {
                        shop.Add(ItemType<LightPaintable>());
                    }
                    break;
                case NPCID.Truffle:
                    if (garden.PottedPlants)
                    {
                        shop.Add(ItemType<PottedMushroomTreeShort>());

                        shop.Add(ItemType<PottedMushroomTreeTall>());
                    }
                    break;
                case NPCID.Stylist:
                    if (other.Shampoo)
                    {
                        shop.Add(ItemType<Shampoo>());
                    }
                    break;
                case NPCID.BestiaryGirl:
                    if (other.BestiaryTrophy)
                    {
                        shop.Add(ItemType<BestiaryTrophy>(), Condition.BestiaryFilledPercent(100));
                    }
                    break;
                case NPCID.Mechanic:
                    if (GetInstance<GeneralConfig>().Inclinometer)
                    {
                        shop.Add(ItemType<Inclinometer>());
                    }
                    break;
                case NPCID.Pirate:
                    if (GetInstance<Pets>().Aquarium)
                    {
                        shop.Add(ItemType<Content.Items.Placeable.Pets.Aquarium>());
                    }
                    break;
            }
        }
    }
}