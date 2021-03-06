using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
using Terraria.ObjectData;
using Terraria.DataStructures;

namespace DragonsDecorativeMod.Tiles.Natural.Ambient
{
    public class LargeC : ModTile
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

        public override void KillMultiTile(int x, int y, int frameX, int frameY)
        {

            int item = 0;
            int frame = frameX / 54;

            if (frame <= 2)
                item = ModContent.ItemType<Items.Natural.Ambient.LargeC.LihzahrdRubble>();
            if (frame <= 4)
                item = ModContent.ItemType<Items.Natural.Ambient.LargeC.UndergroundCage>();
            if (frame <= 5)
                item = ModContent.ItemType<Items.Natural.Ambient.LargeC.RustyMinecart>();
            if (frame <= 7)
                item = ModContent.ItemType<Items.Natural.Ambient.LargeC.Well>();
            if (frame <= 8)
                item = ModContent.ItemType<Items.Natural.Ambient.LargeC.ShovelAndDirt>();
            if (frame <= 9)
                item = ModContent.ItemType<Items.Natural.Ambient.LargeC.Tent>();
            if (frame <= 10)
                item = ModContent.ItemType<Items.Natural.Ambient.LargeC.WheelbarrowOfDirt>();
            if (frame <= 11)
                item = ModContent.ItemType<Items.Natural.Ambient.LargeC.WoodPoleWithRope>();
            if (frame <= 17)
                item = ModContent.ItemType<Items.Natural.Ambient.LargeC.SandstonePiles>();

            if (item > 0)
                Item.NewItem(new EntitySource_TileBreak(x, y), x * 16, y * 16, 48, 32, item);
        }
    }
}