using Terraria;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace DragonsDecorativeMod.Items.Garden
{
    [LegacyName("TrellisEmpty")]

    public class Trellis : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Trellis");
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

        public override void SetDefaults()
        {
            Item.width = 24;
            Item.height = 24;
            Item.maxStack = 9999;
            Item.useTurn = true;
            Item.autoReuse = true;
            Item.useAnimation = 15;
            Item.useTime = 15;
            Item.useStyle = ItemUseStyleID.Swing;
            Item.consumable = true;
            Item.createWall = ModContent.WallType<Walls.Trellis>();
            Item.rare = ItemRarityID.White;
        }

        public override void AddRecipes()
        {
            if (!GetInstance<ABlocksWallsConfig>().Trellis)
                return;
            CreateRecipe()
              .AddRecipeGroup(RecipeGroupID.Wood)
              .AddTile(TileID.Sawmill)
              .Register();
        }
    }
}
