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
                wikithis.Call("AddModURL", this, "terrariamods.fandom.com$Dragon%27s_Decorative_Mod");
            }
        }
    }
}
