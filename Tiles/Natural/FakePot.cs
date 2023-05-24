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
            Tile tile = Main.tile[i, j];
            int frame = tile.TileFrameY / 36;

            if (frame < 4)
            {
                DustType = DustID.Clay;
            }
            else if (frame < 7)
            {
                DustType = DustID.Ice;
            }
            else if (frame < 10)
            {
                DustType = DustID.Mud;
            }
            else if (frame < 13)
            {
                DustType = DustID.Bone;
            }
            else if (frame < 16)
            {
                DustType = DustID.Obsidian;
            }
            else if (frame < 19)
            {
                DustType = DustID.CorruptGibs;
            }
            else if (frame < 22)
            {
                DustType = DustID.Web;
            }
            else if (frame < 23)
            {
                DustType = DustID.Crimstone;
            }
            else if (frame < 27)
            {
                DustType = DustID.Sand;
            }
            else if (frame < 29)
            {
                DustType = DustID.Lihzahrd;
            }
            else if (frame < 30)
            {
                DustType = DustID.Marble;
            }
            else
            {
                DustType = DustID.Granite;
            }

            return true;
        }

        public override IEnumerable<Item> GetItemDrops(int i, int j)
        {
            Tile tile = Main.tile[i, j];
            int frame = tile.TileFrameY / 36;

            if (frame < 4)
            {
                yield return new Item(ItemID.ClayBlock);
            }
            else if (frame < 7)
            {
                yield return new Item(ItemID.IceBlock);
            }
            else if (frame < 10)
            {
                yield return new Item(ItemID.MudBlock);
            }
            else if (frame < 13)
            {
                yield return new Item(ItemID.Bone);
            }
            else if (frame < 16)
            {
                yield return new Item(ItemID.Obsidian);
            }
            else if (frame < 19)
            {
                yield return new Item(ItemID.EbonstoneBlock);
            }
            else if (frame < 22)
            {
                yield return new Item(ItemID.Cobweb);
            }
            else if (frame < 23)
            {
                yield return new Item(ItemID.CrimstoneBlock);
            }
            else if (frame < 27)
            {
                yield return new Item(ItemID.Sandstone);
            }
            else if (frame < 29)
            {
                yield return new Item(ItemID.LihzahrdBrick);
            }
            else if (frame < 30)
            {
                yield return new Item(ItemID.Marble);
            }
            else
            {
                yield return new Item(ItemID.Granite);
            }
        }
    }
}