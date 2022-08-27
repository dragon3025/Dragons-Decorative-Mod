using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace DragonsDecorativeMod.Tiles.Garden.PottedPlants
{
    public class PottedPalmTrees : ModTile
    {
        public override void SetStaticDefaults()
        {
            Main.tileFrameImportant[Type] = true;
            Main.tileLavaDeath[Type] = true;
            Main.tileNoAttach[Type] = true;

            TileObjectData.newTile.CopyFrom(TileObjectData.Style3x4);
            TileObjectData.newTile.Height = 6;
            TileObjectData.newTile.Origin = new Point16(1, 5);
            TileObjectData.newTile.CoordinateHeights = new int[6] { 16, 16, 16, 16, 16 , 16};
            TileObjectData.newTile.DrawYOffset = 2;
            TileObjectData.addTile(Type);

            AddMapEntry(new Color(127, 127, 127));
        }

        public override void KillMultiTile(int x, int y, int frameX, int frameY)
        {

            int item;
            int frame = frameX / 54;

            if (frame == 0)
                item = ModContent.ItemType<Items.Garden.PottedPlants.PottedPalmCorruption>();
            else
                item = ModContent.ItemType<Items.Garden.PottedPlants.PottedPalmCrimson>();

            if (item > 0)
                Item.NewItem(new EntitySource_TileBreak(x, y), x * 16, y * 16, 48, 80, item);
        }

        public override bool CreateDust(int i, int j, ref int type)
        {
            return false;
        }
    }
}