using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.Enums;
using Terraria.ModLoader;
using Terraria.ObjectData;
using Terraria.DataStructures;

namespace DragonsDecorativeMod.Tiles.Botanic
{
	public class SingleTilePlant : ModTile
	{
		public override void SetStaticDefaults()
		{
			Main.tileFrameImportant[Type] = true;
			Main.tileLavaDeath[Type] = true;
			Main.tileTable[Type] = true;

            TileObjectData.newTile.CopyFrom(TileObjectData.Style1x1);
            TileObjectData.newTile.AnchorBottom = new AnchorData(AnchorType.SolidTile | AnchorType.SolidWithTop | AnchorType.Table | AnchorType.SolidSide, TileObjectData.newTile.Width, 0);
            TileObjectData.newTile.CoordinateHeights = new int[1] { 48 };
            TileObjectData.newTile.CoordinateWidth = 32;
            TileObjectData.newTile.DrawYOffset = -30;
            TileObjectData.newTile.StyleHorizontal = true;
            TileObjectData.addTile(Type);

            ModTranslation name = CreateMapEntryName();
			name.SetDefault("Plant");
			AddMapEntry(new Color(18, 86, 30), name);
        }

        public override bool Drop(int i, int j)
        {
            Tile t = Main.tile[i, j];
            int frame = t.TileFrameX / 34;
            int item = 0;

            if (frame == 0)
                item = ModContent.ItemType<Items.Botanic.SingleTilePlant>();
            else if (frame == 1)
                item = ModContent.ItemType<Items.Botanic.SingleTilePlant2>();
            else if (frame == 2)
                item = ModContent.ItemType<Items.Botanic.SingleTilePlant3>();
            else if (frame == 3)
                item = ModContent.ItemType<Items.Botanic.SingleTilePlant4>();

            if (item > 0)
                Item.NewItem(new EntitySource_TileBreak(i, j), i * 16, j * 16, 32, 48, item);

            return base.Drop(i, j);
        }
    }
}