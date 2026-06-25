using Microsoft.Xna.Framework;
using System.Collections.Generic;
using Terraria;
using Terraria.Enums;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace DragonsDecorativeMod.Content.Tiles.Garden.Mushrooms
{
    public class BrownMushroom : ModTile
    {
        public override void SetStaticDefaults()
        {
            Main.tileFrameImportant[Type] = true;
            Main.tileLavaDeath[Type] = true;
            Main.tileNoAttach[Type] = true;

            TileObjectData.newTile.CopyFrom(TileObjectData.Style1x1);
            TileObjectData.newTile.CoordinateHeights = [18];
            TileObjectData.newTile.DrawYOffset = 2;
            TileObjectData.newTile.StyleHorizontal = true;
            TileObjectData.newTile.RandomStyleRange = 5;
            TileObjectData.newTile.StyleMultiplier = 5;
            TileObjectData.newTile.WaterPlacement = LiquidPlacement.NotAllowed;

            TileObjectData.addTile(Type);

            AddMapEntry(new Color(49, 38, 28));

            TileID.Sets.SwaysInWindBasic[Type] = true;
            TileID.Sets.ReplaceTileBreakUp[Type] = true;

            HitSound = SoundID.Grass;

            DustType = -1;
        }

        public override IEnumerable<Item> GetItemDrops(int i, int j)
        {
            yield return new Item(ModContent.ItemType<Items.Placeable.Garden.Mushrooms.BrownMushroom>());
        }
    }
}