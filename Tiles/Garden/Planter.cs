using Microsoft.Xna.Framework;
using System.Collections.Generic;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace DragonsDecorativeMod.Tiles.Garden
{
    public class Planter : ModTile
    {
        public override void SetStaticDefaults()
        {
            Main.tileFrameImportant[Type] = true;
            Main.tileLavaDeath[Type] = true;
            Main.tileTable[Type] = true;

            TileObjectData.newTile.CopyFrom(TileObjectData.Style2x1);
            TileObjectData.newTile.Height = 1;
            TileObjectData.newTile.CoordinateHeights = new int[1] { 20 };
            TileObjectData.newTile.StyleHorizontal = true;
            TileObjectData.newTile.DrawYOffset = -2;
            TileObjectData.addTile(Type);

            LocalizedText name = CreateMapEntryName();
            // name.SetDefault("Planter");
            AddMapEntry(new Color(99, 89, 81), name);

            DustType = DustID.Clay;
        }

        public override IEnumerable<Item> GetItemDrops(int i, int j)
        {
            Tile tile = Main.tile[i, j];
            int style = TileObjectData.GetTileStyle(tile);

            if (style == 0)
            {
                yield return new Item(ModContent.ItemType<Items.Garden.Planter>());
            }
            else
            {
                yield return new Item(ModContent.ItemType<Items.Garden.Planter2>());
            }
        }
    }
}