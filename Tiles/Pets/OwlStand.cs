using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Audio;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace DragonsDecorativeMod.Tiles.Pets
{
    public class OwlStand : ModTile
    {
        public override void SetStaticDefaults()
        {
            Main.tileFrameImportant[Type] = true;
            Main.tileNoAttach[Type] = true;
            Main.tileLavaDeath[Type] = true;

            TileObjectData.newTile.CopyFrom(TileObjectData.Style2x2);
            TileObjectData.newTile.Height = 3;
            TileObjectData.newTile.Origin = new Point16(0, 2);
            TileObjectData.newTile.CoordinateHeights = new int[3] { 16, 16, 16 };
            TileObjectData.newTile.DrawYOffset = 2;
            TileObjectData.addTile(Type);

            AnimationFrameHeight = 54;

            LocalizedText name = CreateMapEntryName();
            AddMapEntry(new Color(153, 103, 75), name);
        }

        public override bool CreateDust(int i, int j, ref int type)
        {
            return false;
        }

        public override void NearbyEffects(int i, int j, bool closer)
        {
            if (closer && Main.rand.NextBool(36000)) //About 1 every 10 real minutes.
            {
                SoundEngine.PlaySound(SoundID.Owl, new Vector2(i, j).ToWorldCoordinates());
            }
        }

        public override void AnimateTile(ref int frame, ref int frameCounter)
        {
            if (frame == 0)
            {
                if (Main.rand.NextBool(180))
                {
                    int[] frameChoices = new int[6]
                    {
                        1,
                        4,
                        7,
                        10,
                        11,
                        18
                    };
                    frame = frameChoices[Main.rand.Next(6)];
                }
                else
                {
                    return;
                }
            }
            else
            {
                if ((frame == 2 || frame == 5 || frame == 14 || frame == 21) && (!Main.rand.NextBool(60)))
                {
                    return;
                }
                else
                {
                    frameCounter++;
                    if (frameCounter > 9)
                    {
                        frameCounter = 0;
                        if (frame == 3 || frame == 6 || frame == 9 || frame == 10 || frame == 17 || frame == 24)
                        {
                            frame = 0;
                        }
                        else
                        {
                            frame++;
                        }
                    } 
                }
            }
        }
    }
}