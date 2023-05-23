using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace DragonsDecorativeMod.Tiles.Garden
{
    public class Vines : ModTile
    {
        public override void SetStaticDefaults()
        {
            Main.tileLavaDeath[Type] = true;
            DustType = DustID.Grass;

            AddMapEntry(new Color(30, 94, 33));

            HitSound = SoundID.Grass;
            DustType = DustID.Grass;
        }
    }
}