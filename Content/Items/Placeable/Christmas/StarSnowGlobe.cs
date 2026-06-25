using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace DragonsDecorativeMod.Content.Items.Placeable.Christmas
{
    public class StarSnowGlobe : ModItem
    {
        public override void SetDefaults()
        {
            Item.CloneDefaults(ItemID.Wood);
            Item.width = 26;
            Item.height = 26;
            Item.rare = ItemRarityID.White;
            Item.createTile = TileType<Tiles.Christmas.StarSnowGlobe>();
        }

        public override void AddRecipes()
        {
            if (!GetInstance<Configuration.Christmas>().StarSnowGlobe)
            {
                return;
            }

            Recipe recipe = Recipe.Create(Type);
            recipe.AddIngredient(ItemID.SnowBlock);
            recipe.AddIngredient(ItemID.FallenStar);
            recipe.AddIngredient(ItemID.BottledWater);
            CraftingKey.SetRequirements(ref recipe);
            recipe.Register();
        }
    }
}