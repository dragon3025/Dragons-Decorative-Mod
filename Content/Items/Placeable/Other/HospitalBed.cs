using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace DragonsDecorativeMod.Content.Items.Placeable.Other
{
    public class HospitalBed : ModItem
    {
        public override void SetDefaults()
        {
            Item.CloneDefaults(ItemID.Wood);
            Item.width = 32;
            Item.height = 22;
            Item.rare = ItemRarityID.White;
            Item.createTile = TileType<Tiles.Other.HospitalBed>();
            Item.value = Item.sellPrice(0, 0, 4);
        }

        public override void AddRecipes()
        {
            if (!GetInstance<Configuration.Other>().HospitalBed)
            {
                return;
            }

            Recipe recipe = Recipe.Create(Type);
            recipe.AddRecipeGroup(RecipeGroupID.IronBar, 4);
            recipe.AddIngredient(ItemID.Silk, 5);
            recipe.AddTile(TileID.HeavyWorkBench);
            CraftingKey.SetRequirements(ref recipe);
            recipe.Register();
        }
    }
}