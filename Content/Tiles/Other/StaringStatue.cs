using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace DragonsDecorativeMod.Content.Tiles.Other
{
    public class StaringStatue : ModTile
    {
        public override void SetStaticDefaults()
        {
            Main.tileFrameImportant[Type] = true;
            Main.tileNoAttach[Type] = true;
            Main.tileLavaDeath[Type] = true;

            TileObjectData.newTile.CopyFrom(TileObjectData.Style2x2);
            TileObjectData.newTile.Height = 3;
            TileObjectData.newTile.CoordinateHeights = [16, 16, 16];
            TileObjectData.addTile(Type);

            AnimationFrameHeight = 54;

            LocalizedText name = CreateMapEntryName();
            AddMapEntry(new Color(120, 120, 120), name);

            DustType = DustID.Stone;
        }

        private int look_direction = 0;

        public override void NearbyEffects(int i, int j, bool closer)
        {
            if (!closer)
            {
                return;
            }

            float distance = 0f;
            Vector2 position = new(i, j);
            int target = 0;
            for (int k = 0; k < 255; k++)
            {
                if (!Main.player[k].active)
                {
                    continue;
                }

                if (distance == 0f || position.Distance(Main.player[k].Center) < distance)
                {
                    distance = position.Distance(Main.player[k].Center);
                    target = k;
                }
            }

            Player player = Main.player[target];
            float tile_centerx = 1f;
            float tile_centery = 1.5f;
            if (player.position.X / 16 > i - tile_centerx + 6.5f)
            {
                look_direction = 1;
            }
            else if (player.position.X / 16 < i - tile_centerx - 6.5f)
            {
                look_direction = 2;
            }
            else
            {
                look_direction = 0;
            }

            if (player.position.Y / 16 > j - tile_centery + 6.5f)
            {
                look_direction += 6;
            }
            else if (player.position.Y / 16 < j - tile_centery - 6.5f)
            {
                look_direction += 3;
            }
        }

        public override void AnimateTile(ref int frame, ref int frameCounter)
        {
            frame = look_direction;
        }
    }
}