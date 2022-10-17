using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.Enums;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace DragonsDecorativeMod.Tiles
{
    public class PaintBottleSingle : ModTile
    {
        public override void SetStaticDefaults()
        {
            Main.tileFrameImportant[Type] = true;
            Main.tileNoAttach[Type] = true;
            Main.tileLavaDeath[Type] = true;


            TileObjectData.newTile.CopyFrom(TileObjectData.Style1x1);
            TileObjectData.newTile.AnchorBottom = new AnchorData(AnchorType.Table, TileObjectData.newTile.Width, 0);
            TileObjectData.newTile.StyleHorizontal = true;
            TileObjectData.newTile.RandomStyleRange = 10;
            TileObjectData.newTile.StyleMultiplier = 10;

            TileObjectData.addTile(Type);

            ModTranslation name = CreateMapEntryName();
            name.SetDefault("Paint Bottle");
            AddMapEntry(new Color(255, 0, 0), name);
            AddMapEntry(new Color(255, 127, 0), name);
            AddMapEntry(new Color(255, 255, 0), name);
            AddMapEntry(new Color(0, 255, 0), name);
            AddMapEntry(new Color(0, 255, 255), name);
            AddMapEntry(new Color(0, 0, 255), name);
            AddMapEntry(new Color(128, 0, 255), name);
            AddMapEntry(new Color(255, 0, 255), name);
            AddMapEntry(new Color(0, 0, 0), name);
            AddMapEntry(new Color(255, 255, 255), name);
        }

        public override ushort GetMapOption(int i, int j)
        {
            return (ushort)(Main.tile[i, j].TileFrameX / 18);
        }

        public override bool Drop(int i, int j)
        {
            Item.NewItem(new EntitySource_TileBreak(i, j), i * 16, j * 16, 16, 16, ModContent.ItemType<Items.PaintBottleSingle>());
            return true;
        }
    }
}