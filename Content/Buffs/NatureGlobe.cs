using Terraria;
using Terraria.ModLoader;

namespace DragonsDecorativeMod.Content.Buffs
{
    public class NatureGlobe : ModBuff
    {
        public override void SetStaticDefaults()
        {
            Main.buffNoTimeDisplay[Type] = true;
            Main.buffNoSave[Type] = true;
        }
    }
}