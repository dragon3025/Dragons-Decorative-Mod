using Terraria;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace DragonsDecorativeMod.Items.Natural.Ambient.SmallC
{
    public class TinySpiderEggs : ModItem
    {
        public override void SetStaticDefaults()
        {
            // DisplayName.SetDefault("Tiny Spider Eggs");
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

        public override void SetDefaults()
        {
            Item.width = 16;
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
            Item.createTile = ModContent.TileType<Tiles.Natural.Ambient.SmallC>();
            Item.placeStyle = 12;
        }

        public override bool? UseItem(Player player)
        {
            Item.placeStyle = 12 + Main.rand.Next(6);
            return base.UseItem(player);
        }

        public override void AddRecipes()
        {
            if (!GetInstance<BFurnitureConfig>().OtherAmbient)
            {
                return;
            }

            CreateRecipe()
              .AddIngredient(ItemID.Cobweb)
              .AddTile(TileID.HeavyWorkBench)
              .AddCondition(Condition.InGraveyard)
              .Register();
        }
    }
}