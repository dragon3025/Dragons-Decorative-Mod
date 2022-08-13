using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
using Terraria.ObjectData;
using Terraria.DataStructures;

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

        public override void KillMultiTile(int x, int y, int frameX, int frameY)
        {

            int item = 0;
            int frame = frameY / 36;

            if (frame <= 3)
                item = ModContent.ItemType<Items.Natural.Pots.ForestPot>();
            else if (frame <= 6)
                item = ModContent.ItemType<Items.Natural.Pots.FrozenPot>();
            else if (frame <= 9)
                item = ModContent.ItemType<Items.Natural.Pots.JunglePot>();
            else if (frame <= 12)
                item = ModContent.ItemType<Items.Natural.Pots.DungeonPot>();
            else if (frame <= 15)
                item = ModContent.ItemType<Items.Natural.Pots.ObsidianPot>();
            else if (frame <= 18)
                item = ModContent.ItemType<Items.Natural.Pots.CorruptionPot>();
            else if (frame <= 21)
                item = ModContent.ItemType<Items.Natural.Pots.SpiderPot>();
            else if (frame <= 24)
                item = ModContent.ItemType<Items.Natural.Pots.CrimsonPot>();
            else if (frame <= 27)
                item = ModContent.ItemType<Items.Natural.Pots.PyramidPot>();
            else if (frame <= 30)
                item = ModContent.ItemType<Items.Natural.Pots.LihzahrdPot>();
            else if (frame <= 33)
                item = ModContent.ItemType<Items.Natural.Pots.MarblePot>();
            else if (frame <= 36)
                item = ModContent.ItemType<Items.Natural.Pots.UndergroundDesertPot>();
            else if (frame <= 39)
                item = ModContent.ItemType<Items.Natural.Pots.GranitePot>();

            if (item > 0)
                Item.NewItem(new EntitySource_TileBreak(x, y), x * 16, y * 16, 32, 32, item);
        }
    }
}