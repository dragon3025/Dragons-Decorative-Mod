using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ObjectData;
using static Terraria.ModLoader.ModContent;

namespace DragonsDecorativeMod.Content.Tiles.Other
{
    internal static class MedusaWatchingHelpers
    {
        internal static bool NearbyEffects(int i, int j, bool closer, ref Vector2 look_direction)
        {
            if (!closer || !TileObjectData.IsTopLeft(Main.tile[i, j]))
            {
                return false;
            }

            look_direction = StaringTileHelpers.FindLookDirection(i, j, look_direction);
            TestTypeAndDirection(i, j, look_direction);
            return true;
        }

        internal static void SetTileInfo(ushort Type)
        {
            Main.tileFrameImportant[Type] = true;
            Main.tileNoAttach[Type] = true;
            Main.tileLavaDeath[Type] = true;
            TileID.Sets.FramesOnKillWall[Type] = true;

            TileObjectData.newTile.CopyFrom(TileObjectData.Style3x3Wall);
            TileObjectData.newTile.Height = 4;
            TileObjectData.newTile.CoordinateHeights = [16, 16, 16, 16];
            TileObjectData.addTile(Type);
        }

        internal static void TestTypeAndDirection(int i, int j, Vector2 look_direction)
        {
            if (look_direction.X < 0)
            {
                switch (look_direction.Y)
                {
                    case < 0:
                        TryTypeChange(i, j, (ushort)TileType<MedusaWatchingUpLeft>());
                        break;
                    case > 0:
                        TryTypeChange(i, j, (ushort)TileType<MedusaWatchingDownLeft>());
                        break;
                    default:
                        TryTypeChange(i, j, (ushort)TileType<MedusaWatchingLeft>());
                        break;
                }
            }
            else if (look_direction.X == 0)
            {
                switch (look_direction.Y)
                {
                    case < 0:
                        TryTypeChange(i, j, (ushort)TileType<MedusaWatchingUp>());
                        break;
                    case > 0:
                        TryTypeChange(i, j, (ushort)TileType<MedusaWatchingDown>());
                        break;
                    default:
                        TryTypeChange(i, j, (ushort)TileType<MedusaWatching>());
                        break;
                }
            }
            else
            {
                switch (look_direction.Y)
                {
                    case < 0:
                        TryTypeChange(i, j, (ushort)TileType<MedusaWatchingUpRight>());
                        break;
                    case > 0:
                        TryTypeChange(i, j, (ushort)TileType<MedusaWatchingDownRight>());
                        break;
                    default:
                        TryTypeChange(i, j, (ushort)TileType<MedusaWatchingRight>());
                        break;
                }
            }
        }

        internal static void TryTypeChange(int i, int j, ushort tileType)
        {
            if (Main.tile[i, j].TileType == tileType)
            {
                return;
            }

            Main.tile[i, j].TileType = tileType;
            Main.tile[i, j + 1].TileType = tileType;
            Main.tile[i, j + 2].TileType = tileType;
            Main.tile[i, j + 3].TileType = tileType;
            Main.tile[i + 1, j].TileType = tileType;
            Main.tile[i + 1, j + 1].TileType = tileType;
            Main.tile[i + 1, j + 2].TileType = tileType;
            Main.tile[i + 1, j + 3].TileType = tileType;
            Main.tile[i + 2, j].TileType = tileType;
            Main.tile[i + 2, j + 1].TileType = tileType;
            Main.tile[i + 2, j + 2].TileType = tileType;
            Main.tile[i + 2, j + 3].TileType = tileType;

            if (Main.netMode != NetmodeID.SinglePlayer)
            {
                NetMessage.SendTileSquare(-1, i, j, 2, 3);
            }
        }
    }
}