using Microsoft.Xna.Framework;
using System.Collections.Generic;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace DragonsDecorativeMod.Tiles
{
    public class BoxOfArrows : ModTile
    {
        public override void SetStaticDefaults()
        {
            Main.tileFrameImportant[Type] = true;
            Main.tileNoAttach[Type] = true;
            Main.tileLavaDeath[Type] = true;

            TileObjectData.newTile.CopyFrom(TileObjectData.Style2x2);
            TileObjectData.addTile(Type);

            LocalizedText name = CreateMapEntryName();
            // name.SetDefault("Box of Arrows");
            AddMapEntry(new Color(139, 129, 120), name);
        }

        public override IEnumerable<Item> GetItemDrops(int i, int j)
        {
            yield return new Item(ItemID.Wood, 4);
            yield return new Item(ItemID.WoodenArrow, 30);
        }
    }
}