using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
using Terraria.ObjectData;
using Terraria.DataStructures;

namespace DragonsDecorativeMod.Tiles.Natural.Ambient
{
    public class MediumD : ModTile
    {
        public override void SetStaticDefaults()
        {
            Main.tileFrameImportant[Type] = true;
            Main.tileNoAttach[Type] = true;
            Main.tileLavaDeath[Type] = true;

            TileObjectData.newTile.CopyFrom(TileObjectData.Style2x1);
            TileObjectData.newTile.DrawYOffset = 2;
            TileObjectData.addTile(Type);

            AddMapEntry(new Color(127, 127, 127));
        }

        public override void KillMultiTile(int x, int y, int frameX, int frameY)
        {

            int item = 0;
            int frame = frameX / 36;

            if (frame <= 5)
                item = ModContent.ItemType<Items.Natural.Ambient.MediumD.SmallMarbleRocks>();
            else if (frame <= 8)
                item = ModContent.ItemType<Items.Natural.Ambient.MediumD.SmallLivingWoodRoots>();
            else if (frame <= 11)
                item = ModContent.ItemType<Items.Natural.Ambient.MediumD.SmallSandPiles>();

            if (item > 0)
                Item.NewItem(new EntitySource_TileBreak(x, y), x * 16, y * 16, 32, 16, item);
        }
    }
}