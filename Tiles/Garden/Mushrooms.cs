using Microsoft.Xna.Framework;
using System.Collections.Generic;
using Terraria;
using Terraria.Enums;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;
using static Terraria.ModLoader.ModContent;

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

        public override IEnumerable<Item> GetItemDrops(int i, int j)
        {
            Tile tile = Main.tile[i, j];
            int style = TileObjectData.GetTileStyle(tile);

            if (style < 5)
            {
                yield return new Item(ModContent.ItemType<Items.Garden.RedMushroom>());
            }
            else if (style < 10)
            {
                yield return new Item(ModContent.ItemType<Items.Garden.BleedingCrownMushroom>());
            }
            else if (style < 15)
            {
                yield return new Item(ModContent.ItemType<Items.Garden.BrownMushroom>());
            }
            else
            {
                yield return new Item(ModContent.ItemType<Items.Garden.WhiteMushroom>());
            }
        }

        public override bool CanDrop(int i, int j)
        {
            return true;
        }
    }
}