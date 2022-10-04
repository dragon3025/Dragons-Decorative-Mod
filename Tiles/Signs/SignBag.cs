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
            Main.tileSign[Type] = true;
            Main.tileFrameImportant[Type] = true;
            Main.tileNoAttach[Type] = true;
            Main.tileLavaDeath[Type] = true;

            /*
            //newTile.Width = 2;
            //newTile.Height = 2;
            //newTile.Origin = new Point16(0, 1);
            //newTile.AnchorBottom = new AnchorData(AnchorType.SolidTile | AnchorType.SolidWithTop | AnchorType.Table | AnchorType.SolidSide, newTile.Width, 0);
            //newTile.UsesCustomCanPlace = true;
            //newTile.CoordinateHeights = new int[2] { 16, 16 };
            //newTile.CoordinateWidth = 16;
            //newTile.CoordinatePadding = 2;
            //newTile.LavaDeath = true;
            //addBaseTile(out Style2x2);
            */

            // Defaults
            TileObjectData.newTile.CopyFrom(TileObjectData.Style2x2);

            // Allow hanging from ceilings
            TileObjectData.newAlternate.CopyFrom(TileObjectData.newTile);
            TileObjectData.newAlternate.StyleHorizontal = true;
            TileObjectData.newAlternate.AnchorAlternateTiles = new int[] { 124 };
            TileObjectData.newAlternate.Origin = new Point16(0, 0);
            TileObjectData.newAlternate.AnchorLeft = AnchorData.Empty;
            TileObjectData.newAlternate.AnchorRight = AnchorData.Empty;
            TileObjectData.newAlternate.AnchorTop = new AnchorData(AnchorType.SolidTile | AnchorType.SolidBottom, TileObjectData.newTile.Width, 0);
            TileObjectData.newAlternate.AnchorBottom = AnchorData.Empty;
            TileObjectData.addAlternate(1);

            // Allow attaching to a solid object that is to the left of the sign
            TileObjectData.newAlternate.CopyFrom(TileObjectData.newTile);
            TileObjectData.newAlternate.StyleHorizontal = true;
            TileObjectData.newAlternate.AnchorAlternateTiles = new int[] { 124 };
            TileObjectData.newAlternate.Origin = new Point16(0, 0);
            TileObjectData.newAlternate.AnchorLeft = new AnchorData(AnchorType.SolidTile | AnchorType.SolidSide | AnchorType.Tree, TileObjectData.newTile.Width, 0);
            TileObjectData.newAlternate.AnchorBottom = AnchorData.Empty;
            TileObjectData.addAlternate(2);

            // Allow attaching to a solid object that is to the right of the sign
            TileObjectData.newAlternate.CopyFrom(TileObjectData.newTile);
            TileObjectData.newAlternate.StyleHorizontal = true;
            TileObjectData.newAlternate.AnchorAlternateTiles = new int[] { 124 };
            TileObjectData.newAlternate.Origin = new Point16(0, 0);
            TileObjectData.newAlternate.AnchorRight = new AnchorData(AnchorType.SolidTile | AnchorType.SolidSide | AnchorType.Tree, TileObjectData.newTile.Width, 0);
            TileObjectData.newAlternate.AnchorBottom = AnchorData.Empty;
            TileObjectData.addAlternate(3);

            // Allow attaching to a wall behind the sign
            TileObjectData.newAlternate.CopyFrom(TileObjectData.newTile);
            TileObjectData.newAlternate.StyleHorizontal = true;
            TileObjectData.newAlternate.AnchorAlternateTiles = new int[] { 124 };
            TileObjectData.newAlternate.Origin = new Point16(0, 0);
            TileObjectData.newAlternate.AnchorWall = true;
            TileObjectData.newAlternate.AnchorBottom = AnchorData.Empty;
            TileObjectData.addAlternate(4);

            // Allow attaching sign to the ground
            TileObjectData.newAlternate.CopyFrom(TileObjectData.newTile);
            TileObjectData.newAlternate.StyleHorizontal = true;
            TileObjectData.newAlternate.AnchorAlternateTiles = new int[] { 124 };
            TileObjectData.newAlternate.Origin = new Point16(0, 0);
            TileObjectData.addAlternate(0);
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