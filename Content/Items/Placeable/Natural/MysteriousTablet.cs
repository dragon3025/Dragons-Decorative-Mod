using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace DragonsDecorativeMod.Content.Items.Placeable.Natural
{
    public class MysteriousTablet : ModItem
    {
        public override void SetStaticDefaults()
        {
            Main.RegisterItemAnimation(Item.type, new DrawAnimationVertical(5, 4));
            ItemID.Sets.AnimatesAsSoul[Item.type] = true;
        }

        public override void SetDefaults()
        {
            Item.CloneDefaults(ItemID.Wood);
            Item.width = 38;
            Item.height = 52;
            Item.rare = ItemRarityID.Red;
            Item.value = 0;
            Item.createTile = TileType<Tiles.Natural.MysteriousTablet>();
        }

        public override void PostUpdate()
        {
            Lighting.AddLight(Item.Center, 0.8f, 0.75f, 0.55f);
        }

        public override void AddRecipes()
        {
            if (!GetInstance<Configuration.Natural>().MysteriousTablet)
            {
                return;
            }

            Recipe recipe = Recipe.Create(Type);
            recipe.AddIngredient(ItemID.CelestialSigil);
            recipe.AddIngredient(ItemID.ShimmerBlock);
            CraftingKey.SetRequirements(ref recipe);
            recipe.Register();
        }
    }
}