using Microsoft.Xna.Framework;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace DragonsDecorativeMod.Content.Tiles.Other
{
    public class StaringStatue : ModTile
    {
        private Vector2 look_direction = Vector2.Zero;

        public override void SetStaticDefaults()
        {
            StaringStatueHelpers.SetTileInfo(Type);
            AnimationFrameHeight = 54;
            DustType = DustID.Stone;
            LocalizedText name = CreateMapEntryName();
            AddMapEntry(new Color(120, 120, 120), name);
        }

        public override void NearbyEffects(int i, int j, bool closer)
        {
            if (!StaringStatueHelpers.NearbyEffects(i, j, closer, ref look_direction))
            {
                return;
            }
        }
    }

    public class StaringStatueUpLeft : ModTile
    {
        public override string Texture => "DragonsDecorativeMod/Content/Tiles/Other/StaringStatueUpLeft";
        private Vector2 look_direction = Vector2.Zero;

        public override void SetStaticDefaults()
        {
            StaringStatueHelpers.SetTileInfo(Type);
            AnimationFrameHeight = 54;
            DustType = DustID.Stone;
            LocalizedText name = CreateMapEntryName();
            AddMapEntry(new Color(120, 120, 120), name);
        }

        public override void NearbyEffects(int i, int j, bool closer)
        {
            if (!StaringStatueHelpers.NearbyEffects(i, j, closer, ref look_direction))
            {
                return;
            }
        }

        public override IEnumerable<Item> GetItemDrops(int i, int j)
        {
            yield return new Item(ItemType<Content.Items.Placeable.Other.StaringStatue>());
        }
    }

    public class StaringStatueUp : ModTile
    {
        public override string Texture => "DragonsDecorativeMod/Content/Tiles/Other/StaringStatueUp";
        private Vector2 look_direction = Vector2.Zero;

        public override void SetStaticDefaults()
        {
            StaringStatueHelpers.SetTileInfo(Type);
            AnimationFrameHeight = 54;
            DustType = DustID.Stone;
            LocalizedText name = CreateMapEntryName();
            AddMapEntry(new Color(120, 120, 120), name);
        }

        public override void NearbyEffects(int i, int j, bool closer)
        {
            if (!StaringStatueHelpers.NearbyEffects(i, j, closer, ref look_direction))
            {
                return;
            }
        }

        public override IEnumerable<Item> GetItemDrops(int i, int j)
        {
            yield return new Item(ItemType<Content.Items.Placeable.Other.StaringStatue>());
        }
    }

    public class StaringStatueUpRight : ModTile
    {
        public override string Texture => "DragonsDecorativeMod/Content/Tiles/Other/StaringStatueUpRight";
        private Vector2 look_direction = Vector2.Zero;

        public override void SetStaticDefaults()
        {
            StaringStatueHelpers.SetTileInfo(Type);
            AnimationFrameHeight = 54;
            DustType = DustID.Stone;
            LocalizedText name = CreateMapEntryName();
            AddMapEntry(new Color(120, 120, 120), name);
        }

        public override void NearbyEffects(int i, int j, bool closer)
        {
            if (!StaringStatueHelpers.NearbyEffects(i, j, closer, ref look_direction))
            {
                return;
            }
        }

        public override IEnumerable<Item> GetItemDrops(int i, int j)
        {
            yield return new Item(ItemType<Content.Items.Placeable.Other.StaringStatue>());
        }
    }

    public class StaringStatueLeft : ModTile
    {
        public override string Texture => "DragonsDecorativeMod/Content/Tiles/Other/StaringStatueLeft";
        private Vector2 look_direction = Vector2.Zero;

        public override void SetStaticDefaults()
        {
            StaringStatueHelpers.SetTileInfo(Type);
            AnimationFrameHeight = 54;
            DustType = DustID.Stone;
            LocalizedText name = CreateMapEntryName();
            AddMapEntry(new Color(120, 120, 120), name);
        }

        public override void NearbyEffects(int i, int j, bool closer)
        {
            if (!StaringStatueHelpers.NearbyEffects(i, j, closer, ref look_direction))
            {
                return;
            }
        }

        public override IEnumerable<Item> GetItemDrops(int i, int j)
        {
            yield return new Item(ItemType<Content.Items.Placeable.Other.StaringStatue>());
        }
    }

    public class StaringStatueRight : ModTile
    {
        public override string Texture => "DragonsDecorativeMod/Content/Tiles/Other/StaringStatueRight";
        private Vector2 look_direction = Vector2.Zero;

        public override void SetStaticDefaults()
        {
            StaringStatueHelpers.SetTileInfo(Type);
            AnimationFrameHeight = 54;
            DustType = DustID.Stone;
            LocalizedText name = CreateMapEntryName();
            AddMapEntry(new Color(120, 120, 120), name);
        }

        public override void NearbyEffects(int i, int j, bool closer)
        {
            if (!StaringStatueHelpers.NearbyEffects(i, j, closer, ref look_direction))
            {
                return;
            }
        }

        public override IEnumerable<Item> GetItemDrops(int i, int j)
        {
            yield return new Item(ItemType<Content.Items.Placeable.Other.StaringStatue>());
        }
    }

    public class StaringStatueDownLeft : ModTile
    {
        public override string Texture => "DragonsDecorativeMod/Content/Tiles/Other/StaringStatueDownLeft";
        private Vector2 look_direction = Vector2.Zero;

        public override void SetStaticDefaults()
        {
            StaringStatueHelpers.SetTileInfo(Type);
            AnimationFrameHeight = 54;
            DustType = DustID.Stone;
            LocalizedText name = CreateMapEntryName();
            AddMapEntry(new Color(120, 120, 120), name);
        }

        public override void NearbyEffects(int i, int j, bool closer)
        {
            if (!StaringStatueHelpers.NearbyEffects(i, j, closer, ref look_direction))
            {
                return;
            }
        }

        public override IEnumerable<Item> GetItemDrops(int i, int j)
        {
            yield return new Item(ItemType<Content.Items.Placeable.Other.StaringStatue>());
        }
    }

    public class StaringStatueDown : ModTile
    {
        public override string Texture => "DragonsDecorativeMod/Content/Tiles/Other/StaringStatueDown";
        private Vector2 look_direction = Vector2.Zero;

        public override void SetStaticDefaults()
        {
            StaringStatueHelpers.SetTileInfo(Type);
            AnimationFrameHeight = 54;
            DustType = DustID.Stone;
            LocalizedText name = CreateMapEntryName();
            AddMapEntry(new Color(120, 120, 120), name);
        }

        public override void NearbyEffects(int i, int j, bool closer)
        {
            if (!StaringStatueHelpers.NearbyEffects(i, j, closer, ref look_direction))
            {
                return;
            }
        }

        public override IEnumerable<Item> GetItemDrops(int i, int j)
        {
            yield return new Item(ItemType<Content.Items.Placeable.Other.StaringStatue>());
        }
    }

    public class StaringStatueDownRight : ModTile
    {
        public override string Texture => "DragonsDecorativeMod/Content/Tiles/Other/StaringStatueDownRight";
        private Vector2 look_direction = Vector2.Zero;

        public override void SetStaticDefaults()
        {
            StaringStatueHelpers.SetTileInfo(Type);
            AnimationFrameHeight = 54;
            DustType = DustID.Stone;
            LocalizedText name = CreateMapEntryName();
            AddMapEntry(new Color(120, 120, 120), name);
        }

        public override void NearbyEffects(int i, int j, bool closer)
        {
            if (!StaringStatueHelpers.NearbyEffects(i, j, closer, ref look_direction))
            {
                return;
            }
        }

        public override IEnumerable<Item> GetItemDrops(int i, int j)
        {
            yield return new Item(ItemType<Content.Items.Placeable.Other.StaringStatue>());
        }
    }
}