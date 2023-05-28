using Microsoft.Xna.Framework;
using System.Collections.Generic;
using Terraria;
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

        public override IEnumerable<Item> GetItemDrops(int i, int j)
        {
            Tile tile = Main.tile[i, j];
            int style = TileObjectData.GetTileStyle(tile);

            if (style == 0)
            {
                yield return new Item(ModContent.ItemType<Items.Garden.PottedPlants.PottedSmallCactus>());
            }
            else if (style == 1)
            {
                yield return new Item(ModContent.ItemType<Items.Garden.PottedPlants.PottedSmallCactusHallow>());
            }
            else if (style == 2)
            {
                yield return new Item(ModContent.ItemType<Items.Garden.PottedPlants.PottedSmallCactusCrimson>());
            }
            else if (style == 3)
            {
                yield return new Item(ModContent.ItemType<Items.Garden.PottedPlants.PottedSmallCactusCorruption>());
            }
            else if (style == 4)
            {
                yield return new Item(ModContent.ItemType<Items.Garden.PottedPlants.PottedOasisPlant>());
            }
            else if (style == 5)
            {
                yield return new Item(ModContent.ItemType<Items.Garden.PottedPlants.PottedOasisPlantHallow>());
            }
            else if (style == 6)
            {
                yield return new Item(ModContent.ItemType<Items.Garden.PottedPlants.PottedOasisPlantCrimson>());
            }
            else if (style == 7)
            {
                yield return new Item(ModContent.ItemType<Items.Garden.PottedPlants.PottedOasisPlantCorruption>());
            }
        }
    }
}