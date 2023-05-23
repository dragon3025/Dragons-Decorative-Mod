using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace DragonsDecorativeMod.Walls
{
    public class Trellis : ModWall
    {
        public override void SetStaticDefaults()
        {
            Main.wallLight[Type] = true;
            Main.wallHouse[Type] = true;
            DustType = DustID.WoodFurniture;
            AddMapEntry(new Color(127, 97, 63));
        }
    }
}