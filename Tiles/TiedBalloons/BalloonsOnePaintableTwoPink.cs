using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria;
using Terraria.DataStructures;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace DragonsDecorativeMod.Tiles.TiedBalloons
{
    public class BalloonsOnePaintableTwoPink : ModTile
    {
        private Asset<Texture2D> overlayTexture;

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

            AddMapEntry(new Color(255, 0, 255));

            AnimationFrameHeight = 54;

            if (!Main.dedServ)
            {
                overlayTexture = ModContent.Request<Texture2D>("DragonsDecorativeMod/Tiles/TiedBalloons/BalloonsOnePaintableTwoPinkOverlay");
            }
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

        public override void PostDraw(int i, int j, SpriteBatch spriteBatch)
        {
            Vector2 offScreenAdjust = new(Main.offScreenRange, Main.offScreenRange);

            if (Main.drawToScreen)
            {
                offScreenAdjust = Vector2.Zero;
            }

            Color color = Lighting.GetColor(i, j);

            Tile tile = Main.tile[i, j];
            short frameX = tile.TileFrameX;
            short frameY = tile.TileFrameY;

            // Offset along the Y axis depending on the current frame
            int frameYOffset = Main.tileFrame[Type] * AnimationFrameHeight;

            Texture2D texture = overlayTexture.Value;

            spriteBatch.Draw(texture, new Vector2(i * 16 - (int)Main.screenPosition.X, j * 16 - (int)Main.screenPosition.Y) + offScreenAdjust, new Rectangle(frameX, frameY + frameYOffset, 16, 16), color, 0f, default, 1f, SpriteEffects.None, 0f);
        }
    }
}