using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace DragonsDecorativeMod.Tiles.Natural.Ambient
{
    public class MediumA : ModTile
    {
        public override void SetStaticDefaults()
        {
            Main.tileFrameImportant[Type] = true;
            Main.tileNoAttach[Type] = true;
            Main.tileLavaDeath[Type] = true;

            TileObjectData.newTile.CopyFrom(TileObjectData.Style2x1);
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
            int frame = frameX / 36;

            if (frame <= 5)
                item = ItemID.StoneBlock;
            else if (frame <= 10)
                item = ItemID.Bone;
            else if (frame <= 15)
                item = ItemID.Bone;
            else if (frame <= 16)
                item = ItemID.CopperCoin;
            else if (frame <= 17)
                item = ItemID.SilverCoin;
            else if (frame <= 18)
                item = ItemID.GoldCoin;

            if (item > 0)
                Item.NewItem(new EntitySource_TileBreak(x, y), x * 16, y * 16, 32, 16, item);
        }
    }
}