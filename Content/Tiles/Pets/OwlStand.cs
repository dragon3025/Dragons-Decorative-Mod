using Microsoft.Xna.Framework;
using System.Collections.Generic;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace DragonsDecorativeMod.Content.Tiles.Pets
{
    public class OwlStand : ModTile
    {
        public override void SetStaticDefaults()
        {
            OwlStandHelpers.SetTileInfo(Type);
            AnimationFrameHeight = 54;
            DustType = -1;
            LocalizedText name = CreateMapEntryName();
            AddMapEntry(new Color(153, 103, 75), name);
        }

        public override void NearbyEffects(int i, int j, bool closer)
        {
            OwlStandHelpers.OwlSounds(i, j, closer);
        }

        public override void AnimateTile(ref int frame, ref int frameCounter)
        {
            OwlStandHelpers.OwlAnimations(ref frame, ref frameCounter);
        }
    }

    public class OwlStand2 : ModTile
    {
        public override string Texture => "DragonsDecorativeMod/Content/Tiles/Pets/OwlStand";

        public override void SetStaticDefaults()
        {
            OwlStandHelpers.SetTileInfo(Type);
            AnimationFrameHeight = 54;
            DustType = -1;
            LocalizedText name = CreateMapEntryName();
            AddMapEntry(new Color(153, 103, 75), name);
        }

        public override IEnumerable<Item> GetItemDrops(int i, int j)
        {
            yield return new Item(ItemType<Items.Placeable.Pets.OwlStand>());
        }

        public override void NearbyEffects(int i, int j, bool closer)
        {
            OwlStandHelpers.OwlSounds(i, j, closer);
        }

        public override void AnimateTile(ref int frame, ref int frameCounter)
        {
            OwlStandHelpers.OwlAnimations(ref frame, ref frameCounter);
        }
    }

    public class OwlStand3 : ModTile
    {
        public override string Texture => "DragonsDecorativeMod/Content/Tiles/Pets/OwlStand";

        public override void SetStaticDefaults()
        {
            OwlStandHelpers.SetTileInfo(Type);
            AnimationFrameHeight = 54;
            DustType = -1;
            LocalizedText name = CreateMapEntryName();
            AddMapEntry(new Color(153, 103, 75), name);
        }

        public override IEnumerable<Item> GetItemDrops(int i, int j)
        {
            yield return new Item(ItemType<Items.Placeable.Pets.OwlStand>());
        }

        public override void NearbyEffects(int i, int j, bool closer)
        {
            OwlStandHelpers.OwlSounds(i, j, closer);
        }

        public override void AnimateTile(ref int frame, ref int frameCounter)
        {
            OwlStandHelpers.OwlAnimations(ref frame, ref frameCounter);
        }
    }

    public class OwlStand4 : ModTile
    {
        public override string Texture => "DragonsDecorativeMod/Content/Tiles/Pets/OwlStand";

        public override void SetStaticDefaults()
        {
            OwlStandHelpers.SetTileInfo(Type);
            AnimationFrameHeight = 54;
            DustType = -1;
            LocalizedText name = CreateMapEntryName();
            AddMapEntry(new Color(153, 103, 75), name);
        }

        public override IEnumerable<Item> GetItemDrops(int i, int j)
        {
            yield return new Item(ItemType<Items.Placeable.Pets.OwlStand>());
        }

        public override void NearbyEffects(int i, int j, bool closer)
        {
            OwlStandHelpers.OwlSounds(i, j, closer);
        }

        public override void AnimateTile(ref int frame, ref int frameCounter)
        {
            OwlStandHelpers.OwlAnimations(ref frame, ref frameCounter);
        }
    }
}