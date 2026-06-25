using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace DragonsDecorativeMod.Content.Items.Placeable.Other
{
    public class GolfCart : ModItem
    {
        public override void SetDefaults()
        {
            Item.CloneDefaults(ItemID.Wood);
            Item.width = 30;
            Item.height = 24;
            Item.rare = ItemRarityID.Yellow;
            Item.value = Item.sellPrice(0, 10);
            Item.createTile = TileType<Tiles.Other.GolfCart>();
        }

        public override void AddRecipes()
        {
            if (!GetInstance<Configuration.Other>().GolfCart)
            {
                return;
            }

            Recipe recipe = Recipe.Create(Type);
            recipe.AddIngredient(ItemID.GolfCart);
            CraftingKey.SetRequirements(ref recipe);
            recipe.Register();

            recipe = Recipe.Create(ItemID.GolfCart);
            recipe.AddIngredient(this);
            CraftingKey.SetRequirements(ref recipe);
            recipe.Register();
        }
    }
}