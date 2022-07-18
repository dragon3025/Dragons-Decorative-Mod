using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace DragonsDecorativeMod.Tiles
{
    public class FakeEnchantedSwordInStone : ModTile
	{
		public override void SetStaticDefaults()
		{
			Main.tileFrameImportant[Type] = true;
			Main.tileNoAttach[Type] = true;
			Main.tileLavaDeath[Type] = true;
			TileObjectData.newTile.CopyFrom(TileObjectData.Style3x2);
			//TileObjectData.newTile.Height = 2;
			//TileObjectData.newTile.CoordinateHeights = new int[] { 16, 16 }; //Height of each tile.
			TileObjectData.newTile.DrawYOffset = 2;
			TileObjectData.addTile(Type);
			//Main.tileLighted[Type] = true;
			ModTranslation name = CreateMapEntryName();
			name.SetDefault("Fake Enchanted Sword in Stone");
			AddMapEntry(new Color(127, 127, 127), name);
			DustType = DustID.Stone;
		}

		public override void KillMultiTile(int x, int y, int frameX, int frameY)
		{
			Item.NewItem(new EntitySource_TileBreak(x, y), x * 16, y * 16, 32, 32, ModContent.ItemType<Items.Natural.Ambient.Tile187.FakeEnchantedSwordInStone>());
		}
	}
}