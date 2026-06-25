using Microsoft.Xna.Framework;
using System.Collections.Generic;
using Terraria;
using Terraria.DataStructures;
using Terraria.Enums;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace DragonsDecorativeMod.Content.Tiles.Other
{
    public class Shampoo : ModTile
    {
        public override void SetStaticDefaults()
        {
            Main.tileFrameImportant[Type] = true;
            Main.tileNoAttach[Type] = true;
            Main.tileLavaDeath[Type] = true;

            TileObjectData.newTile.CopyFrom(TileObjectData.Style1x1);
            TileObjectData.newTile.Height = 2;
            TileObjectData.newTile.Origin = new Point16(0, 1);
            TileObjectData.newTile.AnchorBottom = new AnchorData(AnchorType.Table, TileObjectData.newTile.Width, 0);
            TileObjectData.newTile.CoordinateHeights = [16, 16];
            TileObjectData.newTile.StyleHorizontal = true;

            TileObjectData.addTile(Type);

            LocalizedText name = CreateMapEntryName();
            AddMapEntry(new Color(255, 89, 248), name);
            AddMapEntry(new Color(255, 89, 132), name);
            AddMapEntry(new Color(255, 118, 89), name);
            AddMapEntry(new Color(255, 182, 89), name);
            AddMapEntry(new Color(89, 255, 179), name);
            AddMapEntry(new Color(89, 215, 255), name);
            AddMapEntry(new Color(89, 143, 255), name);
            AddMapEntry(new Color(99, 89, 255), name);

            DustType = -1;
        }

        public override ushort GetMapOption(int i, int j)
        {
            return (ushort)(Main.tile[i, j].TileFrameX / 18);
        }

        public override IEnumerable<Item> GetItemDrops(int i, int j)
        {
            yield return new Item(ModContent.ItemType<Items.Placeable.Other.Shampoo>());
        }
    }
}