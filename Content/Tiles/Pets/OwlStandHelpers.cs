using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Audio;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ObjectData;

namespace DragonsDecorativeMod.Content.Tiles.Pets
{
    internal static class OwlStandHelpers
    {

        public static bool OwlAnimations(ref int frame, ref int frameCounter)
        {
            if (frame == 0)
            {
                if (!Main.rand.NextBool(180))
                {
                    return false;
                }
                int[] frameChoices = [1, 4, 7, 10, 11, 18];
                frame = frameChoices[Main.rand.Next(6)];
                return false;
            }

            if ((frame == 2 || frame == 5 || frame == 14 || frame == 21) && (!Main.rand.NextBool(60)))
            {
                return false;
            }

            frameCounter++;
            if (frameCounter <= 9)
            {
                return false;
            }

            frameCounter = 0;
            if (frame == 3 || frame == 6 || frame == 9 || frame == 10 || frame == 17 || frame == 24)
            {
                frame = 0;
            }
            else
            {
                frame++;
            }

            return true;
        }

        public static void OwlSounds(int i, int j, bool closer)
        {
            if (!Main.gamePaused && Main.instance.IsActive && closer && Main.rand.NextBool(36000)) //About 1 every 10 real minutes.
            {
                SoundEngine.PlaySound(SoundID.Owl, new Vector2(i, j).ToWorldCoordinates());
            }
        }

        internal static void SetTileInfo(ushort Type)
        {
            Main.tileFrameImportant[Type] = true;
            Main.tileNoAttach[Type] = true;
            Main.tileLavaDeath[Type] = true;

            TileObjectData.newTile.CopyFrom(TileObjectData.Style2x2);
            TileObjectData.newTile.Height = 3;
            TileObjectData.newTile.Origin = new Point16(0, 2);
            TileObjectData.newTile.CoordinateHeights = [16, 16, 16];
            TileObjectData.newTile.DrawYOffset = 2;
            TileObjectData.addTile(Type);
        }
    }
}