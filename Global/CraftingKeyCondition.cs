using Terraria;
using static Terraria.ModLoader.ModContent;

namespace DragonsDecorativeMod.Global
{
    public static class CraftingKeyCondition
    {
        public static Condition HasCraftingKey = new("Mods.DragonsDecorativeMod.Conditions.HasCraftingKey", () => Main.LocalPlayer.HasItem(ItemType<Items.CraftingKey>()));
    }
}
