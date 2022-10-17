using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.Enums;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace DragonsDecorativeMod.Tiles.Natural.Ambient
{
    public class SmallStalactites : ModTile
    {
        public override void SetStaticDefaults()
        {
            Main.tileFrameImportant[Type] = true;
            Main.tileNoAttach[Type] = true;
            Main.tileLavaDeath[Type] = true;

            TileObjectData.newTile.CopyFrom(TileObjectData.Style1x1);
            TileObjectData.newTile.AnchorBottom = AnchorData.Empty;
            TileObjectData.newTile.AnchorTop = new AnchorData(AnchorType.SolidTile | AnchorType.SolidSide, TileObjectData.newTile.Width, 0);
            TileObjectData.newTile.StyleHorizontal = true;
            TileObjectData.newTile.DrawYOffset = -2;
            TileObjectData.addTile(Type);

            AddMapEntry(new Color(127, 127, 127));
        }

        public override bool CreateDust(int i, int j, ref int type)
        {
            return false;
        }

        public override bool Drop(int i, int j)
        {
            Tile t = Main.tile[i, j];
            int frame = t.TileFrameX / 18;
            int item;

            if (frame < 3)
                item = ItemID.IceBlock;
            else if (frame < 6)
                item = ItemID.StoneBlock;
            else if (frame < 9)
                item = ItemID.Hive;
            else if (frame < 12)
                item = ItemID.PearlstoneBlock;
            else if (frame < 15)
                item = ItemID.EbonstoneBlock;
            else if (frame < 18)
                item = ItemID.CrimstoneBlock;
            else if (frame < 21)
                item = ItemID.Sandstone;
            else if (frame < 24)
                item = ItemID.GraniteBlock;
            else if (frame < 27)
                item = ItemID.MarbleBlock;
            else if (frame < 30)
                item = ItemID.PinkIceBlock;
            else if (frame < 33)
                item = ItemID.PurpleIceBlock;
            else
                item = ItemID.RedIceBlock;

            if (item > 0)
                Item.NewItem(new EntitySource_TileBreak(i, j), i * 16, j * 16, 16, 16, item);

            return base.Drop(i, j);
        }
    }
}