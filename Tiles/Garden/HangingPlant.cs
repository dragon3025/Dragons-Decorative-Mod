using Microsoft.Xna.Framework;
using System.Collections.Generic;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace DragonsDecorativeMod.Tiles.Garden
{
    public class HangingPlant : ModTile
    {
        public override void SetStaticDefaults()
        {
            Main.tileFrameImportant[Type] = true;
            Main.tileLavaDeath[Type] = true;
            Main.tileNoAttach[Type] = true;

            TileObjectData.newTile.CopyFrom(TileObjectData.Style1x2Top);
            TileObjectData.newTile.DrawYOffset = -2;
            TileObjectData.newTile.Width = 2;
            TileObjectData.newTile.Height = 3;
            TileObjectData.newTile.CoordinateHeights = new int[3] { 16, 16, 16 };
            TileObjectData.newTile.StyleHorizontal = true;
            TileObjectData.addTile(Type);

            AddMapEntry(new Color(101, 110, 86));
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
                yield return new Item(ModContent.ItemType<Items.Garden.HangingPlant>());
            }
            else if (style == 1)
            {
                yield return new Item(ModContent.ItemType<Items.Garden.HangingLeafyPlant>());
            }
            else
            {
                yield return new Item(ModContent.ItemType<Items.Garden.HangingFernPlant>());
            }
        }
    }
}