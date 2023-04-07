using Microsoft.Xna.Framework;
using System.Collections.Generic;
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

        public override bool CanDrop(int i, int j)
        {
            return true;
        }

        public override IEnumerable<Item> GetItemDrops(int i, int j)
        {
            Tile tile = Main.tile[i, j];
            int style = TileObjectData.GetTileStyle(tile);

            if (style < 2)
            {
                yield return new Item(ModContent.ItemType<Items.Garden.SingleTilePlant>());
            }
            else if (style < 4)
            {
                yield return new Item(ModContent.ItemType<Items.Garden.SingleTilePlant2>());
            }
            else if (style < 6)
            {
                yield return new Item(ModContent.ItemType<Items.Garden.SingleTilePlant3>());
            }
            else
            {
                yield return new Item(ModContent.ItemType<Items.Garden.SingleTilePlant4>());
            }
        }
    }
}
