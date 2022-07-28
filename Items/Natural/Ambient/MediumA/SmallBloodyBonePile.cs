using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent.Creative;

namespace DragonsDecorativeMod.Items.Natural.Ambient.MediumA
{
    public class SmallBloodyBonePile : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Small Bloody Bone Pile");
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

        public override void SetDefaults()
        {
            Item.width = 32;
            Item.height = 16;
            Item.maxStack = 9999;
            Item.useTurn = true;
            Item.autoReuse = true;
            Item.rare = ItemRarityID.White;
            Item.useAnimation = 15;
            Item.useTime = 15;
            Item.useStyle = ItemUseStyleID.HoldUp;
            Item.consumable = true;
            Item.value = 0;
            Item.createTile = ModContent.TileType<Tiles.Natural.Ambient.MediumA>();
            Item.placeStyle = 11;
        }

        public override bool? UseItem(Player player)
        {
            Item.placeStyle = 11 + Main.rand.Next(5);
            return base.UseItem(player);
        }

        public override void AddRecipes()
        {
            CreateRecipe(5)
              .AddIngredient(ItemID.Bone, 35)
              .AddIngredient(ItemID.RedDye)
              .AddTile(TileID.HeavyWorkBench)
              .AddCondition(Recipe.Condition.InGraveyardBiome)
              .Register();
        }
    }
}