﻿using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.Enums;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace DragonsDecorativeMod.Tiles.Garden
{
    public class Mushrooms : ModTile
    {
        public override void SetStaticDefaults()
        {
            Main.tileFrameImportant[Type] = true;
            Main.tileLavaDeath[Type] = true;
            Main.tileNoAttach[Type] = true;

            TileObjectData.newTile.CopyFrom(TileObjectData.Style1x1);
            TileObjectData.newTile.CoordinateHeights = new int[1] { 18 };
            TileObjectData.newTile.DrawYOffset = 2;
            TileObjectData.newTile.StyleHorizontal = true;
            TileObjectData.newTile.StyleWrapLimit = 5;
            TileObjectData.newTile.WaterPlacement = LiquidPlacement.NotAllowed;
            TileObjectData.addTile(Type);

            AddMapEntry(new Color(255, 56, 56));
            AddMapEntry(new Color(173, 85, 154));
            AddMapEntry(new Color(153, 128, 84));
            AddMapEntry(new Color(255, 253, 250));

            TileID.Sets.SwaysInWindBasic[Type] = true;
            TileID.Sets.ReplaceTileBreakUp[Type] = true;

            HitSound = SoundID.Grass;
        }

        public override ushort GetMapOption(int i, int j)
        {
            return (ushort)(Main.tile[i, j].TileFrameY / 18);
        }

        public override bool CreateDust(int i, int j, ref int type)
        {
            return false;
        }

        public override bool Drop(int i, int j)/* tModPorter Note: Removed. Use CanDrop to decide if an item should drop. Use GetItemDrops to decide which item drops. Item drops based on placeStyle are handled automatically now, so this method might be able to be removed altogether. */
        {
            Tile t = Main.tile[i, j];
            int frame = t.TileFrameY / 20;
            int itemID = 0;

            if (frame == 0)
            {
                itemID = ModContent.ItemType<Items.Garden.RedMushroom>();
            }
            else if (frame == 1)
            {
                itemID = ModContent.ItemType<Items.Garden.BleedingCrownMushroom>();
            }
            else if (frame == 2)
            {
                itemID = ModContent.ItemType<Items.Garden.BrownMushroom>();
            }
            else if (frame == 3)
            {
                itemID = ModContent.ItemType<Items.Garden.WhiteMushroom>();
            }

            if (itemID > 0)
            {
                Item.NewItem(new EntitySource_TileBreak(i, j), i * 16, j * 16, 16, 16, itemID);
            }

            return base.Drop(i, j);
        }
    }
}