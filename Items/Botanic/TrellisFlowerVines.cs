using System;
using Terraria;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;

namespace DragonsDecorativeMod.Items.Botanic
{
    public class TrellisFlowerVines : ModItem
    {
        public int styleSecton = 0;

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Trellis Flower Vines");
            Tooltip.SetDefault("Right click to cycle between 12 colors + randomized color.");
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
            Item.createTile = ModContent.TileType<Tiles.Botanic.TrellisFlowerVines>();
            Item.placeStyle = 0;
        }

        public override bool AltFunctionUse(Player player)
        {
            styleSecton++;
            if (styleSecton > 12)
                styleSecton = 0;
            Item.placeStyle = Math.Min(11, styleSecton) * 4;

            return base.AltFunctionUse(player);
        }

        public override void UpdateInventory(Player player)
        {
            if (Main.rand.NextBool(15) && styleSecton == 12)
                Item.placeStyle = Main.rand.Next(48);
            base.UpdateInventory(player);
        }

        public override bool? UseItem(Player player)
        {
            if (styleSecton == 12)
                Item.placeStyle = Main.rand.Next(48);
            else
                Item.placeStyle = styleSecton * 4 + Main.rand.Next(4);
            return base.UseItem(player);
        }

        public override void AddRecipes()
        {
            CreateRecipe()
              .AddIngredient(ModContent.ItemType<TrellisVines>())
              .AddIngredient(ItemID.FlowerPacketWild)
              .AddTile(TileID.WorkBenches)
              .Register();
        }
    }
}
