using Microsoft.Xna.Framework;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.ObjectData;
using static Terraria.ModLoader.ModContent;

namespace DragonsDecorativeMod.Content.Tiles.Other
{
    public class MedusaWatching : ModTile
    {
        private Vector2 look_direction = Vector2.Zero;

        public override void SetStaticDefaults()
        {
            Main.tileFrameImportant[Type] = true;
            Main.tileNoAttach[Type] = true;
            Main.tileLavaDeath[Type] = true;
            TileID.Sets.FramesOnKillWall[Type] = true;

            TileObjectData.newTile.CopyFrom(TileObjectData.Style3x3Wall);
            TileObjectData.newTile.Height = 4;
            TileObjectData.newTile.CoordinateHeights = [16, 16, 16, 16];
            TileObjectData.addTile(Type);

            AnimationFrameHeight = 72;

            LocalizedText name = CreateMapEntryName();
            AddMapEntry(new Color(58, 62, 53), name);

            DustType = DustID.WoodFurniture;
        }

        public override void NearbyEffects(int i, int j, bool closer)
        {
            if (!MedusaWatchingHelpers.NearbyEffects(i, j, closer, ref look_direction))
            {
                return;
            }
        }
    }

    public class MedusaWatchingUpLeft : ModTile
    {
        public override string Texture => "DragonsDecorativeMod/Content/Tiles/Other/MedusaWatchingUpLeft";
        private Vector2 look_direction = Vector2.Zero;

        public override void SetStaticDefaults()
        {
            Main.tileFrameImportant[Type] = true;
            Main.tileNoAttach[Type] = true;
            Main.tileLavaDeath[Type] = true;
            TileID.Sets.FramesOnKillWall[Type] = true;

            TileObjectData.newTile.CopyFrom(TileObjectData.Style3x3Wall);
            TileObjectData.newTile.Height = 4;
            TileObjectData.newTile.CoordinateHeights = [16, 16, 16, 16];
            TileObjectData.addTile(Type);

            AnimationFrameHeight = 72;

            LocalizedText name = CreateMapEntryName();
            AddMapEntry(new Color(58, 62, 53), name);

            DustType = DustID.WoodFurniture;
        }

        public override void NearbyEffects(int i, int j, bool closer)
        {
            if (!MedusaWatchingHelpers.NearbyEffects(i, j, closer, ref look_direction))
            {
                return;
            }
        }

        public override IEnumerable<Item> GetItemDrops(int i, int j)
        {
            yield return new Item(ItemType<Content.Items.Placeable.Other.MedusaWatching>());
        }
    }

    public class MedusaWatchingUp : ModTile
    {
        public override string Texture => "DragonsDecorativeMod/Content/Tiles/Other/MedusaWatchingUp";
        private Vector2 look_direction = Vector2.Zero;

        public override void SetStaticDefaults()
        {
            Main.tileFrameImportant[Type] = true;
            Main.tileNoAttach[Type] = true;
            Main.tileLavaDeath[Type] = true;
            TileID.Sets.FramesOnKillWall[Type] = true;

            TileObjectData.newTile.CopyFrom(TileObjectData.Style3x3Wall);
            TileObjectData.newTile.Height = 4;
            TileObjectData.newTile.CoordinateHeights = [16, 16, 16, 16];
            TileObjectData.addTile(Type);

            AnimationFrameHeight = 72;

            LocalizedText name = CreateMapEntryName();
            AddMapEntry(new Color(58, 62, 53), name);

            DustType = DustID.WoodFurniture;
        }

        public override void NearbyEffects(int i, int j, bool closer)
        {
            if (!MedusaWatchingHelpers.NearbyEffects(i, j, closer, ref look_direction))
            {
                return;
            }
        }

        public override IEnumerable<Item> GetItemDrops(int i, int j)
        {
            yield return new Item(ItemType<Content.Items.Placeable.Other.MedusaWatching>());
        }
    }

    public class MedusaWatchingUpRight : ModTile
    {
        public override string Texture => "DragonsDecorativeMod/Content/Tiles/Other/MedusaWatchingUpRight";
        private Vector2 look_direction = Vector2.Zero;

        public override void SetStaticDefaults()
        {
            Main.tileFrameImportant[Type] = true;
            Main.tileNoAttach[Type] = true;
            Main.tileLavaDeath[Type] = true;
            TileID.Sets.FramesOnKillWall[Type] = true;

            TileObjectData.newTile.CopyFrom(TileObjectData.Style3x3Wall);
            TileObjectData.newTile.Height = 4;
            TileObjectData.newTile.CoordinateHeights = [16, 16, 16, 16];
            TileObjectData.addTile(Type);

            AnimationFrameHeight = 72;

            LocalizedText name = CreateMapEntryName();
            AddMapEntry(new Color(58, 62, 53), name);

            DustType = DustID.WoodFurniture;
        }

        public override void NearbyEffects(int i, int j, bool closer)
        {
            if (!MedusaWatchingHelpers.NearbyEffects(i, j, closer, ref look_direction))
            {
                return;
            }
        }

        public override IEnumerable<Item> GetItemDrops(int i, int j)
        {
            yield return new Item(ItemType<Content.Items.Placeable.Other.MedusaWatching>());
        }
    }

    public class MedusaWatchingLeft : ModTile
    {
        public override string Texture => "DragonsDecorativeMod/Content/Tiles/Other/MedusaWatchingLeft";
        private Vector2 look_direction = Vector2.Zero;

        public override void SetStaticDefaults()
        {
            Main.tileFrameImportant[Type] = true;
            Main.tileNoAttach[Type] = true;
            Main.tileLavaDeath[Type] = true;
            TileID.Sets.FramesOnKillWall[Type] = true;

            TileObjectData.newTile.CopyFrom(TileObjectData.Style3x3Wall);
            TileObjectData.newTile.Height = 4;
            TileObjectData.newTile.CoordinateHeights = [16, 16, 16, 16];
            TileObjectData.addTile(Type);

            AnimationFrameHeight = 72;

            LocalizedText name = CreateMapEntryName();
            AddMapEntry(new Color(58, 62, 53), name);

            DustType = DustID.WoodFurniture;
        }

        public override void NearbyEffects(int i, int j, bool closer)
        {
            if (!MedusaWatchingHelpers.NearbyEffects(i, j, closer, ref look_direction))
            {
                return;
            }
        }

        public override IEnumerable<Item> GetItemDrops(int i, int j)
        {
            yield return new Item(ItemType<Content.Items.Placeable.Other.MedusaWatching>());
        }
    }

    public class MedusaWatchingRight : ModTile
    {
        public override string Texture => "DragonsDecorativeMod/Content/Tiles/Other/MedusaWatchingRight";
        private Vector2 look_direction = Vector2.Zero;

        public override void SetStaticDefaults()
        {
            Main.tileFrameImportant[Type] = true;
            Main.tileNoAttach[Type] = true;
            Main.tileLavaDeath[Type] = true;
            TileID.Sets.FramesOnKillWall[Type] = true;

            TileObjectData.newTile.CopyFrom(TileObjectData.Style3x3Wall);
            TileObjectData.newTile.Height = 4;
            TileObjectData.newTile.CoordinateHeights = [16, 16, 16, 16];
            TileObjectData.addTile(Type);

            AnimationFrameHeight = 72;

            LocalizedText name = CreateMapEntryName();
            AddMapEntry(new Color(58, 62, 53), name);

            DustType = DustID.WoodFurniture;
        }

        public override void NearbyEffects(int i, int j, bool closer)
        {
            if (!MedusaWatchingHelpers.NearbyEffects(i, j, closer, ref look_direction))
            {
                return;
            }
        }

        public override IEnumerable<Item> GetItemDrops(int i, int j)
        {
            yield return new Item(ItemType<Content.Items.Placeable.Other.MedusaWatching>());
        }
    }

    public class MedusaWatchingDownLeft : ModTile
    {
        public override string Texture => "DragonsDecorativeMod/Content/Tiles/Other/MedusaWatchingDownLeft";
        private Vector2 look_direction = Vector2.Zero;

        public override void SetStaticDefaults()
        {
            Main.tileFrameImportant[Type] = true;
            Main.tileNoAttach[Type] = true;
            Main.tileLavaDeath[Type] = true;
            TileID.Sets.FramesOnKillWall[Type] = true;

            TileObjectData.newTile.CopyFrom(TileObjectData.Style3x3Wall);
            TileObjectData.newTile.Height = 4;
            TileObjectData.newTile.CoordinateHeights = [16, 16, 16, 16];
            TileObjectData.addTile(Type);

            AnimationFrameHeight = 72;

            LocalizedText name = CreateMapEntryName();
            AddMapEntry(new Color(58, 62, 53), name);

            DustType = DustID.WoodFurniture;
        }

        public override void NearbyEffects(int i, int j, bool closer)
        {
            if (!MedusaWatchingHelpers.NearbyEffects(i, j, closer, ref look_direction))
            {
                return;
            }
        }

        public override IEnumerable<Item> GetItemDrops(int i, int j)
        {
            yield return new Item(ItemType<Content.Items.Placeable.Other.MedusaWatching>());
        }
    }

    public class MedusaWatchingDown : ModTile
    {
        public override string Texture => "DragonsDecorativeMod/Content/Tiles/Other/MedusaWatchingDown";
        private Vector2 look_direction = Vector2.Zero;

        public override void SetStaticDefaults()
        {
            Main.tileFrameImportant[Type] = true;
            Main.tileNoAttach[Type] = true;
            Main.tileLavaDeath[Type] = true;
            TileID.Sets.FramesOnKillWall[Type] = true;

            TileObjectData.newTile.CopyFrom(TileObjectData.Style3x3Wall);
            TileObjectData.newTile.Height = 4;
            TileObjectData.newTile.CoordinateHeights = [16, 16, 16, 16];
            TileObjectData.addTile(Type);

            AnimationFrameHeight = 72;

            LocalizedText name = CreateMapEntryName();
            AddMapEntry(new Color(58, 62, 53), name);

            DustType = DustID.WoodFurniture;
        }

        public override void NearbyEffects(int i, int j, bool closer)
        {
            if (!MedusaWatchingHelpers.NearbyEffects(i, j, closer, ref look_direction))
            {
                return;
            }
        }

        public override IEnumerable<Item> GetItemDrops(int i, int j)
        {
            yield return new Item(ItemType<Content.Items.Placeable.Other.MedusaWatching>());
        }
    }

    public class MedusaWatchingDownRight : ModTile
    {
        public override string Texture => "DragonsDecorativeMod/Content/Tiles/Other/MedusaWatchingDownRight";
        private Vector2 look_direction = Vector2.Zero;

        public override void SetStaticDefaults()
        {
            Main.tileFrameImportant[Type] = true;
            Main.tileNoAttach[Type] = true;
            Main.tileLavaDeath[Type] = true;
            TileID.Sets.FramesOnKillWall[Type] = true;

            TileObjectData.newTile.CopyFrom(TileObjectData.Style3x3Wall);
            TileObjectData.newTile.Height = 4;
            TileObjectData.newTile.CoordinateHeights = [16, 16, 16, 16];
            TileObjectData.addTile(Type);

            AnimationFrameHeight = 72;

            LocalizedText name = CreateMapEntryName();
            AddMapEntry(new Color(58, 62, 53), name);

            DustType = DustID.WoodFurniture;
        }

        public override void NearbyEffects(int i, int j, bool closer)
        {
            if (!MedusaWatchingHelpers.NearbyEffects(i, j, closer, ref look_direction))
            {
                return;
            }
        }

        public override IEnumerable<Item> GetItemDrops(int i, int j)
        {
            yield return new Item(ItemType<Content.Items.Placeable.Other.MedusaWatching>());
        }
    }
}