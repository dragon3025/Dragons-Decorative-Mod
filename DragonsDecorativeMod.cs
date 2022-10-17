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

//TO-DO When 1.4.4 comes out for tModLoader, remove ambient objects that the rubble maker already makes. Change the rest of the Ambient objects from craftable to rubblemaker-placed.