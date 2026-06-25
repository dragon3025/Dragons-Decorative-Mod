using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace DragonsDecorativeMod.Content.Items.Placeable.Other
{
    public class RopeCoilPlaceable : ModItem
    {
        public override void SetDefaults()
        {
            Item.CloneDefaults(ItemID.Wood);
            Item.width = 32;
            Item.height = 24;
            Item.rare = ItemRarityID.White;
            Item.value = Item.sellPrice(0, 0, 0, 20);
            Item.createTile = TileType<Tiles.Other.RopeCoil>();
        }

        public override void AddRecipes()
        {
            if (!GetInstance<Configuration.Other>().RopeCoilPlaceable)
            {
                return;
            }

            Recipe recipe = Recipe.Create(Type);
            CraftingKey.SetRequirements(ref recipe);
            Recipe recipe1 = recipe.Clone();

            recipe.AddIngredient(ItemID.RopeCoil);
            recipe.Register();

            recipe1.ReplaceResult(ItemID.RopeCoil);
            recipe1.AddIngredient(Type);
            recipe1.Register();
        }
    }
}