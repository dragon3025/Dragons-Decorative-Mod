using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using System.Collections.Generic;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace DragonsDecorativeMod.Tiles.Natural
{
    public class MysteriousTablet : ModTile
    {
        private Asset<Texture2D> overlayInnerTexture;
        private Asset<Texture2D> overlayOuterTexture;

        public override void SetStaticDefaults()
        {
            Main.tileFrameImportant[Type] = true;
            Main.tileLavaDeath[Type] = true;
            Main.tileLighted[Type] = true;

            TileObjectData.newTile.CopyFrom(TileObjectData.Style2x2);
            TileObjectData.newTile.Width = 4;
            TileObjectData.newTile.Height = 4;
            TileObjectData.newTile.Origin = new Point16(1, 3);
            TileObjectData.newTile.CoordinateHeights = new int[4] { 16, 16, 16, 16 };
            TileObjectData.newTile.AnchorBottom = AnchorData.Empty;
            TileObjectData.newTile.DrawYOffset = 0;
            TileObjectData.addTile(Type);

            LocalizedText name = CreateMapEntryName();
            // name.SetDefault("Mysterious Tablet");
            AddMapEntry(new Color(160, 122, 87), name);
            DustType = DustID.GoldFlame;

            if (!Main.dedServ)
            {
                overlayInnerTexture = ModContent.Request<Texture2D>("DragonsDecorativeMod/Tiles/Natural/MysteriousTabletOverlayInner");
                overlayOuterTexture = ModContent.Request<Texture2D>("DragonsDecorativeMod/Tiles/Natural/MysteriousTabletOverlayOuter");
            }
        }

        public override void AnimateTile(ref int frame, ref int frameCounter)
        {
            frameCounter++;
            if (frameCounter >= 5)
            {
                frameCounter = 0;
                frame++;
                frame %= 4;
            }
        }

        //To-Do When rubblemaker support is added, maybe make is to this is Rubblemaker placed with something like Luminite.
        //public override IEnumerable<Item> GetItemDrops(int i, int j)
        //{
        //    yield return new Item(ModContent.ItemType<Items.Natural.MysteriousTablet>());
        //}

        public override void ModifyLight(int i, int j, ref float r, ref float g, ref float b)
        {
            r = 0.8f;
            g = 0.75f;
            b = 0.55f;
        }

        public override void PostDraw(int i, int j, SpriteBatch spriteBatch)
        {
            Tile tile = Main.tile[i, j];
            short frameX = tile.TileFrameX;
            short frameY = tile.TileFrameY;

            Vector2 offScreenAdjust = new(Main.offScreenRange, Main.offScreenRange);

            if (Main.drawToScreen)
            {
                offScreenAdjust = Vector2.Zero;
            }

            Color color = Lighting.GetColor(i, j);

            int frameYOffset = Main.tileFrame[ModContent.TileType<MysteriousTablet>()];

            Texture2D textureInner = overlayInnerTexture.Value;
            Texture2D textureOuter = overlayOuterTexture.Value;

            spriteBatch.Draw(textureInner,
                new Vector2(i * 16 - (int)Main.screenPosition.X, j * 16 - (int)Main.screenPosition.Y) + offScreenAdjust,
                new Rectangle(frameX, frameY, 16, 16),
                color, 0f, default, 1f, SpriteEffects.None, 0f);

            if (frameX == 0 && frameY == 0)
            {
                Main.spriteBatch.Draw(
                textureOuter,
                new Vector2(i * 16 - 2 - (int)Main.screenPosition.X, j * 16 - 36 - (int)Main.screenPosition.Y) + offScreenAdjust,
                new Rectangle(0, 96 * frameYOffset, 66, 96),
                new Color(255, 255, 255), 0f, default, 1f, SpriteEffects.None, 0f);
            }
        }
    }
}