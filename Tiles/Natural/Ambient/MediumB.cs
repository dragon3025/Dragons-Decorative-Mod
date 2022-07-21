using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
using Terraria.ObjectData;
using Terraria.DataStructures;
using Terraria.Enums;

namespace DragonsDecorativeMod.Tiles.Natural.Ambient
{
    public class MediumB : ModTile
    {
        public override void SetStaticDefaults()
        {
            Main.tileFrameImportant[Type] = true;
            Main.tileNoAttach[Type] = true;
            Main.tileLavaDeath[Type] = true;

            TileObjectData.newTile.CopyFrom(TileObjectData.Style2x1);
            TileObjectData.newTile.DrawYOffset = 2;
            TileObjectData.newTile.StyleWrapLimit = 36;
            TileObjectData.addTile(Type);

            AddMapEntry(new Color(127, 127, 127));
        }

        public override void KillMultiTile(int x, int y, int frameX, int frameY)
        {

            int item = 0;
            int frame = frameX / 36;

            if (frame <= 0)
                item = ModContent.ItemType<Items.Natural.Ambient.MediumB.AmethystStash>();
            else if (frame <= 1)
                item = ModContent.ItemType<Items.Natural.Ambient.MediumB.TopazStash>();
            else if (frame <= 2)
                item = ModContent.ItemType<Items.Natural.Ambient.MediumB.SapphireStash>();
            else if (frame <= 3)
                item = ModContent.ItemType<Items.Natural.Ambient.MediumB.EmeraldStash>();
            else if (frame <= 4)
                item = ModContent.ItemType<Items.Natural.Ambient.MediumB.RubyStash>();
            else if (frame <= 5)
                item = ModContent.ItemType<Items.Natural.Ambient.MediumB.DiamondStash>();
            else if (frame <= 11)
                item = ModContent.ItemType<Items.Natural.Ambient.MediumB.SmallIceRocks>();
            else if (frame <= 14)
                item = ModContent.ItemType<Items.Natural.Ambient.MediumB.SmallBrokenFurniture>();
            else if (frame <= 18)
                item = ModContent.ItemType<Items.Natural.Ambient.MediumB.SmallSpiderEggs>();

            if (item > 0)
                Item.NewItem(new EntitySource_TileBreak(x, y), x * 16, y * 16, 54, 32, item);
        }
    }
}