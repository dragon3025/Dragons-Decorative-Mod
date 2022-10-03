/*
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria;
using Terraria.DataStructures;
using Terraria.Enums;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;
using static Terraria.ModLoader.ModContent;

namespace DragonsDecorativeMod.Tiles.Signs
{
    public class SignCross : ModTile
    {
        public override void SetStaticDefaults()
        {
            Main.tileFrameImportant[Type] = true;
            Main.tileNoAttach[Type] = true;
            Main.tileLavaDeath[Type] = true;

            //newTile.Width = 1;
            //newTile.Height = 1;
            //newTile.Origin = new Point16(0, 0);
            //newTile.FlattenAnchors = true;
            //newTile.UsesCustomCanPlace = false;
            //newTile.CoordinateHeights = new int[1] { 20 };
            //newTile.DrawStepDown = 2;
            //newTile.CoordinateWidth = 20;
            //newTile.CoordinatePadding = 2;
            //newTile.StyleMultiplier = 6;
            //newTile.StyleWrapLimit = 6;
            //newTile.StyleHorizontal = true;
            //newTile.WaterPlacement = LiquidPlacement.NotAllowed;
            //newTile.LavaPlacement = LiquidPlacement.NotAllowed;
            //newTile.WaterDeath = true;
            //newTile.LavaDeath = true;
            //addBaseTile(out StyleTorch);

            TileObjectData.newTile.CopyFrom(TileObjectData.StyleTorch);
            TileObjectData.newTile.StyleHorizontal = true;
            TileObjectData.newTile.Width= 3;
            TileObjectData.newTile.Height= 3;
            TileObjectData.newTile.CoordinateWidth = 16;
            TileObjectData.newTile.CoordinateHeights = new int[] { 16, 16, 16 };
            TileObjectData.newTile.Origin = new Point16(0, 0);
            TileObjectData.newTile.UsesCustomCanPlace = true;

            GetInstance<DragonsDecorativeMod>().Logger.Debug("TileObjectData.newTile.Height: " + TileObjectData.newTile.Height.ToString());

            TileObjectData.newTile.AnchorLeft = new AnchorData(AnchorType.SolidTile | AnchorType.SolidSide | AnchorType.Tree | AnchorType.AlternateTile, TileObjectData.newTile.Height, 0);
            TileObjectData.newTile.AnchorAlternateTiles = new int[] { ItemID.WoodenBeam };

            TileObjectData.newAlternate.CopyFrom(TileObjectData.StyleTorch);
            TileObjectData.newAlternate.Width= 3;
            TileObjectData.newAlternate.Height= 3;
            TileObjectData.newAlternate.CoordinateWidth = 16;
            TileObjectData.newAlternate.CoordinateHeights = new int[] { 16, 16, 16 };
            TileObjectData.newAlternate.Origin = new Point16(2, 0);
            TileObjectData.newAlternate.UsesCustomCanPlace = true;
            TileObjectData.newAlternate.AnchorRight = new AnchorData(AnchorType.SolidTile | AnchorType.SolidSide | AnchorType.Tree | AnchorType.AlternateTile, TileObjectData.newTile.Height, 0);
            TileObjectData.newAlternate.AnchorAlternateTiles = new int[] { ItemID.WoodenBeam };
            TileObjectData.addAlternate(1);

            TileObjectData.newAlternate.CopyFrom(TileObjectData.StyleTorch);
            TileObjectData.newAlternate.Width= 3;
            TileObjectData.newAlternate.Height= 3;
            TileObjectData.newAlternate.CoordinateWidth = 16;
            TileObjectData.newAlternate.CoordinateHeights = new int[] { 16, 16, 16 };
            TileObjectData.newAlternate.Origin = new Point16(1, 2);
            TileObjectData.newAlternate.AnchorBottom = new AnchorData(AnchorType.SolidTile | AnchorType.SolidSide, TileObjectData.newTile.Width, 0);
            TileObjectData.addAlternate(2);

            TileObjectData.newAlternate.CopyFrom(TileObjectData.StyleTorch);
            TileObjectData.newAlternate.Width= 3;
            TileObjectData.newAlternate.Height= 3;
            TileObjectData.newAlternate.CoordinateWidth = 16;
            TileObjectData.newAlternate.CoordinateHeights = new int[] { 16, 16, 16 };
            TileObjectData.newAlternate.Origin = new Point16(1, 0);
            TileObjectData.newAlternate.AnchorTop = new AnchorData(AnchorType.SolidTile | AnchorType.SolidSide, TileObjectData.newTile.Width, 0);
            TileObjectData.newAlternate.AnchorBottom = AnchorData.Empty;
            TileObjectData.addAlternate(3);

            TileObjectData.newAlternate.CopyFrom(TileObjectData.StyleTorch);
            TileObjectData.newAlternate.Width= 3;
            TileObjectData.newAlternate.Height= 3;
            TileObjectData.newAlternate.CoordinateWidth = 16;
            TileObjectData.newAlternate.CoordinateHeights = new int[] { 16, 16, 16 };
            TileObjectData.newAlternate.Origin = new Point16(1, 1);
            TileObjectData.newAlternate.AnchorWall = true;
            TileObjectData.addAlternate(4);

            TileObjectData.addTile(Type);

            AddMapEntry(new Color(127, 127, 127));

            TileID.Sets.DisableSmartCursor[Type] = true;
        }

        public override void KillMultiTile(int x, int y, int frameX, int frameY)
        {
            Item.NewItem(new EntitySource_TileBreak(x, y), x * 16, y * 16, 48, 48, ModContent.ItemType<Items.Signs.SignCross>());
        }
    }
}
*/