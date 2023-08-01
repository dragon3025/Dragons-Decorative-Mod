using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace DragonsDecorativeMod.Tiles.Natural
{
    public class FakeLarva : ModTile
    {
        public override void SetStaticDefaults()
        {
            Main.tileFrameImportant[Type] = true;
            Main.tileNoAttach[Type] = true;
            Main.tileLavaDeath[Type] = true;

            TileObjectData.newTile.CopyFrom(TileObjectData.Style3x3);
            TileObjectData.newTile.DrawYOffset = 2;
            TileObjectData.addTile(Type);

            AnimationFrameHeight = 54;

            LocalizedText name = CreateMapEntryName();
            AddMapEntry(new Color(224, 194, 101), name);
            HitSound = SoundID.NPCDeath1;
        }

        public override bool CreateDust(int i, int j, ref int type)
        {
            return false;
        }

        public override void KillMultiTile(int i, int j, int frameX, int frameY)
        {
            for (int n = 0; n < 90; n++)
            {
                int dust = 153;
                if (Main.rand.NextBool(3))
                {
                    dust = 26;
                }
                Dust.NewDustDirect(new Vector2(i * 16, j * 16), 48, 48, dust);
            }
            Gore.NewGore(WorldGen.GetItemSource_FromTileBreak(i, j), new Vector2(i * 16, j * 16), default, 300);
            Gore.NewGore(WorldGen.GetItemSource_FromTileBreak(i, j), new Vector2(i * 16, j * 16), default, 301);
            Gore.NewGore(WorldGen.GetItemSource_FromTileBreak(i, j), new Vector2(i * 16, j * 16), default, 302);
        }

        public override void AnimateTile(ref int frame, ref int frameCounter)
        {
            frameCounter++;
            if (frameCounter >= 20)
            {
                frameCounter = 0;
                frame++;
                frame %= 4;
            }
        }
    }
}