using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace DragonsDecorativeMod.GlobalRecipes
{

    class Recipes : ModSystem
    {
        public static RecipeGroup colorfulFish;

        public override void Unload()
        {
            colorfulFish = null;
        }

        public override void AddRecipeGroups()
        {
            colorfulFish = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " Colorful Fish (Armored Cave, Chaos, Princess, Prismite, Neon Tetra, Variegated Lard, Specular, Damsel)", new int[]
            {
                ItemID.ArmoredCavefish,
                ItemID.ChaosFish,
                ItemID.PrincessFish,
                ItemID.Prismite,
                ItemID.NeonTetra,
                ItemID.VariegatedLardfish,
                ItemID.SpecularFish,
                ItemID.Damselfish
            });
            RecipeGroup.RegisterGroup("DragonsDecorativeMod:colorfulFish", colorfulFish);
        }

        public override void AddRecipes()
        {
            if (!GetInstance<BFurnitureConfig>().Aquarium)
            {
                return;
            }

            Recipe recipe = Recipe.Create(ItemType<Items.Aquarium>());
            recipe.AddRecipeGroup("DragonsDecorativeMod:colorfulFish", 10);
            recipe.AddIngredient(ItemID.Terrarium);
            recipe.Register();
        }
    }
}
