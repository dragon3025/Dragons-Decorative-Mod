using Microsoft.Xna.Framework;
using System.Collections.Generic;
using Terraria;
using Terraria.Audio;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace DragonsDecorativeMod.Tiles
{
    public class Lectern : ModTile
    {
        public override void SetStaticDefaults()
        {
            Main.tileFrameImportant[Type] = true;
            Main.tileNoAttach[Type] = true;
            Main.tileLavaDeath[Type] = true;

            TileObjectData.newTile.CopyFrom(TileObjectData.Style2x2);
            TileObjectData.newTile.Height = 3;
            TileObjectData.newTile.Origin = new Point16(0, 2);
            TileObjectData.newTile.CoordinateHeights = new int[3] { 16, 16, 16 };
            TileObjectData.newTile.StyleHorizontal = true;
            TileObjectData.newTile.DrawYOffset = 2;

            TileObjectData.addTile(Type);

            AddMapEntry(new Color(169, 125, 93));
        }

        public override IEnumerable<Item> GetItemDrops(int i, int j)
        {
            Tile tile = Main.tile[i, j];
            int tileFrameX = tile.TileFrameX / 36;

            yield return new Item(ModContent.ItemType<Items.Lectern>());
            if (tileFrameX > 0)
            {
                yield return new Item(ItemID.Book);
            }
        }

        public override bool RightClick(int i, int j)
        {
            Player player = Main.LocalPlayer;
            bool toggleStyle = false;

            Tile tile = Main.tile[i, j];
            int tileFrameX = tile.TileFrameX / 36;

            if (tileFrameX == 0 && player.HasItem(ItemID.Book))
            {
                player.ConsumeItem(ItemID.Book, true);
                toggleStyle = true;
            }
            else if (tileFrameX == 1)
            {
                Item.NewItem(WorldGen.GetItemSource_FromTileBreak(i, j), new Vector2(i, j) * 16, ItemID.Book);
                SoundEngine.PlaySound(SoundID.Dig, new Vector2(i, j).ToWorldCoordinates());
                toggleStyle = true;
            }

            if (toggleStyle)
            {
                int topX = i - tile.TileFrameX % 36 / 18;
                int topY = j - tile.TileFrameY % 54 / 18;

                short frameAdjustment = (short)(tile.TileFrameX >= 36 ? -36 : 36);

                for (int x = topX; x < topX + 2; x++)
                {
                    for (int y = topY; y < topY + 3; y++)
                    {
                        Main.tile[x, y].TileFrameX += frameAdjustment;
                    }
                }

                if (Main.netMode != NetmodeID.SinglePlayer)
                {
                    NetMessage.SendTileSquare(-1, topX, topY, 2, 3);
                }
            }

            return toggleStyle;
        }

        public override void MouseOver(int i, int j)
        {
            Player player = Main.LocalPlayer;
            player.noThrow = 2;
            player.cursorItemIconEnabled = true;
            player.cursorItemIconID = ItemID.Book;
        }
    }
}