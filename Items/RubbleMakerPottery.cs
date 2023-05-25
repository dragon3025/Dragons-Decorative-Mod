using Terraria;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

// TO-DO: If tModLoader releases support for adding to vanilla Rubble Maker, convert these into Rubble Maker placements (AS OF NOW, VANILLA "ECHO POTS" DON'T DROP ANYTHING, AND IT'S IMPOSSIBLE TO ADD DROPS TO VANILLA TILES).

namespace DragonsDecorativeMod.Items
{
    public class RubbleMakerPottery : ModItem
    {
        readonly static BFurnitureConfig furnitureConfig = GetInstance<BFurnitureConfig>();

        public override void SetStaticDefaults()
        {
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

        public override void SetDefaults()
        {
            Item.width = 42;
            Item.height = 42;
            Item.maxStack = 1;
            Item.useTurn = true;
            Item.autoReuse = true;
            Item.rare = ItemRarityID.Red;
            Item.useAnimation = 15;
            Item.useTime = 15;
            Item.useStyle = ItemUseStyleID.HoldUp;
            Item.value = Item.buyPrice(0, 25);
        }

        public override void UpdateInventory(Player player)
        {
            bool hasValidBlock = false;

            void correctTile(int minStyle, int maxStyle)
            {
                hasValidBlock = true;
                if (Item.createTile != TileType<Tiles.Natural.FakePot>() || Item.placeStyle < minStyle || Item.placeStyle > maxStyle)
                {
                    Item.createTile = TileType<Tiles.Natural.FakePot>();
                    Item.placeStyle = minStyle;
                }
            }

            if (player.HeldItem.type == Type)
            {
                int minStyle = 0;
                int maxStyle = 0;
                for (int i = 0; i < player.inventory.Length; i++)
                {
                    if (player.inventory[i].type == ItemID.ClayBlock)
                    {
                        maxStyle = 11;
                        correctTile(minStyle, maxStyle);
                        break;
                    }
                    if (player.inventory[i].type == ItemID.IceBlock)
                    {
                        minStyle = 12;
                        maxStyle = 20;
                        correctTile(minStyle, maxStyle);
                        break;
                    }
                    if (player.inventory[i].type == ItemID.MudBlock)
                    {
                        minStyle = 21;
                        maxStyle = 29;
                        correctTile(minStyle, maxStyle);
                        break;
                    }
                    if (player.inventory[i].type == ItemID.Bone)
                    {
                        minStyle = 30;
                        maxStyle = 38;
                        correctTile(minStyle, maxStyle);
                        break;
                    }
                    if (player.inventory[i].type == ItemID.Obsidian)
                    {
                        minStyle = 39;
                        maxStyle = 47;
                        correctTile(minStyle, maxStyle);
                        break;
                    }
                    if (player.inventory[i].type == ItemID.EbonstoneBlock)
                    {
                        minStyle = 48;
                        maxStyle = 56;
                        correctTile(minStyle, maxStyle);
                        break;
                    }
                    if (player.inventory[i].type == ItemID.Cobweb)
                    {
                        minStyle = 57;
                        maxStyle = 65;
                        correctTile(minStyle, maxStyle);
                        break;
                    }
                    if (player.inventory[i].type == ItemID.CrimstoneBlock)
                    {
                        minStyle = 66;
                        maxStyle = 68;
                        correctTile(minStyle, maxStyle);
                        break;
                    }
                    if (player.inventory[i].type == ItemID.Sandstone)
                    {
                        minStyle = 69;
                        maxStyle = 80;
                        correctTile(minStyle, maxStyle);
                        break;
                    }
                    if (player.inventory[i].type == ItemID.LihzahrdBrick)
                    {
                        minStyle = 81;
                        maxStyle = 86;
                        correctTile(minStyle, maxStyle);
                        break;
                    }
                    if (player.inventory[i].type == ItemID.Marble)
                    {
                        minStyle = 87;
                        maxStyle = 89;
                        correctTile(minStyle, maxStyle);
                        break;
                    }
                    if (player.inventory[i].type == ItemID.Granite)
                    {
                        minStyle = 90;
                        maxStyle = 92;
                        correctTile(minStyle, maxStyle);
                        break;
                    }
                }
                if (!hasValidBlock)
                {
                    Item.createTile = -1;
                    Item.placeStyle = 0;
                }
                else
                {
                    if (player.controlDown && player.releaseDown)
                    {
                        GetInstance<DragonsDecorativeMod>().Logger.Debug("Pressed Down");
                        Item.placeStyle--;
                        if (Item.placeStyle < minStyle)
                        {
                            Item.placeStyle = maxStyle;
                        }
                    }
                    if (player.controlUp && player.releaseUp)
                    {
                        GetInstance<DragonsDecorativeMod>().Logger.Debug("Pressed Up");
                        Item.placeStyle++;
                        if (Item.placeStyle > maxStyle)
                        {
                            Item.placeStyle = minStyle;
                        }
                    }
                }
            }
        }

        public override bool? UseItem(Player player)
        {
            bool consumedItem = false;
            for (int i = 0; i < player.inventory.Length; i++)
            {
                if (player.inventory[i].type == ItemID.ClayBlock)
                {
                    player.ConsumeItem(ItemID.ClayBlock);
                    consumedItem = true;
                    break;
                }
                if (player.inventory[i].type == ItemID.IceBlock)
                {
                    player.ConsumeItem(ItemID.IceBlock);
                    consumedItem = true;
                    break;
                }
                if (player.inventory[i].type == ItemID.MudBlock)
                {
                    player.ConsumeItem(ItemID.MudBlock);
                    consumedItem = true;
                    break;
                }
                if (player.inventory[i].type == ItemID.Bone)
                {
                    player.ConsumeItem(ItemID.Bone);
                    consumedItem = true;
                    break;
                }
                if (player.inventory[i].type == ItemID.Obsidian)
                {
                    player.ConsumeItem(ItemID.Obsidian);
                    consumedItem = true;
                    break;
                }
                if (player.inventory[i].type == ItemID.EbonstoneBlock)
                {
                    player.ConsumeItem(ItemID.EbonstoneBlock);
                    consumedItem = true;
                    break;
                }
                if (player.inventory[i].type == ItemID.Cobweb)
                {
                    player.ConsumeItem(ItemID.Cobweb);
                    consumedItem = true;
                    break;
                }
                if (player.inventory[i].type == ItemID.CrimstoneBlock)
                {
                    player.ConsumeItem(ItemID.CrimstoneBlock);
                    consumedItem = true;
                    break;
                }
                if (player.inventory[i].type == ItemID.Sandstone)
                {
                    player.ConsumeItem(ItemID.Sandstone);
                    consumedItem = true;
                    break;
                }
                if (player.inventory[i].type == ItemID.LihzahrdBrick)
                {
                    player.ConsumeItem(ItemID.LihzahrdBrick);
                    consumedItem = true;
                    break;
                }
                if (player.inventory[i].type == ItemID.Marble)
                {
                    player.ConsumeItem(ItemID.Marble);
                    consumedItem = true;
                    break;
                }
                if (player.inventory[i].type == ItemID.Granite)
                {
                    player.ConsumeItem(ItemID.Granite);
                    consumedItem = true;
                    break;
                }
            }
            return consumedItem;
        }

        public override void AddRecipes()
        {
            if (!furnitureConfig.Pots)
            {
                return;
            }

            Recipe recipe = Recipe.Create(Type);
            recipe.AddIngredient(ItemID.RubblemakerLarge);
            recipe.Register();

            recipe = Recipe.Create(Type);
            recipe.AddIngredient(ItemID.RubblemakerMedium);
            recipe.Register();

            recipe = Recipe.Create(Type);
            recipe.AddIngredient(ItemID.RubblemakerSmall);
            recipe.Register();

            recipe = Recipe.Create(ItemID.RubblemakerSmall);
            recipe.AddIngredient(Type);
            recipe.Register();
        }
    }
}