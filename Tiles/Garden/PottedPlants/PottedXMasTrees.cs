using Microsoft.Xna.Framework;
using System.Collections.Generic;
using Terraria;
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

            AddMapEntry(new Color(120, 110, 100));
        }

        public override IEnumerable<Item> GetItemDrops(int i, int j)
        {
            Tile tile = Main.tile[i, j];
            int style = TileObjectData.GetTileStyle(tile);

            if (style == 0)
            {
                yield return new Item(ModContent.ItemType<Items.Garden.PottedPlants.PottedXMasTree>());
            }
            else
            {
                yield return new Item(ModContent.ItemType<Items.Garden.PottedPlants.PottedXMasTreeSnowy>());
            }
        }

        public override bool CreateDust(int i, int j, ref int type)
        {
            return false;
        }
    }
}