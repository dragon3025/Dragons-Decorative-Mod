using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.Enums;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace DragonsDecorativeMod.Tiles.Garden
{
    public class SingleTilePlant : ModTile
    {
        public override void SetStaticDefaults()
        {
            Main.tileFrameImportant[Type] = true;
            Main.tileLavaDeath[Type] = true;

            TileObjectData.newTile.CopyFrom(TileObjectData.Style1x1);
            TileObjectData.newTile.AnchorBottom = new AnchorData(AnchorType.SolidTile | AnchorType.SolidWithTop | AnchorType.Table | AnchorType.SolidSide, TileObjectData.newTile.Width, 0);
            TileObjectData.newTile.CoordinateHeights = new int[1] { 48 };
            TileObjectData.newTile.CoordinateWidth = 32;
            TileObjectData.newTile.DrawYOffset = -30;
            TileObjectData.newTile.StyleHorizontal = true;
            TileObjectData.newTile.RandomStyleRange = 2;
            TileObjectData.addTile(Type);

            LocalizedText name = CreateMapEntryName();
            // name.SetDefault("Plant");
            AddMapEntry(new Color(18, 86, 30), name);

            HitSound = SoundID.Grass;
            DustType = DustID.Grass;

            //TileID.Sets.SwaysInWindBasic[Type] = true; TO-DO Setting this to true makes it move correctly, but the non-single tile variants will still act weird. Once tModLoader adds support for non-single wide tile swaying, set this to true (add "using Terraria.ID;").
        }

        public override bool Drop(int i, int j)/* tModPorter Note: Removed. Use CanDrop to decide if an item should drop. Use GetItemDrops to decide which item drops. Item drops based on placeStyle are handled automatically now, so this method might be able to be removed altogether. */
        {
            Tile t = Main.tile[i, j];
            int frame = t.TileFrameX / 36;
            int item = 0;

            if (frame <= 1)
            {
                item = ModContent.ItemType<Items.Garden.SingleTilePlant>();
            }
            else if (frame <= 3)
            {
                item = ModContent.ItemType<Items.Garden.SingleTilePlant2>();
            }
            else if (frame <= 5)
            {
                item = ModContent.ItemType<Items.Garden.SingleTilePlant3>();
            }
            else if (frame <= 7)
            {
                item = ModContent.ItemType<Items.Garden.SingleTilePlant4>();
            }

            if (item > 0)
            {
                Item.NewItem(new EntitySource_TileBreak(i, j), i * 16, j * 16, 32, 48, item);
            }

            return base.Drop(i, j);
        }
    }
}