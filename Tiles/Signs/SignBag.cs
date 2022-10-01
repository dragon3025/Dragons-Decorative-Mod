using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.Enums;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace DragonsDecorativeMod.Tiles.Signs
{
    public class SignBag : ModTile
    {
        public override void SetStaticDefaults()
        {
            Main.tileFrameImportant[Type] = true;
            Main.tileNoAttach[Type] = true;
            Main.tileLavaDeath[Type] = true;

            TileObjectData.newTile.CopyFrom(TileObjectData.StyleTorch);
            TileObjectData.newTile.StyleHorizontal = true;
            TileObjectData.newTile.Width = 2;
            TileObjectData.newTile.Height = 2;
            TileObjectData.newTile.CoordinateWidth = 16;
            TileObjectData.newTile.CoordinateHeights = new int[] { 16, 16 };
            TileObjectData.newTile.UsesCustomCanPlace = true;
            TileObjectData.newTile.AnchorLeft = new AnchorData(AnchorType.SolidTile | AnchorType.SolidSide | AnchorType.Tree | AnchorType.AlternateTile, TileObjectData.newTile.Height, 0);
            TileObjectData.newTile.AnchorAlternateTiles = new int[] { ItemID.WoodenBeam };

            TileObjectData.newAlternate.CopyFrom(TileObjectData.StyleTorch);
            TileObjectData.newAlternate.Width = 2;
            TileObjectData.newAlternate.Height = 2;
            TileObjectData.newAlternate.CoordinateWidth = 16;
            TileObjectData.newAlternate.CoordinateHeights = new int[] { 16, 16 };
            TileObjectData.newAlternate.UsesCustomCanPlace = true;
            TileObjectData.newAlternate.AnchorRight = new AnchorData(AnchorType.SolidTile | AnchorType.SolidSide | AnchorType.Tree | AnchorType.AlternateTile, TileObjectData.newTile.Height, 0);
            TileObjectData.newAlternate.AnchorAlternateTiles = new int[] { ItemID.WoodenBeam };
            TileObjectData.addAlternate(1);

            TileObjectData.newAlternate.CopyFrom(TileObjectData.StyleTorch);
            TileObjectData.newAlternate.Width = 2;
            TileObjectData.newAlternate.Height = 2;
            TileObjectData.newAlternate.CoordinateWidth = 16;
            TileObjectData.newAlternate.CoordinateHeights = new int[] { 16, 16 };
            TileObjectData.newAlternate.AnchorBottom = new AnchorData(AnchorType.SolidTile | AnchorType.SolidSide, TileObjectData.newTile.Width, 0);
            TileObjectData.addAlternate(2);

            TileObjectData.newAlternate.CopyFrom(TileObjectData.StyleTorch);
            TileObjectData.newAlternate.Width = 2;
            TileObjectData.newAlternate.Height = 2;
            TileObjectData.newAlternate.CoordinateWidth = 16;
            TileObjectData.newAlternate.CoordinateHeights = new int[] { 16, 16 };
            TileObjectData.newAlternate.AnchorTop = new AnchorData(AnchorType.SolidTile | AnchorType.SolidSide, TileObjectData.newTile.Width, 0);
            TileObjectData.newAlternate.AnchorBottom = AnchorData.Empty;
            TileObjectData.addAlternate(3);

            TileObjectData.newAlternate.CopyFrom(TileObjectData.StyleTorch);
            TileObjectData.newAlternate.Width = 2;
            TileObjectData.newAlternate.Height = 2;
            TileObjectData.newAlternate.CoordinateWidth = 16;
            TileObjectData.newAlternate.CoordinateHeights = new int[] { 16, 16 };
            TileObjectData.newAlternate.AnchorWall = true;
            TileObjectData.addAlternate(4);
            TileObjectData.addTile(Type);

            AddMapEntry(new Color(191, 142, 111));

            TileID.Sets.DisableSmartCursor[Type] = true;
        }

        public override void KillMultiTile(int x, int y, int frameX, int frameY)
        {
            Item.NewItem(new EntitySource_TileBreak(x, y), x * 16, y * 16, 32, 32, ModContent.ItemType<Items.Signs.SignBag>());
        }
    }
}