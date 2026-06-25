using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace DragonsDecorativeMod.Content.Items.Placeable.Other
{
    public class LargePot : ModItem
    {
        public override void SetDefaults()
        {
            Item.CloneDefaults(ItemID.Wood);
            Item.width = 32;
            Item.height = 32;
            Item.rare = ItemRarityID.White;
            Item.value = Item.sellPrice(0, 0, 1);
            Item.createTile = TileType<Tiles.Other.LargePot>();
        }

        public override void AddRecipes()
        {
            if (!GetInstance<Configuration.Other>().LargePot)
            {
                return;
            }

            Recipe recipe = Recipe.Create(Type);
            CraftingKey.SetRequirements(ref recipe);
            Recipe recipe1 = recipe.Clone();

            recipe.AddIngredient(ItemID.CookingPot);
            recipe.Register();

            recipe1.ReplaceResult(ItemID.CookingPot);
            recipe1.AddIngredient(Type);
            recipe1.Register();
        }
    }
}