using DragonsDecorativeMod.Configuration;
using Microsoft.Xna.Framework;
using System.Collections.Generic;
using Terraria;
using Terraria.GameContent;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;
using static Terraria.ModLoader.ModContent;

namespace DragonsDecorativeMod.Tiles.Natural
{
    public class FakePot : ModTile
    {
        readonly static DragonsDecoModConfig furnitureConfig = GetInstance<DragonsDecoModConfig>();

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


            if (!furnitureConfig.Natural.Pots)
            {
                return;
            }

            FlexibleTileWand.RubblePlacementMedium.AddVariations(ItemID.ClayBlock, Type, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11);
            FlexibleTileWand.RubblePlacementMedium.AddVariations(ItemID.IceBlock, Type, 12, 13, 14, 15, 16, 17, 18, 19, 20);
            FlexibleTileWand.RubblePlacementMedium.AddVariations(ItemID.MudBlock, Type, 21, 22, 23, 24, 25, 26, 27, 28, 29);
            FlexibleTileWand.RubblePlacementMedium.AddVariations(ItemID.Bone, Type, 30, 31, 32, 33, 34, 35, 36, 37, 38);
            FlexibleTileWand.RubblePlacementMedium.AddVariations(ItemID.Obsidian, Type, 39, 40, 41, 42, 43, 44, 45, 46, 47);
            FlexibleTileWand.RubblePlacementMedium.AddVariations(ItemID.EbonstoneBlock, Type, 48, 49, 50, 51, 52, 53, 54, 55, 56);
            FlexibleTileWand.RubblePlacementMedium.AddVariations(ItemID.Cobweb, Type, 57, 58, 59, 60, 61, 62, 63, 64, 65);
            FlexibleTileWand.RubblePlacementMedium.AddVariations(ItemID.CrimstoneBlock, Type, 66, 67, 68);
            FlexibleTileWand.RubblePlacementMedium.AddVariations(ItemID.Sandstone, Type, 69, 70, 71, 72, 73, 74, 75, 76, 77, 78, 79, 80);
            FlexibleTileWand.RubblePlacementMedium.AddVariations(ItemID.LihzahrdBrick, Type, 81, 82, 83, 84, 85, 86);
            FlexibleTileWand.RubblePlacementMedium.AddVariations(ItemID.Marble, Type, 87, 88, 89);
            FlexibleTileWand.RubblePlacementMedium.AddVariations(ItemID.Granite, Type, 90, 91, 92);
        }

        public override bool KillSound(int i, int j, bool fail)
        {
            //Sounds from breaking pots found at WorldGen.cs > public static void CheckPot > line 48511
            HitSound = SoundID.Shatter;
            Tile tile = Main.tile[i, j];
            int frame = tile.TileFrameY / 36;
            if (frame > 6 && frame < 10)
            {
                HitSound = SoundID.Grass;
            }
            else if (frame > 15 && frame < 23)
            {
                HitSound = SoundID.NPCDeath1;
            }
            return true;
        }

        public override bool CreateDust(int i, int j, ref int type)
        {
            //Dust from pots found at WorldGen.cs > public static int KillTile_MakeTileDust > line 59908

            Tile tile = Main.tile[i, j];
            int frame = tile.TileFrameY / 36;

            if (frame < 2)
            {
                DustType = DustID.Clay;
            }
            else if (frame < 3)
            {
                DustType = DustID.Stone;
            }
            else if (frame < 4)
            {
                DustType = DustID.Clay;
            }
            else if (frame < 7)
            {
                DustType = DustID.Cobalt;
            }
            else if (frame < 10)
            {
                DustType = 85;
            }
            else if (frame < 13)
            {
                DustType = DustID.Bone;
            }
            else if (frame < 16)
            {
                DustType = DustID.Ash;
            }
            else if (frame < 22)
            {
                DustType = DustID.CorruptGibs;
            }
            else if (frame < 23)
            {
                DustType = DustID.Blood;
            }
            else if (frame < 24)
            {
                DustType = DustID.Dirt;
            }
            else if (frame < 27)
            {
                DustType = DustID.DesertPot;
            }
            else if (frame < 29)
            {
                DustType = DustID.t_Lihzahrd;
            }
            else if (frame < 30)
            {
                DustType = DustID.MarblePot;
            }
            else
            {
                DustType = DustID.Granite;
            }
            return true;
        }

        public override IEnumerable<Item> GetItemDrops(int i, int j)
        {
            Tile tile = Main.tile[i, j];
            int frame = tile.TileFrameY / 36;

            if (frame < 4)
            {
                yield return new Item(ItemID.ClayBlock);
            }
            else if (frame < 7)
            {
                yield return new Item(ItemID.IceBlock);
            }
            else if (frame < 10)
            {
                yield return new Item(ItemID.MudBlock);
            }
            else if (frame < 13)
            {
                yield return new Item(ItemID.Bone);
            }
            else if (frame < 16)
            {
                yield return new Item(ItemID.Obsidian);
            }
            else if (frame < 19)
            {
                yield return new Item(ItemID.EbonstoneBlock);
            }
            else if (frame < 22)
            {
                yield return new Item(ItemID.Cobweb);
            }
            else if (frame < 23)
            {
                yield return new Item(ItemID.CrimstoneBlock);
            }
            else if (frame < 27)
            {
                yield return new Item(ItemID.Sandstone);
            }
            else if (frame < 29)
            {
                yield return new Item(ItemID.LihzahrdBrick);
            }
            else if (frame < 30)
            {
                yield return new Item(ItemID.Marble);
            }
            else
            {
                yield return new Item(ItemID.Granite);
            }
        }
    }
}