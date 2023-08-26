using Microsoft.Xna.Framework;
using System.Collections.Generic;
using Terraria;
using Terraria.Enums;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.ObjectData;
using static Terraria.ModLoader.ModContent;

namespace DragonsDecorativeMod.Tiles.Christmas
{
    public class CandyCane : ModTile
    {
        public override void SetStaticDefaults()
        {
            Main.tileFrameImportant[Type] = true;
            Main.tileNoAttach[Type] = true;
            Main.tileLavaDeath[Type] = true;
            Main.tileLighted[Type] = true;

            TileObjectData.newTile.CopyFrom(TileObjectData.Style2xX);
            TileObjectData.newTile.DrawYOffset = 2;
            TileObjectData.newTile.Direction = TileObjectDirection.PlaceLeft;

            TileObjectData.newAlternate.CopyFrom(TileObjectData.newTile);
            TileObjectData.newAlternate.Direction = TileObjectDirection.PlaceRight;
            TileObjectData.addAlternate(1);

            TileObjectData.addTile(Type);

            LocalizedText name = CreateMapEntryName();
            // name.SetDefault("Lawn Candy Cane");
            AddMapEntry(new Color(255, 128, 128), name);
            DustType = DustID.Adamantite;
        }

        public override void HitWire(int i, int j)
        {
            Tile tile = Main.tile[i, j];

            if (tile.TileFrameY >= 18)
            {
                int tileFrameX = tile.TileFrameX / 18;
                if (tileFrameX == 0 || tileFrameX == 3 || tileFrameX == 4 || tileFrameX == 7)
                {
                    return;
                }
            }

            int topX = i - tile.TileFrameX % 36 / 18;
            int topY = j - tile.TileFrameY % 54 / 18;

            short frameAdjustment = (short)(tile.TileFrameX >= 72 ? -72 : 72);

            for (int x = topX; x < topX + 2; x++)
            {
                for (int y = topY; y < topY + 3; y++)
                {
                    Main.tile[x, y].TileFrameX += frameAdjustment;

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
            int frameX = tile.TileFrameX / 18;
            int frameY = tile.TileFrameY / 18;


            float flicker = Main.rand.Next(970, 1031) * 0.001f;
            bool light = true;
            if (frameX >= 4)
            {
                light = false;
            }
            if (frameY >= 1 && (frameX < 1 || frameX >= 3))
            {
                light = false;
            }
            if (light)
            {
                if (tile.TileColor == 0)
                {
                    g = 0.5f * flicker;
                    b = 0.5f * flicker;
                    r = 1f * flicker;
                }
                else
                {
                    Color color = WorldGen.paintColor(tile.TileColor);
                    if (tile.TileColor < 13) //Paint that doesn't affect white
                    {
                        r = 0.5f + color.R / 510f * flicker;
                        g = 0.5f + color.G / 510f * flicker;
                        b = 0.5f + color.B / 510f * flicker;
                    }
                    else
                    {
                        r = color.R / 255f * flicker;
                        g = color.G / 255f * flicker;
                        b = color.B / 255f * flicker;
                    }
                }
            }
        }

        public override IEnumerable<Item> GetItemDrops(int i, int j)
        {
            yield return new Item(ItemType<Items.Christmas.CandyCane>());
        }
    }
}