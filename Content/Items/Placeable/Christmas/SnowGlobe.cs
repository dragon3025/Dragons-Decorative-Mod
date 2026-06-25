using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace DragonsDecorativeMod.Content.Items.Placeable.Christmas
{
    public class SnowGlobe : ModItem
    {
        public override void SetDefaults()
        {
            Item.CloneDefaults(ItemID.Wood);
            Item.width = 26;
            Item.height = 26;
            Item.rare = ItemRarityID.White;
            Item.createTile = TileType<Tiles.Christmas.SnowGlobe>();
        }

        public override void AddRecipes()
        {
            if (!GetInstance<Configuration.Christmas>().SnowGlobe)
            {
                return;
            }

            Recipe recipe = Recipe.Create(Type);
            recipe.AddIngredient(ItemID.SnowBlock);
            recipe.AddIngredient(ItemID.CandyCaneBlock);
            recipe.AddIngredient(ItemID.BottledWater);
            CraftingKey.SetRequirements(ref recipe);
            recipe.Register();
        }
    }
}