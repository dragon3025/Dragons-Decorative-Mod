using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
using Terraria.ObjectData;
using Terraria.DataStructures;
using Terraria.Enums;

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