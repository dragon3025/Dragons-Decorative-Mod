using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ObjectData;
using static Terraria.ModLoader.ModContent;

namespace DragonsDecorativeMod.Content.Tiles.Other
{
    internal static class StaringStatueHelpers
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
            Main.tileObsidianKill[Type] = true;
            Main.tileNoAttach[Type] = true;

            TileObjectData.newTile.CopyFrom(TileObjectData.Style2xX);
            TileObjectData.newTile.DrawYOffset = 2;
            TileObjectData.addTile(Type);
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