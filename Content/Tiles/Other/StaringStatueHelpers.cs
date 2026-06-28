using Microsoft.Xna.Framework;
using System;
using Terraria;
using Terraria.ID;
using Terraria.ObjectData;
using static Terraria.ModLoader.ModContent;

namespace DragonsDecorativeMod.Content.Tiles.Other
{
    internal static class StaringStatueHelpers
    {

        internal static Vector2 FindLookDirection(int i, int j, Vector2 look_direction)
        {
            float distance = 0f;
            float tileCenterX = i * 16f + 16f;
            float tileCenterY = j * 16f + 16f + 8f;
            Vector2 position = new(tileCenterX, tileCenterY);
            Player player = null;
            foreach (Player activePlayer in Main.ActivePlayers)
            {
                if (distance == 0f || position.Distance(activePlayer.Center) < distance)
                {
                    distance = position.Distance(activePlayer.Center);
                    player = activePlayer;
                }
            }
            if (player == null)
            {
                return look_direction;
            }
            float xDifference = player.Center.X - tileCenterX;
            float yDifference = player.position.Y - tileCenterY;
            xDifference = Math.Abs(xDifference) < (16 * 10) ? 0 : xDifference;
            yDifference = Math.Abs(yDifference) < (16 * 10) ? 0 : yDifference;
            look_direction.X = Math.Sign(xDifference);
            look_direction.Y = Math.Sign(yDifference);
            return look_direction;
        }

        internal static bool NearbyEffects(int i, int j, bool closer, ref Vector2 look_direction)
        {
            if (!closer || !TileObjectData.IsTopLeft(Main.tile[i, j]))
            {
                return false;
            }

            look_direction = FindLookDirection(i, j, look_direction);
            TestTypeAndDirection(i, j, look_direction);
            return true;
        }

        internal static void TestTypeAndDirection(int i, int j, Vector2 look_direction)
        {
            if (look_direction.X < 0)
            {
                switch (look_direction.Y)
                {
                    case < 0:
                        TryTypeChange(i, j, (ushort)TileType<StaringStatueUpLeft>());
                        break;
                    case > 0:
                        TryTypeChange(i, j, (ushort)TileType<StaringStatueDownLeft>());
                        break;
                    default:
                        TryTypeChange(i, j, (ushort)TileType<StaringStatueLeft>());
                        break;
                }
            }
            else if (look_direction.X == 0)
            {
                switch (look_direction.Y)
                {
                    case < 0:
                        TryTypeChange(i, j, (ushort)TileType<StaringStatueUp>());
                        break;
                    case > 0:
                        TryTypeChange(i, j, (ushort)TileType<StaringStatueDown>());
                        break;
                    default:
                        TryTypeChange(i, j, (ushort)TileType<StaringStatue>());
                        break;
                }
            }
            else
            {
                switch (look_direction.Y)
                {
                    case < 0:
                        TryTypeChange(i, j, (ushort)TileType<StaringStatueUpRight>());
                        break;
                    case > 0:
                        TryTypeChange(i, j, (ushort)TileType<StaringStatueDownRight>());
                        break;
                    default:
                        TryTypeChange(i, j, (ushort)TileType<StaringStatueRight>());
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
            Main.tile[i + 1, j].TileType = tileType;
            Main.tile[i + 1, j + 1].TileType = tileType;
            Main.tile[i + 1, j + 2].TileType = tileType;

            if (Main.netMode != NetmodeID.SinglePlayer)
            {
                NetMessage.SendTileSquare(-1, i, j, 2, 3);
            }
        }
    }
}