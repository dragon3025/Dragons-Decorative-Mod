using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.ObjectData;
using static Terraria.ModLoader.ModContent;

namespace DragonsDecorativeMod.Tiles.Christmas
{
    public class StarSnowGlobe : ModTile
    {
        public override void SetStaticDefaults()
        {
            Main.tileFrameImportant[Type] = true;
            Main.tileNoAttach[Type] = true;
            Main.tileLavaDeath[Type] = true;
            Main.tileLighted[Type] = true;

            TileObjectData.newTile.CopyFrom(TileObjectData.Style2x2);
            TileObjectData.newTile.DrawYOffset = 2;
            TileObjectData.addTile(Type);

            AnimationFrameHeight = 36;

            LocalizedText name = CreateMapEntryName();
            AddMapEntry(new Color(122, 124, 172), name);

            HitSound = SoundID.Shatter;
            DustType = DustID.Water;
        }

        public override void AnimateTile(ref int frame, ref int frameCounter)
        {
            frameCounter++;
            if (frameCounter >= 20)
            {
                frameCounter = 0;
                if (frame == 8)
                {
                    frame = 0;
                }
                else if (frame == 17)
                {
                    frame = 9;
                }
                else
                {
                    frame++;
                }
            }
        }

        public override void HitWire(int i, int j)
        {
            Tile tile = Main.tile[i, j];

            int topX = i - tile.TileFrameX % 36 / 18;
            int topY = j - tile.TileFrameY % 36 / 18;

            int animationHeight = 36 * 9;

            short frameAdjustment = (short)(tile.TileFrameY >= animationHeight ? -animationHeight : animationHeight);

            for (int x = topX; x < topX + 2; x++)
            {
                for (int y = topY; y < topY + 2; y++)
                {
                    Main.tile[x, y].TileFrameY += frameAdjustment;

                    if (Wiring.running)
                    {
                        Wiring.SkipWire(x, y);
                    }
                }
            }

            if (Main.netMode != NetmodeID.SinglePlayer)
            {
                NetMessage.SendTileSquare(-1, topX, topY, 2, 3);
            }
        }

        public override void ModifyLight(int i, int j, ref float r, ref float g, ref float b)
        {
            Tile tile = Main.tile[i, j];
            int frameY = tile.TileFrameY / 36;

            if (frameY > 8)
            {
                return;
            }

            float flicker = Main.demonTorch * 0.2f;

            if (tile.TileColor == 0)
            {
                r = 0.9f - flicker;
                g = 0.9f - flicker;
                b = 0.7f + flicker;
            }
            else
            {
                Color color = WorldGen.paintColor(tile.TileColor);
                if (tile.TileColor < 13) //Paint that doesn't affect white
                {
                    r = 0.5f * color.R / 510f - flicker;
                    g = 0.5f * color.G / 510f - flicker;
                    b = 0.5f * color.B / 510f + flicker;
                }
                else
                {
                    r = color.R / 255f - flicker;
                    g = color.G / 255f - flicker;
                    b = color.B / 255f + flicker;
                }
            }
        }

        public override void DrawEffects(int i, int j, SpriteBatch spriteBatch, ref TileDrawInfo drawData)
        {
            if (Main.gamePaused || !Main.instance.IsActive || Lighting.UpdateEveryFrame && !Main.rand.NextBool(4))
            {
                return;
            }
            if (Main.rand.NextBool(50))
            {
                var dust = Dust.NewDust(new Vector2(i * 16 + 4, j * 16 + 4), 8, 8, DustID.Enchanted_Pink, 0f, 0f, 150);
                Main.dust[dust].velocity *= 0.5f;
            }

            if (Main.rand.NextBool(100))
            {
                int gore = Gore.NewGore(new EntitySource_TileUpdate(i, j), new Vector2(i * 16 - 2, j * 16 - 4), default(Vector2), Main.rand.Next(16, 18));
                Main.gore[gore].scale *= 0.7f;
                Main.gore[gore].velocity *= 0.25f;
            }
        }

        public override IEnumerable<Item> GetItemDrops(int i, int j)
        {
            yield return new Item(ItemType<Items.Christmas.StarSnowGlobe>());
        }
    }
}