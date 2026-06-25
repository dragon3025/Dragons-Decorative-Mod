using Terraria;
using Terraria.Audio;
using Terraria.ID;
using Terraria.ModLoader;

namespace DragonsDecorativeMod.Content.Items
{
    internal class InclinometerReversed : ModItem
    {
        public override void SetDefaults()
        {
            Item.CloneDefaults(ItemID.WireCutter);
            Item.width = 36;
            Item.height = 36;
            Item.value = Item.buyPrice(0, 2, 0, 0);
            Item.mech = false;
            Item.tileBoost = 0;
        }

        public override void RightClick(Player player)
        {
            InclinometerPlayer.Toggle(player, Item);
        }

        public override bool CanRightClick()
        {
            return Item.stack == 1;
        }

        public override bool ConsumeItem(Player player)
        {
            return false;
        }

        public override bool AltFunctionUse(Player player)
        {
            SoundEngine.PlaySound(SoundID.Grab);
            InclinometerPlayer.Toggle(player, Item);
            return false;
        }

        public override bool CanUseItem(Player player)
        {
            return Inclinometer.GetHammerStatsFromInventoryAndVoidBag(player, out Item.useTime, out Item.useAnimation, out Item.tileBoost);
        }

        public override bool? UseItem(Player player)
        {
            if (player.whoAmI != Main.myPlayer)
            {
                return true;
            }

            int rangeX = 10 + player.blockRange + Item.tileBoost;
            int rangeY = rangeX - 3;

            Microsoft.Xna.Framework.Point position = player.Center.ToTileCoordinates();
            for (int x = position.X - rangeX; x <= position.X + rangeX; x++)
            {
                for (int y = position.Y - rangeY; y <= position.Y + rangeY; y++)
                {
                    Tile tile = Framing.GetTileSafely(x, y);

                    if (!tile.HasTile || tile.BlockType == BlockType.Solid)
                    {
                        continue;
                    }

                    Inclinometer.HammerTile(x, y, tile, BlockType.Solid);
                    return true;
                }
            }
            return true;
        }
    }
}
