using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace DragonsDecorativeMod.Tiles.Natural
{
    public class PeacefulPlanteraBulb : ModTile
    {
        public override void SetStaticDefaults()
        {
            Main.tileFrameImportant[Type] = true;
            Main.tileNoAttach[Type] = true;
            Main.tileLavaDeath[Type] = true;
            Main.tileLighted[Type] = true;

            TileObjectData.newTile.CopyFrom(TileObjectData.Style2x2);
            TileObjectData.newTile.DrawYOffset = 2;
            TileObjectData.addTile(Type);

            AnimationFrameHeight = 36;

            LocalizedText name = CreateMapEntryName();
            // name.SetDefault("Peaceful Plantera Bulb");
            AddMapEntry(new Color(225, 128, 206), name);

            HitSound = SoundID.Grass;
        }

        public override bool CreateDust(int i, int j, ref int type)
        {
            return false;
        }

        public override void KillMultiTile(int i, int j, int frameX, int frameY)
        {
            for (int n = 0; n < 40; n++)
            {
                int dust = (!Main.rand.NextBool(3)) ? DustID.Plantera_Pink : DustID.Plantera_Green;
                Dust.NewDustDirect(new Vector2(i * 16, j * 16), 32, 32, dust);
            }
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

        public override void ModifyLight(int i, int j, ref float r, ref float g, ref float b)
        {
            Tile tile = Main.tile[i, j];
            if (tile.TileColor == 0)
            {
                r = 0.5f;
                g = 0f;
                b = 0.5f;
            }
            else
            {
                Color color = WorldGen.paintColor(tile.TileColor);
                r = color.R / 255f * 0.5f;
                g = color.G / 255f * 0.5f;
                b = color.B / 255f * 0.5f;
            }
        }

        public override void DrawEffects(int i, int j, SpriteBatch spriteBatch, ref TileDrawInfo drawData)
        {
            if (Main.gamePaused || !Main.instance.IsActive || Lighting.UpdateEveryFrame && !Main.rand.NextBool(4))
            {
                return;
            }

            if (Main.rand.NextBool(10))
            {
                var dust = Dust.NewDustDirect(new Vector2(i * 16, j * 16), 16, 16, DustID.PlanteraBulb, Alpha: 200);
                dust.noGravity = true;
            }
        }
    }
}