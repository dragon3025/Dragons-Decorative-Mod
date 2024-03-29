/* To debug, use:
 * Terraria.ModLoader.ModContent.GetInstance<DragonsDecorativeMod>().Logger.Debug("");
 * 
 * To turn into a string use:
 * $"text {variable}"
 * 
 * To show text in chat use:
 * Main.NewText(string);
 */

using Terraria;
using Terraria.ModLoader;

namespace DragonsDecorativeMod
{
    class DragonsDecorativeMod : Mod
    {
        public override void Load()
        {
            ModLoader.TryGetMod("Wikithis", out Mod wikithis);
            if (wikithis != null && !Main.dedServ)
            {
                wikithis.Call("AddModURL", this, "https://terrariamods.wiki.gg/wiki/Dragon%27s_Decorative_Mod/{}");
            }
        }
    }
}
