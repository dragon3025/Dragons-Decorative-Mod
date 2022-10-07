using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent.Creative;

namespace DragonsDecorativeMod.Items.Natural.Ambient.LargeStalagmites
{
    public class LargeGraniteStalagmite : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Large Granite Stalagmite");
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

        public override void SetDefaults()
        {
            Item.width = 16;
            Item.height = 32;
            Item.maxStack = 9999;
            Item.useTurn = true;
            Item.autoReuse = true;
            Item.rare = ItemRarityID.White;
            Item.useAnimation = 15;
            Item.useTime = 15;
            Item.useStyle = ItemUseStyleID.HoldUp;
            Item.consumable = true;
            Item.value = 0;
            Item.createTile = ModContent.TileType<Tiles.Natural.Ambient.LargeStalagmites>();
            Item.placeStyle = 15;
        }

        public override bool? UseItem(Player player)
        {
            Item.placeStyle = Main.rand.Next(15, 18);
            return base.UseItem(player);
        }

        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ItemID.Granite)
                .AddTile(TileID.HeavyWorkBench)
                .AddCondition(Recipe.Condition.InGraveyardBiome)
                .Register();
        }
    }
}