using Microsoft.Xna.Framework;
using System;
using Terraria;

namespace DragonsDecorativeMod.Content.Tiles.Other
{
    internal static class StaringTileHelpers
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
    }
}