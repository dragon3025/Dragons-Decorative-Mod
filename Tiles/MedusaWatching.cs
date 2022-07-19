using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace DragonsDecorativeMod.Tiles
{
    public class MedusaWatching : ModTile
	{
		public override void SetStaticDefaults()
		{
			Main.tileFrameImportant[Type] = true;
			Main.tileNoAttach[Type] = true;
			Main.tileLavaDeath[Type] = true;

			TileObjectData.newTile.CopyFrom(TileObjectData.Style3x3Wall);
			TileObjectData.newTile.Height = 4;
			TileObjectData.newTile.CoordinateHeights = new int[] { 16, 16, 16, 16 }; //Height of each tile.
			TileObjectData.addTile(Type);

			AnimationFrameHeight = 72;
			Main.tileLighted[Type] = true;

			ModTranslation name = CreateMapEntryName();
			name.SetDefault("Medusa Watching");
			AddMapEntry(new Color(58, 62, 53), name);
		}

		int look_direction = 0;

		public override void NearbyEffects(int i, int j, bool closer)
		{
			if (closer)
			{
				float distance = 0f;
				Vector2 position = new Vector2(i, j);
				int target = 0;
				if (closer)
				{
					for (int k = 0; k < 255; k++)
					{
						if (!Main.player[k].active)
							continue;

						if (distance == 0f || position.Distance(Main.player[k].Center) < distance)
						{
							distance = position.Distance(Main.player[k].Center);
							target = k;
						}
					}

					Player player = Main.player[target];
					float tile_centerx = 1.5f;
					if (player.position.X / 16 > i - tile_centerx + 6.5f)
						look_direction = 1;
					else if (player.position.X / 16 < i - tile_centerx - 6.5f)
						look_direction = 2;
					else
						look_direction = 0;
				}
			}
		}

		public override void AnimateTile(ref int frame, ref int frameCounter)
		{
			frame = look_direction;
		}

		public override void KillMultiTile(int x, int y, int frameX, int frameY)
		{
			Item.NewItem(new EntitySource_TileBreak(x, y), x * 16, y * 16, 32, 32, ModContent.ItemType<Items.MedusaWatching>());
		}
	}
}