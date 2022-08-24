using Microsoft.Xna.Framework;
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

            AddMapEntry(new Color(255, 253, 252));

            TileID.Sets.SwaysInWindBasic[Type] = true;
            TileID.Sets.ReplaceTileBreakUp[Type] = true;

            HitSound = SoundID.Grass;
        }

        public override bool Drop(int i, int j)
        {
            Tile t = Main.tile[i, j];
            int frame = t.TileFrameY / 20;
            int itemID = 0;

            if (frame == 0)
                itemID = ModContent.ItemType<Items.Garden.RedMushroom>();
            else if (frame == 1)
                itemID = ModContent.ItemType<Items.Garden.BleedingCrownMushroom>();
            else if (frame == 2)
                itemID = ModContent.ItemType<Items.Garden.BrownMushroom>();
            else if (frame == 3)
                itemID = ModContent.ItemType<Items.Garden.WhiteMushroom>();

            if (itemID > 0)
                Item.NewItem(new EntitySource_TileBreak(i, j), i * 16, j * 16, 16, 16, itemID);

            return base.Drop(i, j);
        }
    }
}