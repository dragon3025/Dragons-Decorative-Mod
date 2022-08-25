using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
using Terraria.ObjectData;
using Terraria.DataStructures;

namespace DragonsDecorativeMod.Tiles.Natural.Ambient
{
    public class LargeD : ModTile
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

            DustType = 0;
        }

        public override void KillMultiTile(int x, int y, int frameX, int frameY)
        {

            int item = 0;
            int frame = frameX / 54;

            if (frame <= 5)
                item = ModContent.ItemType<Items.Natural.Ambient.LargeD.BonePile>();
            else if (frame <= 6)
                item = ModContent.ItemType<Items.Natural.Ambient.LargeD.SkeletonPiercedBySword>();
            else if (frame <= 12)
                item = ModContent.ItemType<Items.Natural.Ambient.LargeD.Rocks>();
            else if (frame <= 15)
                item = ModContent.ItemType<Items.Natural.Ambient.LargeD.ToolAndRocks>();
            else if (frame <= 17)
                item = ModContent.ItemType<Items.Natural.Ambient.LargeD.LargeCopperCoinStash>();
            else if (frame <= 19)
                item = ModContent.ItemType<Items.Natural.Ambient.LargeD.LargeSilverCoinStash>();

            if (item > 0)
                Item.NewItem(new EntitySource_TileBreak(x, y), x * 16, y * 16, 48, 32, item);
        }
    }
}