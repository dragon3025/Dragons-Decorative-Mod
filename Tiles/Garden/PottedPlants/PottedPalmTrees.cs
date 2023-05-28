using Microsoft.Xna.Framework;
using System.Collections.Generic;
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
            TileObjectData.newTile.CoordinateHeights = new int[6] { 16, 16, 16, 16, 16, 16 };
            TileObjectData.newTile.DrawYOffset = 2;
            TileObjectData.addTile(Type);

            AddMapEntry(new Color(120, 110, 100));
        }

        public override IEnumerable<Item> GetItemDrops(int i, int j)
        {
            Tile tile = Main.tile[i, j];
            int style = TileObjectData.GetTileStyle(tile);

            if (style == 0)
            {
                yield return new Item(ModContent.ItemType<Items.Garden.PottedPlants.PottedPalmCorruption>());
            }
            else
            {
                yield return new Item(ModContent.ItemType<Items.Garden.PottedPlants.PottedPalmCrimson>());
            }
        }

        public override bool CreateDust(int i, int j, ref int type)
        {
            return false;
        }
    }
}