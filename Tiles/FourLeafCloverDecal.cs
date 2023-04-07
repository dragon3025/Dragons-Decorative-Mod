using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace DragonsDecorativeMod.Tiles
{
    public class FourLeafCloverDecal : ModTile
    {
        public override void SetStaticDefaults()
        {
            Main.tileFrameImportant[Type] = true;
            Main.tileNoAttach[Type] = true;
            Main.tileLavaDeath[Type] = true;

            TileObjectData.newTile.CopyFrom(TileObjectData.Style3x3Wall);
            TileObjectData.addTile(Type);

            AddMapEntry(new Color(18, 140, 30));
        }

        public override bool CreateDust(int i, int j, ref int type)
        {
            return false;
        }
    }
}