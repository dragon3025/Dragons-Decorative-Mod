using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace DragonsDecorativeMod.Tiles.Garden.PottedPlants
{
    public class PottedOasisPlants : ModTile
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

        public override bool CreateDust(int i, int j, ref int type)
        {
            return false;
        }

        public override void KillMultiTile(int x, int y, int frameX, int frameY)
        {

            int item = 0;
            int frame = frameX / 54;

            if (frame == 0)
            {
                item = ModContent.ItemType<Items.Garden.PottedPlants.PottedSmallCactus>();
            }
            else if (frame == 1)
            {
                item = ModContent.ItemType<Items.Garden.PottedPlants.PottedSmallCactusHallow>();
            }
            else if (frame == 2)
            {
                item = ModContent.ItemType<Items.Garden.PottedPlants.PottedSmallCactusCrimson>();
            }
            else if (frame == 3)
            {
                item = ModContent.ItemType<Items.Garden.PottedPlants.PottedSmallCactusCorruption>();
            }
            else if (frame == 4)
            {
                item = ModContent.ItemType<Items.Garden.PottedPlants.PottedOasisPlant>();
            }
            else if (frame == 5)
            {
                item = ModContent.ItemType<Items.Garden.PottedPlants.PottedOasisPlantHallow>();
            }
            else if (frame == 6)
            {
                item = ModContent.ItemType<Items.Garden.PottedPlants.PottedOasisPlantCrimson>();
            }
            else if (frame == 7)
            {
                item = ModContent.ItemType<Items.Garden.PottedPlants.PottedOasisPlantCorruption>();
            }

            if (item > 0)
            {
                Item.NewItem(new EntitySource_TileBreak(x, y), x * 16, y * 16, 48, 64, item);
            }
        }
    }
}