using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace DragonsDecorativeMod.Walls
{
	public class Trellis : ModWall
	{
		public override void SetStaticDefaults()
		{
			Main.wallLight[Type] = true;
			Main.wallHouse[Type] = true;
			DustType = DustID.WoodFurniture;
			ItemDrop = ModContent.ItemType<Items.Garden.Trellis>();
			AddMapEntry(new Color(127, 97, 63));
		}
	}
}