using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria;
using Terraria.DataStructures;
using Terraria.Enums;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace DragonsDecorativeMod.Tiles.Garden
{
    public class SingleTileFloweryPlant : ModTile
    {
        private Asset<Texture2D> overlayTexture;

        public override void SetStaticDefaults()
        {
            Main.tileFrameImportant[Type] = true;
            Main.tileLavaDeath[Type] = true;

            TileObjectData.newTile.CopyFrom(TileObjectData.Style1x1);
            TileObjectData.newTile.AnchorBottom = new AnchorData(AnchorType.SolidTile | AnchorType.SolidWithTop | AnchorType.Table | AnchorType.SolidSide, TileObjectData.newTile.Width, 0);
            TileObjectData.newTile.CoordinateHeights = new int[1] { 48 };
            TileObjectData.newTile.CoordinateWidth = 32;
            TileObjectData.newTile.DrawYOffset = -30;
            TileObjectData.newTile.StyleHorizontal = true;
            TileObjectData.newTile.RandomStyleRange = 4;
            TileObjectData.newTile.StyleMultiplier = 4;
            TileObjectData.addTile(Type);

            LocalizedText name = CreateMapEntryName();
            // name.SetDefault("Single Tile Flowery Plant");
            AddMapEntry(new Color(75, 98, 37), name);

            HitSound = SoundID.Grass;
            DustType = DustID.Grass;

            if (!Main.dedServ)
            {
                overlayTexture = ModContent.Request<Texture2D>("DragonsDecorativeMod/Tiles/Garden/SingleTileFloweryPlantOverlay");
            }
        }

        public override bool CanDrop(int i, int j)
        {
            return true;
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

            Texture2D texture = overlayTexture.Value;

            spriteBatch.Draw(texture, new Vector2(i * 16 - 8 - (int)Main.screenPosition.X, j * 16 - 30 - (int)Main.screenPosition.Y) + offScreenAdjust, new Rectangle(frameX, frameY, 32, 48), color, 0f, default, 1f, SpriteEffects.None, 0f);
        }
    }
}