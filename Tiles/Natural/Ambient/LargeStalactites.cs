﻿using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
using Terraria.ObjectData;
using Terraria.DataStructures;
using Terraria.ID;

namespace DragonsDecorativeMod.Tiles.Natural.Ambient
{
    public class LargeStalactites : ModTile
    {
        public override void SetStaticDefaults()
        {
            Main.tileFrameImportant[Type] = true;
            Main.tileNoAttach[Type] = true;
            Main.tileLavaDeath[Type] = true;

            TileObjectData.newTile.CopyFrom(TileObjectData.Style1x2Top);
            TileObjectData.newTile.StyleHorizontal = true;
            TileObjectData.newTile.DrawYOffset = -2;
            TileObjectData.addTile(Type);

            AddMapEntry(new Color(127, 127, 127));
        }

        public override bool CreateDust(int i, int j, ref int type)
        {
            return false;
        }

        public override void KillMultiTile(int x, int y, int frameX, int frameY)
        {
            int frame = frameX / 18;

            int item = 0;

            if (frame < 3)
                item = ItemID.IceBlock;
            else if (frame < 6)
                item = ItemID.StoneBlock;
            else if (frame < 9)
                item = ItemID.Cobweb;
            else if (frame < 12)
                item = ItemID.PearlstoneBlock;
            else if (frame < 15)
                item = ItemID.EbonstoneBlock;
            else if (frame < 18)
                item = ItemID.CrimstoneBlock;
            else if (frame < 21)
                item = ItemID.Sandstone;
            else if (frame < 24)
                item = ItemID.GraniteBlock;
            else if (frame < 27)
                item = ItemID.MarbleBlock;
            else if (frame < 30)
                item = ItemID.PinkIceBlock;
            else if (frame < 33)
                item = ItemID.PurpleIceBlock;
            else
                item = ItemID.RedIceBlock;

            if (item > 0)
                Item.NewItem(new EntitySource_TileBreak(x, y), x * 16, y * 16, 16, 32, item);
        }
    }
}