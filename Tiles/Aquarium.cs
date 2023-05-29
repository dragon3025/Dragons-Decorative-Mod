using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using System;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.ObjectData;

//TO-DO When 1.4.4 comes out for tModLoader, use the same graphic stretch affect that Terrariums have.

namespace DragonsDecorativeMod.Tiles
{
    public class Aquarium : ModTile
    {
        //TO-DO: Make the tile stetch like a vanilla cage.
        //public const int FrameWidth = 18 * 6;
        //public const int FrameHeight = 18 * 3;
        //public const int HorizontalFrames = 1;
        //public const int VerticalFrames = 1; // Optional: Increase this number to match the amount of relics you have on your extra sheet, if you choose to use the Item.placeStyle approach

        //public Asset<Texture2D> MainTexture;
        //public override void Load()
        //{
        //    if (!Main.dedServ)
        //    {
        //        // Cache the extra texture displayed on the pedestal
        //        MainTexture = ModContent.Request<Texture2D>("DragonsDecorativeMod/Tiles/Aquarium");
        //    }
        //}

        //public override void Unload()
        //{
        //    // Unload the extra texture displayed on the pedestal
        //    MainTexture = null;
        //}

        public override void SetStaticDefaults()
        {
            Main.tileFrameImportant[Type] = true;
            Main.tileLavaDeath[Type] = true;
            Main.tileSolidTop[Type] = true;
            Main.tileTable[Type] = true;

            TileObjectData.newTile.CopyFrom(TileObjectData.Style6x3);
            TileObjectData.newTile.DrawYOffset = 0;
            TileObjectData.addTile(Type);

            AnimationFrameHeight = 54;

            LocalizedText name = CreateMapEntryName();
            // name.SetDefault("Aquarium");
            AddMapEntry(new Color(127, 127, 255), name);
            DustType = DustID.Water;
        }

        public override void AnimateTile(ref int frame, ref int frameCounter)
        {
            frameCounter++;
            if (frameCounter >= 20)
            {
                frameCounter = 0;
                frame++;
                frame %= 22;
            }
        }

        //TO-DO: Make the tile stetch like a vanilla cage.
        //public override void SpecialDraw(int i, int j, SpriteBatch spriteBatch)
        //{
        //    // This is lighting-mode specific, always include this if you draw tiles manually
        //    Vector2 offScreen = new Vector2(Main.offScreenRange);
        //    if (Main.drawToScreen)
        //    {
        //        offScreen = Vector2.Zero;
        //    }

        //    // Take the tile, check if it actually exists
        //    Point p = new Point(i, j);
        //    Tile tile = Main.tile[p.X, p.Y];
        //    if (tile == null || !tile.HasTile)
        //    {
        //        return;
        //    }

        //    // Get the initial draw parameters
        //    Texture2D texture = MainTexture.Value;

        //    int frameY = tile.TileFrameX / FrameWidth; // Picks the frame on the sheet based on the placeStyle of the item
        //    Rectangle frame = texture.Frame(HorizontalFrames, VerticalFrames, 0, frameY);

        //    Vector2 origin = frame.Size() / 2f;
        //    Vector2 worldPos = p.ToWorldCoordinates(24f, 64f);

        //    Color color = Lighting.GetColor(p.X, p.Y);

        //    // Some math magic to make it smoothly move up and down over time
        //    const float TwoPi = (float)Math.PI * 2f;
        //    float offset = (float)Math.Sin(Main.GlobalTimeWrappedHourly * TwoPi / 5f);
        //    Vector2 drawPos = worldPos + offScreen - Main.screenPosition + new Vector2(0f, -40f) + new Vector2(0f, offset * 4f);

        //    // Draw the main texture
        //    spriteBatch.Draw(texture, drawPos, frame, color, 0f, origin, new Vector2(1f, 2f), SpriteEffects.None, 0f);
        //}
    }
}