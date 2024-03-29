﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace DragonsDecorativeMod.Tiles.Easter
{
    public class EasterBasket : ModTile
    {
        private Asset<Texture2D> overlayTexture;
        private Asset<Texture2D> overlayTextureNegative;

        public override void SetStaticDefaults()
        {
            Main.tileFrameImportant[Type] = true;
            Main.tileNoAttach[Type] = true;
            Main.tileLavaDeath[Type] = true;

            TileObjectData.newTile.CopyFrom(TileObjectData.Style2x2);
            TileObjectData.newTile.DrawYOffset = 2;
            TileObjectData.addTile(Type);

            LocalizedText name = CreateMapEntryName();
            // name.SetDefault("Easter Basket");
            AddMapEntry(new Color(135, 108, 50), name);

            if (!Main.dedServ)
            {
                overlayTexture = ModContent.Request<Texture2D>("DragonsDecorativeMod/Tiles/Easter/EasterBasketOverlay");
                overlayTextureNegative = ModContent.Request<Texture2D>("DragonsDecorativeMod/Tiles/Easter/EasterBasketOverlayNegative");
            }

            DustType = DustID.Grass;
            HitSound = SoundID.Grass;
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

            Color color;
            Texture2D texture;

            if (tile.TileColor == PaintID.NegativePaint)
            {
                color = new Color(255, 255, 255);
                texture = overlayTextureNegative.Value;
            }
            else
            {
                color = WorldGen.paintColor(tile.TileColor);
                texture = overlayTexture.Value;
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

            spriteBatch.Draw(texture, new Vector2(i * 16 - (int)Main.screenPosition.X, j * 16 - (int)Main.screenPosition.Y + 2) + offScreenAdjust, new Rectangle(frameX, frameY, 16, 16), color, 0f, default, 1f, SpriteEffects.None, 0f);
        }
    }
}