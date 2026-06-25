using Microsoft.Xna.Framework;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.ObjectData;
using static Terraria.ModLoader.ModContent;

namespace DragonsDecorativeMod.Content.Tiles
{
    public class CraftingKeyBenchDisabled : ModTile
    {
        public override void SetStaticDefaults()
        {
            // Properties
            Main.tileTable[Type] = true;
            Main.tileSolidTop[Type] = true;
            Main.tileNoAttach[Type] = true;
            Main.tileLavaDeath[Type] = true;
            Main.tileFrameImportant[Type] = true;
            TileID.Sets.DisableSmartCursor[Type] = true;
            TileID.Sets.IgnoredByNpcStepUp[Type] = true; // This line makes NPCs not try to step up this tile during their movement. Only use this for furniture with solid tops.

            DustType = DustID.Marble;
            AdjTiles = [TileID.WorkBenches];

            // Placement
            TileObjectData.newTile.CopyFrom(TileObjectData.Style2x1);
            TileObjectData.newTile.CoordinateHeights = [18];
            TileObjectData.addTile(Type);

            AddToArray(ref TileID.Sets.RoomNeeds.CountsAsTable);

            // Etc
            LocalizedText name = CreateMapEntryName();
            AddMapEntry(new Color(118, 143, 148), name);
        }

        public override void HitWire(int i, int j)
        {
            CraftingKeyBench.ToggleCraftingKeyBench(i, j, TileType<CraftingKeyBench>());
        }

        public override IEnumerable<Item> GetItemDrops(int i, int j)
        {
            yield return new Item(ItemType<Items.CraftingKey>());
        }
    }
}
