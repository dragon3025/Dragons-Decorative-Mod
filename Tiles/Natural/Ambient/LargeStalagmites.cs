using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
using Terraria.ObjectData;
using Terraria.DataStructures;

namespace DragonsDecorativeMod.Tiles.Natural.Ambient
{
    public class LargeStalagmites : ModTile
    {
        public override void SetStaticDefaults()
        {
            Main.tileFrameImportant[Type] = true;
            Main.tileNoAttach[Type] = true;
            Main.tileLavaDeath[Type] = true;

            TileObjectData.newTile.CopyFrom(TileObjectData.Style1x2);
            TileObjectData.newTile.StyleHorizontal = true;
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
            int frame = frameX / 18;

            if (frame < 3)
                item = ModContent.ItemType<Items.Natural.Ambient.LargeStalagmites.LargeStoneStalagmite>();
            else if (frame < 6)
                item = ModContent.ItemType<Items.Natural.Ambient.LargeStalagmites.LargePearlstoneStalagmite>();
            else if (frame < 9)
                item = ModContent.ItemType<Items.Natural.Ambient.LargeStalagmites.LargeEbonstoneStalagmite>();
            else if (frame < 12)
                item = ModContent.ItemType<Items.Natural.Ambient.LargeStalagmites.LargeCrimstoneStalagmite>();
            else if (frame < 15)
                item = ModContent.ItemType<Items.Natural.Ambient.LargeStalagmites.LargeSandstoneStalagmite>();
            else if (frame < 18)
                item = ModContent.ItemType<Items.Natural.Ambient.LargeStalagmites.LargeGraniteStalagmite>();
            else if (frame < 21)
                item = ModContent.ItemType<Items.Natural.Ambient.LargeStalagmites.LargeMarbleStalagmite>();

            if (item > 0)
                Item.NewItem(new EntitySource_TileBreak(x, y), x * 16, y * 16, 16, 32, item);
        }
    }
}