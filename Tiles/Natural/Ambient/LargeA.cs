using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
using Terraria.ObjectData;
using Terraria.DataStructures;
using Terraria.Enums;

namespace DragonsDecorativeMod.Tiles.Natural.Ambient
{
    public class LargeA : ModTile
    {
        public override void SetStaticDefaults()
        {
            Main.tileFrameImportant[Type] = true;
            Main.tileNoAttach[Type] = true;
            Main.tileLavaDeath[Type] = true;
            Main.tileLighted[Type] = true;

            TileObjectData.newTile.CopyFrom(TileObjectData.Style3x2);
            TileObjectData.newTile.DrawYOffset = 2;
            TileObjectData.newTile.AnchorBottom = new AnchorData(AnchorType.SolidTile, TileObjectData.newTile.Width, 0);
            TileObjectData.newTile.StyleHorizontal = true;
            TileObjectData.newTile.StyleWrapLimit = 54;
            TileObjectData.addTile(Type);

            AddMapEntry(new Color(127, 127, 127));
        }

        public override void KillMultiTile(int x, int y, int frameX, int frameY)
        {

            int item = 0;
            int frame = frameX / 54;

            if (frame <= 5)
                item = ModContent.ItemType<Items.Natural.Ambient.LargeA.GraniteRock>();
            else if (frame <= 11)
                item = ModContent.ItemType<Items.Natural.Ambient.LargeA.MarbleRock>();
            else if (frame <= 14)
                item = ModContent.ItemType<Items.Natural.Ambient.LargeA.LivingWoodRoots>();
            else if (frame <= 16)
                item = ModContent.ItemType<Items.Natural.Ambient.LargeA.LivingLeafBushes>();
            else if (frame <= 19)
                item = ModContent.ItemType<Items.Natural.Ambient.LargeA.AnimalBones>();

            if (item > 0)
                Item.NewItem(new EntitySource_TileBreak(x, y), x * 16, y * 16, 54, 32, item);
        }
    }
}