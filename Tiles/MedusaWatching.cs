﻿using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace DragonsDecorativeMod.Tiles
{
    public class MedusaWatching : ModTile
    {
        public override void SetStaticDefaults()
        {
            Main.tileFrameImportant[Type] = true;
            Main.tileNoAttach[Type] = true;
            Main.tileLavaDeath[Type] = true;
            TileID.Sets.FramesOnKillWall[Type] = true;

            TileObjectData.newTile.CopyFrom(TileObjectData.Style3x3Wall);
            TileObjectData.newTile.Height = 4;
            TileObjectData.newTile.CoordinateHeights = new int[] { 16, 16, 16, 16 };
            TileObjectData.addTile(Type);

            AnimationFrameHeight = 72;

            LocalizedText name = CreateMapEntryName();
            // name.SetDefault("Medusa Watching");
            AddMapEntry(new Color(58, 62, 53), name);

            DustType = DustID.WoodFurniture;
        }

        int look_direction = 0;

        public override void NearbyEffects(int i, int j, bool closer)
        {
            if (closer)
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
                    float tile_centerx = 1.5f;
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
                }
            }
        }

        public override void AnimateTile(ref int frame, ref int frameCounter)
        {
            frame = look_direction;
        }
    }
}