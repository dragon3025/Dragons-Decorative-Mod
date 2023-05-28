using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.Enums;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace DragonsDecorativeMod.Tiles
{
    public class PureSpiritLamp : ModTile
    {
        public override void SetStaticDefaults()
        {
            Main.tileFrameImportant[Type] = true;
            Main.tileNoAttach[Type] = true;
            Main.tileLavaDeath[Type] = true;

            TileObjectData.newTile.CopyFrom(TileObjectData.Style2x2);
            TileObjectData.newTile.CoordinateHeights = new int[2] { 16, 16 };
            TileObjectData.newTile.AnchorBottom = new AnchorData(AnchorType.Table, TileObjectData.newTile.Width, 0);
            TileObjectData.addTile(Type);

            AnimationFrameHeight = 36;

            AddMapEntry(new Color(168, 145, 127));
        }

        public override void AnimateTile(ref int frame, ref int frameCounter)
        {
            if (frame == 0 && frameCounter == 0 && !Main.rand.NextBool(1800)) //30 Real-Life Seconds.
            {
                return;
            }

            frameCounter++;
            if (frameCounter > 9)
            {
                frameCounter = 0;
                frame++;
                frame %= 11;
            }
        }
    }
}