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

        public override bool CreateDust(int i, int j, ref int type)
        {
            return false;
        }

        public override void KillMultiTile(int x, int y, int frameX, int frameY)
        {

            int item = 0;
            int frame = frameX / 54;

            Main.NewText("Frame: " + frame.ToString());

            if (frame <= 2)
                item = ModContent.ItemType<Items.Natural.Ambient.LargeC.LihzahrdRubble>();
            else if (frame <= 4)
                item = ModContent.ItemType<Items.Natural.Ambient.LargeC.UndergroundCage>();
            else if (frame <= 5)
                item = ModContent.ItemType<Items.Natural.Ambient.LargeC.RustyMinecart>();
            else if (frame <= 6)
                item = ModContent.ItemType<Items.Natural.Ambient.LargeC.Well>();
            else if (frame <= 7)
                item = ModContent.ItemType<Items.Natural.Ambient.LargeC.ShovelAndDirt>();
            else if (frame <= 8)
                item = ModContent.ItemType<Items.Natural.Ambient.LargeC.Tent>();
            else if (frame <= 9)
                item = ModContent.ItemType<Items.Natural.Ambient.LargeC.WheelbarrowOfDirt>();
            else if (frame <= 10)
                item = ModContent.ItemType<Items.Natural.Ambient.LargeC.WoodPoleWithRope>();
            else if (frame <= 16)
                item = ModContent.ItemType<Items.Natural.Ambient.LargeC.SandstonePiles>();

            if (item > 0)
                Item.NewItem(new EntitySource_TileBreak(x, y), x * 16, y * 16, 48, 32, item);
        }
    }
}