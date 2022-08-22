using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent.Creative;

namespace DragonsDecorativeMod.Items.Garden
{
    public class TrellisEmpty : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Trellis Empty");
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

        public override void SetDefaults()
        {
            Item.width = 16;
            Item.height = 16;
            Item.maxStack = 9999;
            Item.useTurn = true;
            Item.autoReuse = true;
            Item.useAnimation = 15;
            Item.useTime = 15;
            Item.useStyle = ItemUseStyleID.Swing;
            Item.consumable = true;
            Item.createTile = ModContent.TileType<Tiles.Garden.TrellisEmpty>();
            Item.placeStyle = 0;
        }

        public override bool? UseItem(Player player)
        {
            Item.placeStyle = Main.rand.Next(4);
            return base.UseItem(player);
        }

        public override void AddRecipes()
        {
            CreateRecipe()
              .AddRecipeGroup(RecipeGroupID.Wood)
              .AddTile(TileID.WorkBenches)
              .Register();
        }
    }
}
