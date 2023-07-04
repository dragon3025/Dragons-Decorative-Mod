using DragonsDecorativeMod.Configuration;
using Terraria;
using Terraria.DataStructures;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace DragonsDecorativeMod.Items.Natural
{
    public class MysteriousTablet : ModItem
    {
        public override void SetStaticDefaults()
        {
            // DisplayName.SetDefault("Mysterious Tablet");
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;

            Main.RegisterItemAnimation(Item.type, new DrawAnimationVertical(5, 4));
            ItemID.Sets.AnimatesAsSoul[Item.type] = true;
        }

        public override void SetDefaults()
        {
            Item.width = 38;
            Item.height = 52;
            Item.maxStack = 9999;
            Item.useTurn = true;
            Item.autoReuse = true;
            Item.rare = ItemRarityID.Red;
            Item.useAnimation = 15;
            Item.useTime = 15;
            Item.useStyle = ItemUseStyleID.HoldUp;
            Item.consumable = true;
            Item.value = 0;
            Item.createTile = ModContent.TileType<Tiles.Natural.MysteriousTablet>();
        }

        public override void PostUpdate()
        {
            Lighting.AddLight(Item.Center, 0.8f, 0.75f, 0.55f);
        }

        public override void AddRecipes()
        {
            if (!GetInstance<DragonsDecoModConfig>().MysteriousTablet)
            {
                return;
            }

            Recipe recipe = Recipe.Create(Type);
            recipe.AddIngredient(ItemID.CelestialSigil);
            recipe.AddCondition(Condition.NearShimmer);
            recipe.AddCondition(Condition.DownedMoonLord);
            recipe.Register();

            recipe = Recipe.Create(ItemID.CelestialSigil);
            recipe.AddIngredient(Type);
            recipe.AddCondition(Condition.NearShimmer);
            recipe.AddCondition(Condition.DownedMoonLord);
            recipe.Register();
        }
    }
}