using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace DragonsDecorativeMod.Tiles
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
            TileObjectData.newTile.CoordinateHeights = new int[] { 16, 16, 16 };
            TileObjectData.addTile(Type);

            AnimationFrameHeight = 54;
            DustType = DustID.Stone;

            LocalizedText name = CreateMapEntryName();
            // name.SetDefault("Ned the Nosey");
            AddMapEntry(new Color(120, 120, 120), name);

            DustType = DustID.Stone;
        }

        int look_direction = 0;

        public override void NearbyEffects(int i, int j, bool closer)
        {
            float distance = 0f;
            Vector2 position = new Vector2(i, j);
            int target = 0;
            if (closer)
            {
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
        }

        public override void AnimateTile(ref int frame, ref int frameCounter)
        {
            frame = look_direction;
        }

        public override void KillMultiTile(int x, int y, int frameX, int frameY)
        {
            Item.NewItem(new EntitySource_TileBreak(x, y), x * 16, y * 16, 32, 32, ModContent.ItemType<Items.StaringStatue>());
        }
    }
}