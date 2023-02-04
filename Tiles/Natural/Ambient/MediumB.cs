using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;

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

            if (frame <= 0)
            {
                item = ItemID.Amethyst;
            }
            else if (frame <= 1)
            {
                item = ItemID.Topaz;
            }
            else if (frame <= 2)
            {
                item = ItemID.Sapphire;
            }
            else if (frame <= 3)
            {
                item = ItemID.Emerald;
            }
            else if (frame <= 4)
            {
                item = ItemID.Ruby;
            }
            else if (frame <= 5)
            {
                item = ItemID.Diamond;
            }
            else if (frame <= 11)
            {
                item = ItemID.SnowBlock;
            }
            else if (frame <= 14)
            {
                item = ItemID.Wood;
            }
            else if (frame <= 18)
            {
                item = ItemID.Cobweb;
            }

            if (item > 0)
            {
                Item.NewItem(new EntitySource_TileBreak(x, y), x * 16, y * 16, 32, 16, item);
            }
        }
    }
}