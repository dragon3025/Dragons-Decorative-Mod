using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;
using Terraria.DataStructures;

namespace DragonsDecor.Tiles
{
    public class Aquarium : ModTile
	{
		public override void SetStaticDefaults()
		{
			Main.tileFrameImportant[Type] = true;
			Main.tileNoAttach[Type] = true;
			Main.tileLavaDeath[Type] = true;
			TileObjectData.newTile.CopyFrom(TileObjectData.Style6x3);
			TileObjectData.addTile(Type);
			AnimationFrameHeight = 54;
			//Main.tileLighted[Type] = true;
			ModTranslation name = CreateMapEntryName();
			name.SetDefault("Aquarium");
			AddMapEntry(new Color(127, 127, 255), name);
			DustType = DustID.Water;
		}

		public override void AnimateTile(ref int frame, ref int frameCounter)
		{
			frameCounter++;
			if (frameCounter >= 20)
			{
				frameCounter = 0;
				frame++;
				frame %= 21;
			}
		}

		public override void KillMultiTile(int x, int y, int frameX, int frameY)
		{
			Item.NewItem(new EntitySource_TileBreak(x, y), x * 16, y * 16, 32, 32, ModContent.ItemType<Items.Aquarium>());
		}
	}
}