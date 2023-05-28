using Microsoft.Xna.Framework;
using System.Collections.Generic;
using Terraria;
using Terraria.DataStructures;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace DragonsDecorativeMod.Tiles.Garden.PottedPlants
{
    public class PottedTrees : ModTile
    {
        public override void SetStaticDefaults()
        {
            Main.tileFrameImportant[Type] = true;
            Main.tileLavaDeath[Type] = true;
            Main.tileNoAttach[Type] = true;

            TileObjectData.newTile.CopyFrom(TileObjectData.Style2xX);
            TileObjectData.newTile.Height = 5;
            TileObjectData.newTile.Origin = new Point16(1, 4);
            TileObjectData.newTile.CoordinateHeights = new int[5] { 16, 16, 16, 16, 16 };
            TileObjectData.newTile.DrawYOffset = 2;
            TileObjectData.addTile(Type);

            AddMapEntry(new Color(120, 110, 100));
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
                yield return new Item(ModContent.ItemType<Items.Garden.PottedPlants.PottedCedarSnowy>());
            }

            if (style == 1)
            {
                yield return new Item(ModContent.ItemType<Items.Garden.PottedPlants.PottedTreeSnowy>());
            }
            else if (style == 2)
            {
                yield return new Item(ModContent.ItemType<Items.Garden.PottedPlants.PottedCedarCorruption>());
            }
            else if (style == 3)
            {
                yield return new Item(ModContent.ItemType<Items.Garden.PottedPlants.PottedTreeCorruption>());
            }
            else if (style == 4)
            {
                yield return new Item(ModContent.ItemType<Items.Garden.PottedPlants.PottedCedarCrimson>());
            }
            else if (style == 5)
            {
                yield return new Item(ModContent.ItemType<Items.Garden.PottedPlants.PottedTreeCrimson>());
            }
        }
    }
}