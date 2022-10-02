using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace DragonsDecorativeMod.Tiles
{
    public class Easel : ModTile
	{
		public override void SetStaticDefaults()
		{
			Main.tileFrameImportant[Type] = true;
			Main.tileNoAttach[Type] = true;
			Main.tileLavaDeath[Type] = true;

			//newTile.Width = 2;
			//newTile.Height = 3;
			//newTile.Origin = new Point16(1, 2);
			//newTile.AnchorBottom = new AnchorData(AnchorType.SolidTile | AnchorType.SolidWithTop | AnchorType.SolidSide, newTile.Width, 0);
			//newTile.UsesCustomCanPlace = true;
			//newTile.CoordinateHeights = new int[3] { 16, 16, 16 };
			//newTile.CoordinateWidth = 16;
			//newTile.CoordinatePadding = 2;
			//newTile.StyleHorizontal = true;
			//addBaseTile(out Style2xX);

			TileObjectData.newTile.CopyFrom(TileObjectData.Style2xX);
			TileObjectData.addTile(Type);

			ModTranslation name = CreateMapEntryName();
			name.SetDefault("Easel");
			AddMapEntry(new Color(230, 219, 212), name);
		}

		public override void KillMultiTile(int x, int y, int frameX, int frameY)
		{
			Item.NewItem(new EntitySource_TileBreak(x, y), x * 16, y * 16, 32, 32, ModContent.ItemType<Items.Easel>());
		}
	}
}