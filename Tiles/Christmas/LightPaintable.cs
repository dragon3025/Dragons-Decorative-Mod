using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using System.Collections.Generic;
using Terraria;
using Terraria.DataStructures;
using Terraria.Enums;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;
using static Terraria.ModLoader.ModContent;

namespace DragonsDecorativeMod.Tiles.Christmas
{
    public class LightPaintable : ModTile
    {
        private Asset<Texture2D> overlayTexture;

        public override void SetStaticDefaults()
        {
            Main.tileFrameImportant[Type] = true;
            Main.tileNoAttach[Type] = true;
            Main.tileLavaDeath[Type] = true;
            Main.tileLighted[Type] = true;

            // Defaults
            TileObjectData.newTile.CopyFrom(TileObjectData.Style1x1);
            TileObjectData.newTile.StyleHorizontal = true;
            TileObjectData.newTile.StyleWrapLimit = 2;

            // Allow hanging from ceilings
            TileObjectData.newAlternate.CopyFrom(TileObjectData.newTile);
            TileObjectData.newAlternate.AnchorLeft = AnchorData.Empty;
            TileObjectData.newAlternate.AnchorRight = AnchorData.Empty;
            TileObjectData.newAlternate.AnchorTop = new AnchorData(AnchorType.SolidTile | AnchorType.SolidBottom, TileObjectData.newTile.Width, 0);
            TileObjectData.newAlternate.AnchorBottom = AnchorData.Empty;
            TileObjectData.addAlternate(2);

            // Allow attaching to a solid object that is to the right
            TileObjectData.newAlternate.CopyFrom(TileObjectData.newTile);
            TileObjectData.newAlternate.AnchorRight = new AnchorData(AnchorType.SolidTile | AnchorType.SolidSide | AnchorType.Tree, TileObjectData.newTile.Height, 0);
            TileObjectData.newAlternate.AnchorBottom = AnchorData.Empty;
            TileObjectData.addAlternate(4);

            // Allow attaching to a solid object that is to the left
            TileObjectData.newAlternate.CopyFrom(TileObjectData.newTile);
            TileObjectData.newAlternate.AnchorLeft = new AnchorData(AnchorType.SolidTile | AnchorType.SolidSide | AnchorType.Tree, TileObjectData.newTile.Height, 0);
            TileObjectData.newAlternate.AnchorBottom = AnchorData.Empty;
            TileObjectData.addAlternate(6);

            // Allow attaching to the ground
            TileObjectData.newAlternate.CopyFrom(TileObjectData.newTile);
            TileObjectData.addAlternate(0);

            TileObjectData.addTile(Type);

            AddMapEntry(new Color(255, 0, 0));

            if (!Main.dedServ)
            {
                overlayTexture = ModContent.Request<Texture2D>("DragonsDecorativeMod/Tiles/Christmas/LightPaintableOverlay");
            }

            DustType = DustID.Mythril;
        }

        public override void ModifyLight(int i, int j, ref float r, ref float g, ref float b)
        {
            Tile tile = Main.tile[i, j];
            int frameX = tile.TileFrameX / 18;

            float flicker = Main.rand.Next(970, 1031) * 0.001f;
            if (frameX < 1)
            {
                if (tile.TileColor == 0)
                {
                    r = 1f * flicker;
                }
                else
                {
                    Color color = WorldGen.paintColor(tile.TileColor);
                    r = color.R / 255f * flicker;
                    g = color.G / 255f * flicker;
                    b = color.B / 255f * flicker;
                }
            }
        }

        public override void HitWire(int i, int j)
        {
            if (Main.tile[i, j].TileFrameX == 0)
            {
                Main.tile[i, j].TileFrameX = 18;
            }
            else
            {
                Main.tile[i, j].TileFrameX = 0;
            }

            // Avoid trying to send packets in singleplayer.
            if (Main.netMode != NetmodeID.SinglePlayer)
            {
                NetMessage.SendTileSquare(-1, i, j, 1, TileChangeType.None);
            }
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

            Color color = WorldGen.paintColor(tile.TileColor);

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

            if (tile.TileFrameX == 0)
            {
                color = new Color(255, 255, 255);
            }

            Texture2D texture = overlayTexture.Value;

            spriteBatch.Draw(texture, new Vector2(i * 16 - (int)Main.screenPosition.X, j * 16 - (int)Main.screenPosition.Y) + offScreenAdjust, new Rectangle(frameX, frameY, 16, 16), color, 0f, default, 1f, SpriteEffects.None, 0f);
        }

        public override IEnumerable<Item> GetItemDrops(int i, int j)
        {
            yield return new Item(ItemType<Items.Christmas.LightPaintable>());
        }
    }
}