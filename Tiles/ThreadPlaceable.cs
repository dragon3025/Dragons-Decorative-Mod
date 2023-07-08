using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace DragonsDecorativeMod.Tiles
{
    public class ThreadPlaceable : ModTile
    {
        private Asset<Texture2D> overlayTexture;
        private Asset<Texture2D> overlayTextureNegative;

        public override void SetStaticDefaults()
        {
            Main.tileFrameImportant[Type] = true;
            Main.tileLavaDeath[Type] = true;
            Main.tileNoAttach[Type] = true;

            TileObjectData.newTile.CopyFrom(TileObjectData.Style2x2);
            TileObjectData.addTile(Type);

            AddMapEntry(new Color(255, 0, 0));

            if (!Main.dedServ)
            {
                overlayTexture = ModContent.Request<Texture2D>("DragonsDecorativeMod/Tiles/ThreadPlaceableOverlay");
                overlayTextureNegative = ModContent.Request<Texture2D>("DragonsDecorativeMod/Tiles/ThreadPlaceableOverlayNegative");
            }
        }

        public override bool CreateDust(int i, int j, ref int type)
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

            Color color = Lighting.GetColor(i, j);
            short frameX = tile.TileFrameX;
            short frameY = tile.TileFrameY;

            Texture2D texture;

            if (tile.TileColor == PaintID.NegativePaint)
            {
                texture = overlayTextureNegative.Value;
            }
            else
            {
                texture = overlayTexture.Value;
            }

            spriteBatch.Draw(texture, new Vector2(i * 16 - (int)Main.screenPosition.X, j * 16 - (int)Main.screenPosition.Y) + offScreenAdjust, new Rectangle(frameX, frameY, 16, 16), color, 0f, default, 1f, SpriteEffects.None, 0f);
        }
    }
}