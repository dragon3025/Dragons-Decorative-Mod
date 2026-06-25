using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace DragonsDecorativeMod.Content.Items.Placeable.Other
{
    public class BalloonsPaintable : ModItem
    {
        public override void SetDefaults()
        {
            Item.CloneDefaults(ItemID.Wood);
            Item.width = 28;
            Item.height = 32;
            Item.rare = ItemRarityID.White;
            Item.value = Item.sellPrice(0, 0, 4);
            Item.createTile = TileType<Tiles.Other.BalloonsPaintable>();
        }

        public override void AddRecipes()
        {
            if (GetInstance<Configuration.Other>().Balloons)
            {
                return;
            }
            Recipe recipe = Recipe.Create(Type);
            recipe.AddIngredient(ItemID.PartyBundleOfBalloonTile);
            CraftingKey.SetRequirements(ref recipe);
            recipe.Register();
        }
    }
}