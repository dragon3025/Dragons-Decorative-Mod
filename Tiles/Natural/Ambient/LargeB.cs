using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace DragonsDecorativeMod.Tiles.Natural.Ambient
{
    public class LargeB : ModTile
    {
        public override void SetStaticDefaults()
        {
            Main.tileFrameImportant[Type] = true;
            Main.tileNoAttach[Type] = true;
            Main.tileLavaDeath[Type] = true;

            TileObjectData.newTile.CopyFrom(TileObjectData.Style3x2);
            TileObjectData.newTile.DrawYOffset = 2;
            TileObjectData.addTile(Type);

            AddMapEntry(new Color(127, 127, 127));
        }

        public override bool CreateDust(int i, int j, ref int type)
        {
            return false;
        }

        public override void KillMultiTile(int x, int y, int frameX, int frameY)
        {

            int item = 0;
            int frame = frameX / 54;

            if (frame <= 2)
                item = ItemID.JungleGrassSeeds;
            else if (frame <= 5)
                item = ItemID.JungleGrassSeeds;
            else if (frame <= 8)
                item = ItemID.Hellstone;
            else if (frame <= 9 || frame == 13)
                item = ItemID.Cobweb;
            else if (frame <= 12)
                item = ItemID.Cobweb;
            else if (frame <= 16)
                item = ItemID.GrassSeeds;
            else if (frame <= 17)
                item = ItemID.EnchantedSword;

            if (item > 0)
                Item.NewItem(new EntitySource_TileBreak(x, y), x * 16, y * 16, 48, 32, item);
        }
    }
}