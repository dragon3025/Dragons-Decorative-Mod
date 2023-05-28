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
    public class FakeCrimsonHeart : ModTile
    {
        public override void SetStaticDefaults()
        {
            Main.tileFrameImportant[Type] = true;
            Main.tileNoAttach[Type] = true;
            Main.tileLavaDeath[Type] = true;
            Main.tileLighted[Type] = true;

            TileObjectData.newTile.CopyFrom(TileObjectData.Style2x2);
            TileObjectData.newTile.AnchorBottom = AnchorData.Empty;
            TileObjectData.addTile(Type);

            LocalizedText name = CreateMapEntryName();
            // name.SetDefault("Fake Crimson Heart");
            AddMapEntry(new Color(212, 105, 105), name);

            AnimationFrameHeight = 36;

            HitSound = SoundID.NPCDeath1;
            DustType = DustID.Crimstone;
        }

        public override void ModifyLight(int i, int j, ref float r, ref float g, ref float b)
        {
            Tile tile = Main.tile[i, j];
            if (tile.TileColor == 0)
            {
                float variance = Main.rand.Next(-5, 6) * 0.0025f;
                r = 0.5f + variance * 2f;
                g = 0.2f + variance;
                b = 0.1f;
            }
            else
            {
                Color color = WorldGen.paintColor(tile.TileColor);
                r = color.R / 255f * 0.53f;
                g = color.G / 255f * 0.53f;
                b = color.B / 255f * 0.53f;
            }
        }

        public override void AnimateTile(ref int frame, ref int frameCounter)
        {
            frameCounter++;
            if (frameCounter >= 20)
            {
                frameCounter = 0;
                frame++;
                frame %= 2;
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
                var dust = Dust.NewDustDirect(new Vector2(i * 16, j * 16), 16, 16, DustID.Crimstone);
                dust.noGravity = true;
            }
        }
    }
}