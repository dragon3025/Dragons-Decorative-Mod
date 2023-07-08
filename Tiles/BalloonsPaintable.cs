using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace DragonsDecorativeMod.Tiles
{
    public class BalloonsPaintable : ModTile
    {
        private Asset<Texture2D> overlayTextureStrings;
        private Asset<Texture2D> overlayTextureBack;
        private Asset<Texture2D> overlayTextureFront;
        private Asset<Texture2D> overlayTextureBackNegative;
        private Asset<Texture2D> overlayTextureFrontNegative;

        public override void SetStaticDefaults()
        {
            Main.tileFrameImportant[Type] = true;
            Main.tileLavaDeath[Type] = true;
            Main.tileNoAttach[Type] = true;


            TileObjectData.newTile.CopyFrom(TileObjectData.Style2x2);
            TileObjectData.newTile.Height = 3;
            TileObjectData.newTile.Origin = new Point16(0, 2);
            TileObjectData.newTile.CoordinateHeights = new int[3] { 16, 16, 16 };
            TileObjectData.addTile(Type);

            AddMapEntry(new Color(255, 0, 0));

            AnimationFrameHeight = 54;

            if (!Main.dedServ)
            {
                overlayTextureStrings = ModContent.Request<Texture2D>("DragonsDecorativeMod/Tiles/BalloonsPaintableStrings");
                overlayTextureBack = ModContent.Request<Texture2D>("DragonsDecorativeMod/Tiles/BalloonsPaintableBack");
                overlayTextureFront = ModContent.Request<Texture2D>("DragonsDecorativeMod/Tiles/BalloonsPaintableFront");
                overlayTextureBackNegative = ModContent.Request<Texture2D>("DragonsDecorativeMod/Tiles/BalloonsPaintableBackNegative");
                overlayTextureFrontNegative = ModContent.Request<Texture2D>("DragonsDecorativeMod/Tiles/BalloonsPaintableFrontNegative");
            }
        }

        public override bool CreateDust(int i, int j, ref int type)
        {
            return false;
        }

        public override void AnimateTile(ref int frame, ref int frameCounter)
        {
            frameCounter++;
            if (frameCounter >= 10)
            {
                frameCounter = 0;
                frame++;
                frame %= 4;
            }
        }

        public override bool PreDraw(int i, int j, SpriteBatch spriteBatch)
        {
            return false;
        }

        public override void PostDraw(int i, int j, SpriteBatch spriteBatch)
        {
            Tile tile = Main.tile[i, j];

            if (tile.IsTileInvisible && !Main.ShouldShowInvisibleWalls())
            {
                return;
            }

            Vector2 offScreenAdjust = new(Main.offScreenRange, Main.offScreenRange);

            if (Main.drawToScreen)
            {
                offScreenAdjust = Vector2.Zero;
            }

            Texture2D textureStrings = overlayTextureStrings.Value;
            Texture2D textureBack;
            Texture2D textureFront;

            if (tile.TileColor == PaintID.NegativePaint)
            {
                textureBack = overlayTextureBackNegative.Value;
                textureFront = overlayTextureFrontNegative.Value;
            }
            else
            {
                textureBack = overlayTextureBack.Value;
                textureFront = overlayTextureFront.Value;
            }

            Color color;
            Color colorString = Lighting.GetColor(i, j);

            if (tile.TileColor == PaintID.NegativePaint)
            {
                color = new Color(255, 255, 255);
            }
            else
            {
                color = WorldGen.paintColor(tile.TileColor);
            }

            if (!tile.IsTileFullbright)
            {
                Color colorLight = Lighting.GetColor(i, j);
                if (color.R > colorLight.R)
                {
                    color.R = colorLight.R;
                }
                if (color.G > colorLight.G)
                {
                    color.G = colorLight.G;
                }
                if (color.B > colorLight.B)
                {
                    color.B = colorLight.B;
                }
            }

            short frameX = tile.TileFrameX;
            short frameY = tile.TileFrameY;
            int frameXSegment = frameX / 18;
            int frameYSegment = frameY / 18;

            // Offset along the Y axis depending on the current frame
            int frameYOffset = Main.tileFrame[Type] * AnimationFrameHeight;

            void drawTexture(Texture2D texture, Color color, int xOffset = 0, int yOffset = 0)
            {
                spriteBatch.Draw(texture, new Vector2(i * 16 - (int)Main.screenPosition.X + xOffset * 16, j * 16 - (int)Main.screenPosition.Y + yOffset * 16) + offScreenAdjust, new Rectangle(frameX + xOffset * 18, frameY + frameYOffset + yOffset * 18, 16, 16), color, 0f, default, 1f, SpriteEffects.None, 0f);
            }

            drawTexture(textureStrings, colorString);

            if (frameXSegment == 0 && frameYSegment == 2)
            {
                for (int k = 0; k < 2; k++)
                {
                    for (int l = -2; l < 1; l++)
                    {
                        drawTexture(textureFront, color, k, l);
                    }
                }
            }
            else
            {
                drawTexture(textureBack, color);
            }
        }
    }
}