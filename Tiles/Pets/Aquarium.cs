using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria;
using Terraria.GameContent.Drawing;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.ObjectData;

//TO-DO When 1.4.4 comes out for tModLoader, use the same graphic stretch affect that Terrariums have.

namespace DragonsDecorativeMod.Tiles.Pets
{
    public class Aquarium : ModTile
    {
        private Asset<Texture2D> textureAquariumFront;
        private Asset<Texture2D> textureAquariumNemo;
        private Asset<Texture2D> texturePinkYellow;
        private Asset<Texture2D> textureSchoolOfFish;
        private Asset<Texture2D> textureAquariumBlueStripe;
        private Asset<Texture2D> textureAquariumGreen;
        private Asset<Texture2D> textureAquariumBottomFeederAndCoral;

        private Asset<Texture2D> textureAquariumFrontNegative;
        private Asset<Texture2D> textureAquariumNemoNegative;
        private Asset<Texture2D> texturePinkYellowNegative;
        private Asset<Texture2D> textureSchoolOfFishNegative;
        private Asset<Texture2D> textureAquariumBlueStripeNegative;
        private Asset<Texture2D> textureAquariumGreenNegative;
        private Asset<Texture2D> textureAquariumBottomFeederAndCoralNegative;

        private int frameAquariumNemo = Main.rand.Next(20);
        private int framePinkYellow = Main.rand.Next(19);
        private int frameSchoolOfFish = Main.rand.Next(20);
        private int frameAquariumBlueStripe = Main.rand.Next(16);
        private int frameAquariumGreen = Main.rand.Next(9);
        private int frameAquariumBottomFeederAndCoral = Main.rand.Next(16);

        public override void SetStaticDefaults()
        {
            TileID.Sets.CritterCageLidStyle[Type] = 2; //Match Bunny Cage because it's also 6x3. It's the second in the array in TileID.cs > CritterCageLidStyle line 178
            Main.critterCage = true;
            Main.tileSolidTop[Type] = true;
            Main.tileTable[Type] = true;
            Main.tileLavaDeath[Type] = true;
            Main.tileFrameImportant[Type] = true;
            Main.tileLighted[Type] = true;

            TileObjectData.newTile.CopyFrom(TileObjectData.Style6x3);
            TileObjectData.newTile.DrawYOffset = 2;
            TileObjectData.addTile(Type);

            LocalizedText name = CreateMapEntryName();
            AddMapEntry(new Color(122, 217, 232), name);

            AnimationFrameHeight = 54;
            DustType = DustID.Water;

            // Assets
            if (!Main.dedServ)
            {
                textureAquariumFront = ModContent.Request<Texture2D>("DragonsDecorativeMod/Tiles/Pets/AquariumFront");
                textureAquariumNemo = ModContent.Request<Texture2D>("DragonsDecorativeMod/Tiles/Pets/AquariumNemo");
                texturePinkYellow = ModContent.Request<Texture2D>("DragonsDecorativeMod/Tiles/Pets/AquariumPinkYellow");
                textureSchoolOfFish = ModContent.Request<Texture2D>("DragonsDecorativeMod/Tiles/Pets/AquariumSchoolOfFish");
                textureAquariumBlueStripe = ModContent.Request<Texture2D>("DragonsDecorativeMod/Tiles/Pets/AquariumBlueStripe");
                textureAquariumGreen = ModContent.Request<Texture2D>("DragonsDecorativeMod/Tiles/Pets/AquariumGreen");
                textureAquariumBottomFeederAndCoral = ModContent.Request<Texture2D>("DragonsDecorativeMod/Tiles/Pets/AquariumBottomFeederAndCoral");

                textureAquariumFrontNegative = ModContent.Request<Texture2D>("DragonsDecorativeMod/Tiles/Pets/AquariumFrontNegative");
                textureAquariumNemoNegative = ModContent.Request<Texture2D>("DragonsDecorativeMod/Tiles/Pets/AquariumNemoNegative");
                texturePinkYellowNegative = ModContent.Request<Texture2D>("DragonsDecorativeMod/Tiles/Pets/AquariumPinkYellowNegative");
                textureSchoolOfFishNegative = ModContent.Request<Texture2D>("DragonsDecorativeMod/Tiles/Pets/AquariumSchoolOfFishNegative");
                textureAquariumBlueStripeNegative = ModContent.Request<Texture2D>("DragonsDecorativeMod/Tiles/Pets/AquariumBlueStripeNegative");
                textureAquariumGreenNegative = ModContent.Request<Texture2D>("DragonsDecorativeMod/Tiles/Pets/AquariumGreenNegative");
                textureAquariumBottomFeederAndCoralNegative = ModContent.Request<Texture2D>("DragonsDecorativeMod/Tiles/Pets/AquariumBottomFeederAndCoralNegative");
            }
        }

        public override void KillMultiTile(int i, int j, int frameX, int frameY)
        {
            for (int n = 0; n < 30; n++)
            {
                Dust.NewDustDirect(new Vector2(i * 16, j * 16), 96, 48, DustID.Glass);
            }
        }

        public override void AnimateTile(ref int frame, ref int frameCounter)
        {
            frameCounter++;
            if (frameCounter >= 10)
            {
                frameCounter = 0;
                frame++;
                frame %= 2;

                if (!(frameAquariumNemo == 0 || frameAquariumNemo == 10) || Main.rand.NextBool(5))
                {
                    frameAquariumNemo++;
                }
                if (!(framePinkYellow == 0 || framePinkYellow == 12) || Main.rand.NextBool(5))
                {
                    framePinkYellow++;
                }
                frameSchoolOfFish++;
                if (frameAquariumBottomFeederAndCoral != 0 || Main.rand.NextBool(10))
                {
                    frameAquariumBottomFeederAndCoral++;
                }
                if (!(frameAquariumGreen == 0 || frameAquariumGreen == 11) || Main.rand.NextBool(5))
                {
                    frameAquariumGreen++;
                }
                if (!(frameAquariumBlueStripe == 0 || frameAquariumBlueStripe == 9) || Main.rand.NextBool(5))
                {
                    frameAquariumBlueStripe++;
                }

                frameAquariumNemo %= 20;
                framePinkYellow %= 18;
                frameSchoolOfFish %= 20;
                frameAquariumBottomFeederAndCoral %= 10;
                frameAquariumGreen %= 17;
                frameAquariumBlueStripe %= 17;
            }
        }

        public override void PostDraw(int i, int j, SpriteBatch spriteBatch)
        {
            var tile = Main.tile[i, j];

            if (tile.IsTileInvisible && !Main.ShouldShowInvisibleWalls())
            {
                return;
            }

            Color color;

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

            Vector2 zero = new(Main.offScreenRange, Main.offScreenRange);
            if (Main.drawToScreen)
            {
                zero = Vector2.Zero;
            }

            Rectangle rectangleAquariumFront = new(tile.TileFrameX, tile.TileFrameY, 16, 16);
            Rectangle rectangleAquariumNemo = new(tile.TileFrameX, tile.TileFrameY + frameAquariumNemo * 54, 16, 16);
            Rectangle rectangleAquariumPinkYellow = new(tile.TileFrameX, tile.TileFrameY + framePinkYellow * 54, 16, 16);
            Rectangle rectangleSchoolOfFish = new(tile.TileFrameX, tile.TileFrameY + frameSchoolOfFish * 54, 16, 16);
            Rectangle rectangleAquariumBottomFeederAndCoral = new(tile.TileFrameX, tile.TileFrameY + frameAquariumBottomFeederAndCoral * 54, 16, 16);
            Rectangle rectangleAquariumGreen = new(tile.TileFrameX, tile.TileFrameY + frameAquariumGreen * 54, 16, 16);
            Rectangle rectangleAquariumBlueStripe = new(tile.TileFrameX, tile.TileFrameY + frameAquariumBlueStripe * 54, 16, 16);

            void DrawSegment(Asset<Texture2D> texture, Rectangle rectangle)
            {
                Main.spriteBatch.Draw(texture.Value, new Vector2(i * 16 - (int)Main.screenPosition.X, j * 16 - (int)Main.screenPosition.Y + 2) + zero, rectangle, color, 0f, Vector2.Zero, 1f, SpriteEffects.None, 0f);
            }

            if (tile.TileColor != PaintID.NegativePaint)
            {
                DrawSegment(textureAquariumFront, rectangleAquariumFront);
                DrawSegment(textureAquariumNemo, rectangleAquariumNemo);
                DrawSegment(texturePinkYellow, rectangleAquariumPinkYellow);
                DrawSegment(textureSchoolOfFish, rectangleSchoolOfFish);
                DrawSegment(textureAquariumBottomFeederAndCoral, rectangleAquariumBottomFeederAndCoral);
                DrawSegment(textureAquariumGreen, rectangleAquariumGreen);
                DrawSegment(textureAquariumBlueStripe, rectangleAquariumBlueStripe);
            }
            else
            {
                DrawSegment(textureAquariumFrontNegative, rectangleAquariumFront);
                DrawSegment(textureAquariumNemoNegative, rectangleAquariumNemo);
                DrawSegment(texturePinkYellowNegative, rectangleAquariumPinkYellow);
                DrawSegment(textureSchoolOfFishNegative, rectangleSchoolOfFish);
                DrawSegment(textureAquariumBottomFeederAndCoralNegative, rectangleAquariumBottomFeederAndCoral);
                DrawSegment(textureAquariumGreenNegative, rectangleAquariumGreen);
                DrawSegment(textureAquariumBlueStripeNegative, rectangleAquariumBlueStripe);
            }
        }
    }
}