using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Audio;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace DragonsDecorativeMod.Content.Items
{
    internal class Inclinometer : ModItem
    {
        public override void SetStaticDefaults()
        {
            ContentSamples.AddItemResearchOverride(Type, ItemType<InclinometerReversed>());
        }

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
            return GetHammerStatsFromInventoryAndVoidBag(player, out Item.useTime, out Item.useAnimation, out Item.tileBoost);
        }

        public override bool? UseItem(Player player)
        {
            if (player.whoAmI != Main.myPlayer)
            {
                return true;
            }

            int rangeX = 10 + player.blockRange + Item.tileBoost;
            int rangeY = rangeX - 3;

            Point position = player.Center.ToTileCoordinates();
            for (int x = position.X - rangeX; x <= position.X + rangeX; x++)
            {
                for (int y = position.Y - rangeY; y <= position.Y + rangeY; y++)
                {
                    Tile tile = Framing.GetTileSafely(x, y);
                    Tile tileLeft = Framing.GetTileSafely(x - 1, y);
                    Tile tileRight = Framing.GetTileSafely(x + 1, y);
                    Tile tileTop = Framing.GetTileSafely(x, y - 1);
                    Tile tileBottom = Framing.GetTileSafely(x, y + 1);

                    static bool hasTerrainTile(Tile tile)
                    {
                        return tile.HasTile && !Main.tileFrameImportant[tile.TileType] && !Main.tileAxe[tile.TileType];
                    }

                    static bool hasFrameImportantTile(Tile tile)
                    {
                        return tile.HasTile && Main.tileFrameImportant[tile.TileType];
                    }

                    if (tile.BlockType != BlockType.Solid
                        || !WorldGen.CanPoundTile(x, y)
                        || !hasTerrainTile(tile)
                        || hasFrameImportantTile(tileLeft)
                        || hasFrameImportantTile(tileRight)
                        || hasFrameImportantTile(tileTop)
                        || hasFrameImportantTile(tileBottom))
                    {
                        continue;
                    }

                    if (tileTop.HasTile)
                    {
                        if (tileBottom.HasTile)
                        {
                            continue;
                        }
                        if (hasTerrainTile(tileLeft) && !hasTerrainTile(tileRight))
                        {
                            HammerTile(x, y, tile, BlockType.SlopeUpLeft);
                            goto CheckForBlockChanged;
                        }
                        else if (!hasTerrainTile(tileLeft) && hasTerrainTile(tileRight))
                        {
                            HammerTile(x, y, tile, BlockType.SlopeUpRight);
                            goto CheckForBlockChanged;
                        }
                        else if (!hasTerrainTile(tileLeft) && !hasTerrainTile(tileRight))
                        {
                            BlockType blockType = Main.rand.NextBool(2) ? BlockType.SlopeUpLeft : BlockType.SlopeUpRight;
                            HammerTile(x, y, tile, blockType);
                            goto CheckForBlockChanged;
                        }
                        continue;
                    }

                    if (!hasTerrainTile(tileLeft))
                    {
                        if (hasTerrainTile(tileRight) && (tileRight.BlockType == BlockType.Solid || tileRight.BlockType == BlockType.SlopeDownRight || tileRight.BlockType == BlockType.SlopeUpRight))
                        {
                            BlockType blockType = Main.rand.NextBool(2) ? BlockType.HalfBlock : BlockType.SlopeDownRight;
                            HammerTile(x, y, tile, blockType);
                        }
                        else
                        {
                            HammerTile(x, y, tile, BlockType.HalfBlock);
                        }
                    }
                    else
                    {
                        if (!hasTerrainTile(tileRight))
                        {
                            if (tileLeft.BlockType == BlockType.Solid
                            || tileLeft.BlockType == BlockType.SlopeDownRight
                            || tileLeft.BlockType == BlockType.SlopeUpRight)
                            {
                                BlockType blockType = Main.rand.NextBool(2) ? BlockType.HalfBlock : BlockType.SlopeDownLeft;
                                HammerTile(x, y, tile, blockType);
                            }
                            else
                            {
                                HammerTile(x, y, tile, BlockType.HalfBlock);
                            }
                        }
                    }

                    CheckForBlockChanged: { }
                    if (tile.BlockType != BlockType.Solid)
                    {
                        return true;
                    }
                }
            }
            return true;
        }

        public static void HammerTile(int x, int y, Tile tile, BlockType blockType)
        {
            while (tile.BlockType != blockType)
            {
                if ((Main.tile[x, y].IsHalfBlock || Main.tile[x, y].Slope != 0) && !Main.tileSolidTop[Main.tile[x, y].TileType])
                {
                    bool soldTileAboveAndNotBelow = false;
                    int slopeType1 = (int)SlopeType.SlopeDownLeft;
                    int slopetype2 = (int)SlopeType.SlopeDownRight;
                    if ((WorldGen.SolidTile(x + 1, y)
                        || (int)Main.tile[x + 1, y].Slope == 1
                        || (int)Main.tile[x + 1, y].Slope == 3) && !WorldGen.SolidTile(x - 1, y))
                    {
                        slopeType1 = (int)SlopeType.SlopeDownRight;
                        slopetype2 = (int)SlopeType.SlopeDownLeft;
                    }
                    if (WorldGen.SolidTile(x, y - 1) && !WorldGen.SolidTile(x, y + 1))
                    {
                        soldTileAboveAndNotBelow = true;
                    }
                    if (soldTileAboveAndNotBelow)
                    {
                        if (Main.tile[x, y].Slope == 0)
                        {
                            WorldGen.SlopeTile(x, y, slopeType1);
                        }
                        else if ((int)Main.tile[x, y].Slope == slopeType1)
                        {
                            WorldGen.SlopeTile(x, y, slopetype2);
                        }
                        else if ((int)Main.tile[x, y].Slope == slopetype2)
                        {
                            WorldGen.SlopeTile(x, y, slopeType1 + 2);
                        }
                        else if ((int)Main.tile[x, y].Slope == slopeType1 + 2)
                        {
                            WorldGen.SlopeTile(x, y, slopetype2 + 2);
                        }
                        else
                        {
                            WorldGen.SlopeTile(x, y);
                        }
                    }
                    else if (Main.tile[x, y].Slope == 0)
                    {
                        WorldGen.SlopeTile(x, y, slopeType1 + 2);
                    }
                    else if ((int)Main.tile[x, y].Slope == slopeType1 + 2)
                    {
                        WorldGen.SlopeTile(x, y, slopetype2 + 2);
                    }
                    else if ((int)Main.tile[x, y].Slope == slopetype2 + 2)
                    {
                        WorldGen.SlopeTile(x, y, slopeType1);
                    }
                    else if ((int)Main.tile[x, y].Slope == slopeType1)
                    {
                        WorldGen.SlopeTile(x, y, slopetype2);
                    }
                    else
                    {
                        WorldGen.SlopeTile(x, y);
                    }
                    int newSlope = (int)Main.tile[x, y].Slope;
                    if (Main.netMode == NetmodeID.MultiplayerClient)
                    {
                        NetMessage.SendData(MessageID.TileManipulation, -1, -1, null, 14, x, y, newSlope);
                    }
                }
                else
                {
                    WorldGen.PoundTile(x, y);
                    if (Main.netMode == NetmodeID.MultiplayerClient)
                    {
                        NetMessage.SendData(MessageID.TileManipulation, -1, -1, null, 7, x, y, 1f);
                    }
                }
            }
        }

        public static bool GetHammerStatsFromInventoryAndVoidBag(Player player, out int useTime, out int useAnimation, out int tileBoost)
        {
            useTime = useAnimation = tileBoost = 0;
            foreach (Item item in player.inventory)
            {
                if (item == null
                    || item.type == ItemID.None
                    || item.hammer == 0)
                {
                    continue;
                }

                useTime = item.useTime;
                useAnimation = item.useAnimation;
                tileBoost = item.tileBoost;

                float pickSpeed = System.Math.Max(0.3f, player.pickSpeed);
                useAnimation = System.Math.Max(1, (int)(useAnimation * pickSpeed));
                useTime = System.Math.Max(1, (int)(useTime * pickSpeed));

                return true;
            }
            return false;
        }
    }

    public class InclinometerPlayer : ModPlayer
    {
        internal static void Toggle(Player player, Item item)
        {
            player.releaseUseTile = false;
            Main.mouseRightRelease = false;
            int stack = item.stack; //In 1.4.5+, the stack is transfered.
            if (item.type == ItemType<Inclinometer>())
            {
                item.ChangeItemType(ItemType<InclinometerReversed>());
            }
            else
            {
                item.ChangeItemType(ItemType<Inclinometer>());
            }
            item.stack = stack;
            Recipe.FindRecipes(); //Not needed in 1.4.5+
        }
    }
}
