using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
using Terraria.ObjectData;
using Terraria.DataStructures;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.DataStructures;
using Terraria.Enums;
using Terraria.ModLoader;
using Terraria.ObjectData;
using Terraria.ID;

namespace DragonsDecorativeMod.Tiles.Natural.Ambient
{
    public class SmallStalactites : ModTile
    {
        public override void SetStaticDefaults()
        {
            Main.tileFrameImportant[Type] = true;
            Main.tileNoAttach[Type] = true;
            Main.tileLavaDeath[Type] = true;

            //newTile.Width = 1;
            //newTile.Height = 1;
            //newTile.Origin = new Point16(0, 0);
            //newTile.AnchorBottom = new AnchorData(AnchorType.SolidTile | AnchorType.SolidWithTop | AnchorType.SolidSide, newTile.Width, 0);
            //newTile.UsesCustomCanPlace = true;
            //newTile.CoordinateHeights = new int[1] { 16 };
            //newTile.CoordinateWidth = 16;
            //newTile.CoordinatePadding = 2;
            //newTile.LavaDeath = true;
            //addBaseTile(out Style1x1);

            //newTile.Width = 1;
            //newTile.Height = 2;
            //newTile.Origin = new Point16(0, 0);
            //newTile.AnchorTop = new AnchorData(AnchorType.SolidTile | AnchorType.SolidSide, newTile.Width, 0);
            //newTile.UsesCustomCanPlace = true;
            //newTile.CoordinateHeights = new int[2] { 16, 16 };
            //newTile.CoordinateWidth = 16;
            //newTile.CoordinatePadding = 2;
            //newTile.LavaDeath = true;
            //addBaseTile(out Style1x2Top);

            TileObjectData.newTile.CopyFrom(TileObjectData.Style1x1);
            TileObjectData.newTile.AnchorBottom = AnchorData.Empty;
            TileObjectData.newTile.AnchorTop = new AnchorData(AnchorType.SolidTile | AnchorType.SolidSide, TileObjectData.newTile.Width, 0);
            TileObjectData.newTile.StyleHorizontal = true;
            TileObjectData.newTile.DrawYOffset = -2;
            TileObjectData.addTile(Type);

            AddMapEntry(new Color(127, 127, 127));

            DustType = 0;
        }

        public override bool Drop(int i, int j)
        {
            Tile t = Main.tile[i, j];
            int frame = t.TileFrameX / 18;
            int item;

            if (frame < 3)
                item = ModContent.ItemType<Items.Natural.Ambient.SmallStalactites.SmallIcicle>();
            else if (frame < 6)
                item = ModContent.ItemType<Items.Natural.Ambient.SmallStalactites.SmallStoneStalactite>();
            else if (frame < 9)
                item = ModContent.ItemType<Items.Natural.Ambient.SmallStalactites.SmallHiveStalactite>();
            else if (frame < 12)
                item = ModContent.ItemType<Items.Natural.Ambient.SmallStalactites.SmallPearlstoneStalactite>();
            else if (frame < 15)
                item = ModContent.ItemType<Items.Natural.Ambient.SmallStalactites.SmallEbonstoneStalactite>();
            else if (frame < 18)
                item = ModContent.ItemType<Items.Natural.Ambient.SmallStalactites.SmallCrimstoneStalactite>();
            else if (frame < 21)
                item = ModContent.ItemType<Items.Natural.Ambient.SmallStalactites.SmallSandstoneStalactite>();
            else if (frame < 24)
                item = ModContent.ItemType<Items.Natural.Ambient.SmallStalactites.SmallGraniteStalactite>();
            else if (frame < 27)
                item = ModContent.ItemType<Items.Natural.Ambient.SmallStalactites.SmallMarbleStalactite>();
            else if (frame < 30)
                item = ModContent.ItemType<Items.Natural.Ambient.SmallStalactites.SmallPinkIcicle>();
            else if (frame < 33)
                item = ModContent.ItemType<Items.Natural.Ambient.SmallStalactites.SmallPurpleIcicle>();
            else
                item = ModContent.ItemType<Items.Natural.Ambient.SmallStalactites.SmallRedIcicle>();

            if (item > 0)
                Item.NewItem(new EntitySource_TileBreak(i, j), i * 16, j * 16, 16, 16, item);

            return base.Drop(i, j);
        }
    }
}