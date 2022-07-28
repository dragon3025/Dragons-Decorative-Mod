using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
using Terraria.ObjectData;
using Terraria.DataStructures;

namespace DragonsDecorativeMod.Tiles.Natural.Ambient
{
    public class LargeB : ModTile
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
                item = ModContent.ItemType<Items.Natural.Ambient.LargeB.JungleGrassyRocks>();
            else if (frame <= 5)
                item = ModContent.ItemType<Items.Natural.Ambient.LargeB.JungleGrassyMudPiles>();
            else if (frame <= 8)
                item = ModContent.ItemType<Items.Natural.Ambient.LargeB.AshPilesWithHellstone>();
            else if (frame <= 9 || frame == 13)
                item = ModContent.ItemType<Items.Natural.Ambient.LargeB.WebCoveredSkeleton>();
            else if (frame <= 12)
                item = ModContent.ItemType<Items.Natural.Ambient.LargeB.LargeSpiderEggs>();
            else if (frame <= 16)
                item = ModContent.ItemType<Items.Natural.Ambient.LargeB.GrassyRocks>();
            else if (frame <= 17)
                item = ModContent.ItemType<Items.Natural.Ambient.LargeB.FakeEnchantedSwordInStone>();

            if (item > 0)
                Item.NewItem(new EntitySource_TileBreak(x, y), x * 16, y * 16, 48, 32, item);
        }
    }
}