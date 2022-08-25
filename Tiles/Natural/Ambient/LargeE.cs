using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
using Terraria.ObjectData;
using Terraria.DataStructures;

namespace DragonsDecorativeMod.Tiles.Natural.Ambient
{
    public class LargeE : ModTile
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

            if (frame <= 1)
                item = ModContent.ItemType<Items.Natural.Ambient.LargeE.LargeGoldCoinStash>();
            else if (frame <= 2)
                item = ModContent.ItemType<Items.Natural.Ambient.LargeE.BrokenFurniture>();
            else if (frame <= 3)
                item = ModContent.ItemType<Items.Natural.Ambient.LargeE.BrokenGrandfatherClock>();
            else if (frame <= 4)
                item = ModContent.ItemType<Items.Natural.Ambient.LargeE.BrokenChest>();
            else if (frame <= 5)
                item = ModContent.ItemType<Items.Natural.Ambient.LargeE.BrokenChandelier>();
            else if (frame <= 11)
                item = ModContent.ItemType<Items.Natural.Ambient.LargeE.IceRocks>();
            else if (frame <= 14)
                item = ModContent.ItemType<Items.Natural.Ambient.LargeE.MushroomRocks>();

            if (item > 0)
                Item.NewItem(new EntitySource_TileBreak(x, y), x * 16, y * 16, 48, 32, item);
        }
    }
}