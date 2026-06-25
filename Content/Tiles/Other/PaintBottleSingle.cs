using Microsoft.Xna.Framework;
using System.Collections.Generic;
using Terraria;
using Terraria.DataStructures;
using Terraria.Enums;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.ObjectData;
using static Terraria.ModLoader.ModContent;

namespace DragonsDecorativeMod.Content.Tiles.Other
{
    public class PaintBottleSingle : ModTile
    {
        public override void SetStaticDefaults()
        {
            Main.tileFrameImportant[Type] = true;
            Main.tileNoAttach[Type] = true;
            Main.tileLavaDeath[Type] = true;

            TileObjectData.newTile.CopyFrom(TileObjectData.Style1x1);
            TileObjectData.newTile.AnchorBottom = new AnchorData(AnchorType.Table, TileObjectData.newTile.Width, 0);
            TileObjectData.newTile.StyleHorizontal = true;

            TileObjectData.addTile(Type);

            LocalizedText name = CreateMapEntryName();
            AddMapEntry(new Color(255, 0, 0), name);
            AddMapEntry(new Color(255, 127, 0), name);
            AddMapEntry(new Color(255, 255, 0), name);
            AddMapEntry(new Color(0, 255, 0), name);
            AddMapEntry(new Color(0, 255, 255), name);
            AddMapEntry(new Color(0, 0, 255), name);
            AddMapEntry(new Color(128, 0, 255), name);
            AddMapEntry(new Color(255, 0, 255), name);
            AddMapEntry(new Color(0, 0, 0), name);
            AddMapEntry(new Color(255, 255, 255), name);

            DustType = -1;
        }

        public override ushort GetMapOption(int i, int j)
        {
            return (ushort)(Main.tile[i, j].TileFrameX / 18);
        }

        public override IEnumerable<Item> GetItemDrops(int i, int j)
        {
            yield return new Item(ItemType<Items.Placeable.Other.PaintBottleSingle>());
        }
    }
}