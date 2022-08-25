using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.DataStructures;
using Terraria.Enums;
using Terraria.ModLoader;
using Terraria.ObjectData;
using Terraria.ID;

namespace DragonsDecorativeMod.Tiles.Garden
{
    public class SingleTilePlant : ModTile
    {
        public override void SetStaticDefaults()
        {
            Main.tileFrameImportant[Type] = true;
            Main.tileLavaDeath[Type] = true;
            Main.tileTable[Type] = true;

            TileObjectData.newTile.CopyFrom(TileObjectData.Style1x1);
            TileObjectData.newTile.AnchorBottom = new AnchorData(AnchorType.SolidTile | AnchorType.SolidWithTop | AnchorType.Table | AnchorType.SolidSide, TileObjectData.newTile.Width, 0);
            TileObjectData.newTile.CoordinateHeights = new int[1] { 48 };
            TileObjectData.newTile.CoordinateWidth = 32;
            TileObjectData.newTile.DrawYOffset = -30;
            TileObjectData.newTile.StyleHorizontal = true;
            TileObjectData.addTile(Type);

            ModTranslation name = CreateMapEntryName();
            name.SetDefault("Plant");
            AddMapEntry(new Color(18, 86, 30), name);

            HitSound = SoundID.Grass;
            DustType = 0;

            //TileID.Sets.SwaysInWindBasic[Type] = true; TO-DO Setting this to true makes it move correctly, but the non-single tile variants will still act weird. Once tModLoader adds support for non-single wide tile swaying, set this to true (add "using Terraria.ID;").
        }

        public override bool Drop(int i, int j)
        {
            Tile t = Main.tile[i, j];
            int frame = t.TileFrameX / 34;
            int item = 0;

            if (frame == 0)
                item = ModContent.ItemType<Items.Garden.SingleTilePlant>();
            else if (frame == 1)
                item = ModContent.ItemType<Items.Garden.SingleTilePlant2>();
            else if (frame == 2)
                item = ModContent.ItemType<Items.Garden.SingleTilePlant3>();
            else if (frame == 3)
                item = ModContent.ItemType<Items.Garden.SingleTilePlant4>();

            if (item > 0)
                Item.NewItem(new EntitySource_TileBreak(i, j), i * 16, j * 16, 32, 48, item);

            return base.Drop(i, j);
        }

        public override void SetSpriteEffects(int i, int j, ref SpriteEffects spriteEffects)
        {
            if (i % 2 == 0)
                spriteEffects = SpriteEffects.FlipHorizontally;
        }
    }
}