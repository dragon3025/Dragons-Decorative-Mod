using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using System.Collections.Generic;
using Terraria;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace DragonsDecorativeMod.Tiles.Garden.PottedPlants
{
    public class PottedXMasTrees : ModTile
    {
        private Asset<Texture2D> overlayTexture;

        public override void SetStaticDefaults()
        {
            Main.tileFrameImportant[Type] = true;
            Main.tileLavaDeath[Type] = true;
            Main.tileNoAttach[Type] = true;

            TileObjectData.newTile.CopyFrom(TileObjectData.Style3x4);
            TileObjectData.newTile.DrawYOffset = 2;
            TileObjectData.addTile(Type);

            AddMapEntry(new Color(120, 110, 100));

            if (!Main.dedServ)
            {
                overlayTexture = ModContent.Request<Texture2D>("DragonsDecorativeMod/Tiles/Garden/PottedPlants/PlanterXMasTrees");
            }
        }

        public override IEnumerable<Item> GetItemDrops(int i, int j)
        {
            Tile tile = Main.tile[i, j];
            int style = TileObjectData.GetTileStyle(tile);

            if (style == 0)
            {
                yield return new Item(ModContent.ItemType<Items.Garden.PottedPlants.PottedXMasTree>());
            }
            else
            {
                yield return new Item(ModContent.ItemType<Items.Garden.PottedPlants.PottedXMasTreeSnowy>());
            }
        }

        public override bool CreateDust(int i, int j, ref int type)
        {
            return false;
        }

        public override void PostDraw(int i, int j, SpriteBatch spriteBatch)
        {
            Tile tile = Main.tile[i, j];

            short frameX = tile.TileFrameX;
            short frameY = tile.TileFrameY;

            frameX %= 54;

            if (frameY < 36)
            {
                return;
            }

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

            Texture2D texture = overlayTexture.Value;

            spriteBatch.Draw(texture, new Vector2(i * 16 - (int)Main.screenPosition.X, j * 16 - (int)Main.screenPosition.Y + 2) + offScreenAdjust, new Rectangle(frameX, frameY - 36, 16, 16), color, 0f, default, 1f, SpriteEffects.None, 0f);
        }
    }
}