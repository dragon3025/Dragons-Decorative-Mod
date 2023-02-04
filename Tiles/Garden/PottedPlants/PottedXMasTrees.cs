using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace DragonsDecorativeMod.Tiles.Garden.PottedPlants
{
    public class PottedXMasTrees : ModTile
    {
        public override void SetStaticDefaults()
        {
            Main.tileFrameImportant[Type] = true;
            Main.tileLavaDeath[Type] = true;
            Main.tileNoAttach[Type] = true;

            TileObjectData.newTile.CopyFrom(TileObjectData.Style3x4);
            TileObjectData.newTile.DrawYOffset = 2;
            TileObjectData.addTile(Type);

            AddMapEntry(new Color(127, 127, 127));
        }

        public override void KillMultiTile(int x, int y, int frameX, int frameY)
        {
            int item;
            int frame = frameX / 54;

            if (frame == 0)
            {
                item = ModContent.ItemType<Items.Garden.PottedPlants.PottedXMasTree>();
            }
            else
            {
                item = ModContent.ItemType<Items.Garden.PottedPlants.PottedXMasTreeSnowy>();
            }

            if (item > 0)
            {
                Item.NewItem(new EntitySource_TileBreak(x, y), x * 16, y * 16, 48, 80, item);
            }
        }

        public override bool CreateDust(int i, int j, ref int type)
        {
            return false;
        }
    }
}