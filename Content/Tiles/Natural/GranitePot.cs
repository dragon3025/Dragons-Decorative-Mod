using Microsoft.Xna.Framework;
using System.Collections.Generic;
using Terraria;
using Terraria.GameContent;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;
using static Terraria.ModLoader.ModContent;

namespace DragonsDecorativeMod.Content.Tiles.Natural
{
    public class GranitePot : ModTile
    {
        public override void SetStaticDefaults()
        {
            Main.tileFrameImportant[Type] = true;
            Main.tileNoAttach[Type] = true;
            Main.tileLavaDeath[Type] = true;

            TileObjectData.newTile.CopyFrom(TileObjectData.Style2x2);
            TileObjectData.newTile.DrawYOffset = 2;
            TileObjectData.newTile.StyleHorizontal = true;
            TileObjectData.newTile.StyleWrapLimit = 3;
            TileObjectData.addTile(Type);

            AddMapEntry(new Color(128, 128, 128));

            HitSound = SoundID.Shatter;
            DustType = DustID.Granite;

            if (!GetInstance<Configuration.Natural>().GranitePots)
            {
                return;
            }

            // In 1.4.5+ switch this to the Portable Kiln.
            FlexibleTileWand.RubblePlacementMedium.AddVariations(ItemID.Granite, Type, 0, 1, 2);
        }

        public override IEnumerable<Item> GetItemDrops(int i, int j)
        {
            yield return new Item(ItemID.Granite);
        }
    }
}