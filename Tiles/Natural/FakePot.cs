using Microsoft.Xna.Framework;
using System.Collections.Generic;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace DragonsDecorativeMod.Tiles.Natural
{
    public class FakePot : ModTile
    {
        public override void SetStaticDefaults()
        {
            Main.tileFrameImportant[Type] = true;
            Main.tileNoAttach[Type] = true;
            Main.tileLavaDeath[Type] = true;

            TileObjectData.newTile.CopyFrom(TileObjectData.Style2x2);
            TileObjectData.newTile.DrawYOffset = 2;
            TileObjectData.newTile.StyleHorizontal = true;
            TileObjectData.newTile.StyleWrapLimit = 3;
            TileObjectData.addTile(Type);

            AddMapEntry(new Color(127, 127, 127));
        }

        public override bool CreateDust(int i, int j, ref int type)
        {
            return false;
        }

        //To-Do Rubblemaker is not yet supported. When support is added, this may need changed to "public override IEnumerable<Item> GetItemDrops(int i, int j)"
        public override void KillMultiTile(int x, int y, int frameX, int frameY)
        {

            int item = 0;
            int frame = frameY / 36;

            if (frame <= 3)
            {
                item = ItemID.ClayBlock;
            }
            else if (frame <= 6)
            {
                item = ItemID.IceBlock;
            }
            else if (frame <= 9)
            {
                item = ItemID.MudBlock;
            }
            else if (frame <= 12)
            {
                item = ItemID.Bone;
            }
            else if (frame <= 15)
            {
                item = ItemID.Obsidian;
            }
            else if (frame <= 18)
            {
                item = ItemID.EbonstoneBlock;
            }
            else if (frame <= 21)
            {
                item = ItemID.Cobweb;
            }
            else if (frame <= 24)
            {
                item = ItemID.CrimstoneBlock;
            }
            else if (frame <= 27)
            {
                item = ItemID.Sandstone;
            }
            else if (frame <= 30)
            {
                item = ItemID.LihzahrdBrick;
            }
            else if (frame <= 33)
            {
                item = ItemID.MarbleBlock;
            }
            else if (frame <= 36)
            {
                item = ItemID.Sandstone;
            }
            else if (frame <= 39)
            {
                item = ItemID.GraniteBlock;
            }

            if (item > 0)
            {
                Item.NewItem(new EntitySource_TileBreak(x, y), x * 16, y * 16, 32, 32, item);
            }
        }
    }
}