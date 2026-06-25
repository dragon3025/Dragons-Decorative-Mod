using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace DragonsDecorativeMod.Content.Items.Placeable.Pets
{
    public class OwlStand : ModItem
    {
        public override void SetDefaults()
        {
            Item.CloneDefaults(ItemID.Wood);
            Item.width = 32;
            Item.height = 32;
            Item.rare = ItemRarityID.White;
            Item.value = Item.sellPrice(0, 0, 10);
            Item.createTile = TileType<Tiles.Pets.OwlStand>();
        }

        public override bool CanUseItem(Player player)
        {
            switch (Main.rand.Next(4))
            {
                case 1:
                    Item.createTile = TileType<Tiles.Pets.OwlStand>();
                    break;
                case 2:
                    Item.createTile = TileType<Tiles.Pets.OwlStand2>();
                    break;
                case 3:
                    Item.createTile = TileType<Tiles.Pets.OwlStand3>();
                    break;
                default:
                    Item.createTile = TileType<Tiles.Pets.OwlStand4>();
                    break;
            }
            return true;
        }

        public override void AddRecipes()
        {
            if (!GetInstance<Configuration.Pets>().OwlStand)
            {
                return;
            }

            Recipe recipe = Recipe.Create(Type);
            recipe.AddIngredient(ItemID.Owl);
            recipe.AddRecipeGroup(RecipeGroupID.Wood, 2);
            recipe.AddTile(TileID.WorkBenches);
            CraftingKey.SetRequirements(ref recipe);
            recipe.Register();
        }
    }
}