using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
using Terraria.ObjectData;
using Terraria.DataStructures;

namespace DragonsDecorativeMod.Tiles.Natural.Ambient
{
    public class SmallA : ModTile
    {
        public override void SetStaticDefaults()
        {
            Main.tileFrameImportant[Type] = true;
            Main.tileNoAttach[Type] = true;
            Main.tileLavaDeath[Type] = true;

            TileObjectData.newTile.CopyFrom(TileObjectData.Style1x1);
            TileObjectData.newTile.DrawYOffset = 2;
            TileObjectData.newTile.StyleHorizontal = true;
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
            int itemID = 0;

            if (frame <= 5)
                itemID = ModContent.ItemType<Items.Natural.Ambient.SmallA.Rock>();
            else if (frame <= 11)
                itemID = ModContent.ItemType<Items.Natural.Ambient.SmallA.DirtClump>();
            else if (frame <= 15)
                itemID = ModContent.ItemType<Items.Natural.Ambient.SmallA.SmallSkull>();
            else if (frame <= 19)
                itemID = ModContent.ItemType<Items.Natural.Ambient.SmallA.TinyBonePile>();

            if (itemID > 0)
                Item.NewItem(new EntitySource_TileBreak(i, j), i * 16, j * 16, 16, 16, itemID);

            return base.Drop(i, j);
        }
    }
}