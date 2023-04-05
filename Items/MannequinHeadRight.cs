using Terraria;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace DragonsDecorativeMod.Items
{
    public class MannequinHeadRight : ModItem
    {
        public override void SetStaticDefaults()
        {
            // DisplayName.SetDefault("Right Mannequin Head");
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

        public override void SetDefaults()
        {
            Item.width = 20;
            Item.height = 26;
            Item.maxStack = 9999;
            Item.useTurn = true;
            Item.autoReuse = true;
            Item.rare = ItemRarityID.White;
            Item.useAnimation = 15;
            Item.useTime = 15;
            Item.useStyle = ItemUseStyleID.HoldUp;
            Item.consumable = true;
            Item.createTile = ModContent.TileType<Tiles.MannequinHeadRight>();
        }

        public override void AddRecipes()
        {
            if (!GetInstance<BFurnitureConfig>().MannequinHead)
            {
                return;
            }

            CreateRecipe()
              .AddIngredient(ItemID.Wood, 5)
              .AddTile(TileID.Sawmill)
              .Register();

            Recipe recipe = Recipe.Create(ModContent.ItemType<MannequinHeadLeft>());
            recipe.AddIngredient(this);
            recipe.Register();
        }
    }
}