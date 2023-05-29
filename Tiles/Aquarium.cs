using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.ObjectData;

//TO-DO When 1.4.4 comes out for tModLoader, use the same graphic stretch affect that Terrariums have.

namespace DragonsDecorativeMod.Tiles
{
    public class Aquarium : ModTile
    {
        public override void SetStaticDefaults()
        {
            TileID.Sets.CritterCageLidStyle[Type] = 2; //Match Bunny Cage because it's also 6x3. It's the second in the array in TileID.cs > CritterCageLidStyle line 178
            Main.critterCage = true;
            Main.tileSolidTop[Type] = true;
            Main.tileTable[Type] = true;
            Main.tileLavaDeath[Type] = true;
            Main.tileFrameImportant[Type] = true;

            TileObjectData.newTile.CopyFrom(TileObjectData.Style6x3);
            TileObjectData.addTile(Type);

            LocalizedText name = CreateMapEntryName();
            AddMapEntry(new Color(122, 217, 232), name);

            AnimationFrameHeight = 54;
            DustType = DustID.Water;
        }

        public override void KillMultiTile(int i, int j, int frameX, int frameY)
        {
            for (int n = 0; n < 30; n++)
            {
                Dust.NewDustDirect(new Vector2(i * 16, j * 16), 96, 48, DustID.Glass);
            }
        }

        public override void AnimateTile(ref int frame, ref int frameCounter)
        {
            frameCounter++;
            if (frameCounter >= 20)
            {
                frameCounter = 0;
                frame++;
                frame %= 22;
            }
        }

        public override void SetDrawPositions(int i, int j, ref int width, ref int offsetY, ref int height, ref short tileFrameX, ref short tileFrameY)
        {
            offsetY = 2;
        }
    }
}