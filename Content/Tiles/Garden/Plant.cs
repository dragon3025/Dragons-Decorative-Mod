using Microsoft.Xna.Framework;
using System.Collections.Generic;
using Terraria;
using Terraria.DataStructures;
using Terraria.Enums;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace DragonsDecorativeMod.Content.Tiles.Garden
{
    public class Plant : ModTile
    {
        public override void SetStaticDefaults()
        {
            Main.tileFrameImportant[Type] = true;
            Main.tileLavaDeath[Type] = true;

            TileObjectData.newTile.CopyFrom(TileObjectData.Style2xX);
            TileObjectData.newTile.AnchorBottom = new AnchorData(AnchorType.SolidTile | AnchorType.SolidWithTop | AnchorType.Table | AnchorType.SolidSide, TileObjectData.newTile.Width, 0);
            TileObjectData.newTile.DrawYOffset = 2;
            TileObjectData.newTile.RandomStyleRange = 2;
            TileObjectData.addTile(Type);

            LocalizedText name = CreateMapEntryName();
            AddMapEntry(new Color(18, 86, 30), name);

            HitSound = SoundID.Grass;
            DustType = DustID.Grass;
        }

        public override IEnumerable<Item> GetItemDrops(int i, int j)
        {
            Tile tile = Main.tile[i, j];
            int style = TileObjectData.GetTileStyle(tile);

            if (style < 2)
            {
                yield return new Item(ModContent.ItemType<Items.Placeable.Garden.Plant>());
            }
            else if (style < 4)
            {
                yield return new Item(ModContent.ItemType<Items.Placeable.Garden.Plant2>());
            }
            else if (style < 6)
            {
                yield return new Item(ModContent.ItemType<Items.Placeable.Garden.Plant3>());
            }
            else
            {
                yield return new Item(ModContent.ItemType<Items.Placeable.Garden.Plant4>());
            }
        }
    }
}