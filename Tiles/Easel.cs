using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace DragonsDecorativeMod.Tiles
{
    public class Easel : ModTile
    {
        public override void SetStaticDefaults()
        {
            Main.tileFrameImportant[Type] = true;
            Main.tileNoAttach[Type] = true;
            Main.tileLavaDeath[Type] = true;

            TileObjectData.newTile.CopyFrom(TileObjectData.Style2xX);
            TileObjectData.addTile(Type);

            LocalizedText name = CreateMapEntryName();
            // name.SetDefault("Easel");
            AddMapEntry(new Color(230, 219, 212), name);
        }
    }
}