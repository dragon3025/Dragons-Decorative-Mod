using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace DragonsDecorativeMod.Tiles.Natural
{
    public class FakeShadowOrb : ModTile
    {
        public override void SetStaticDefaults()
        {
            Main.tileFrameImportant[Type] = true;
            Main.tileNoAttach[Type] = true;
            Main.tileLavaDeath[Type] = true;
            Main.tileLighted[Type] = true;

            TileObjectData.newTile.CopyFrom(TileObjectData.Style2x2);
            TileObjectData.newTile.AnchorBottom = AnchorData.Empty;
            TileObjectData.addTile(Type);

            LocalizedText name = CreateMapEntryName();
            // name.SetDefault("Fake Shadow Orb");
            AddMapEntry(new Color(141, 120, 168), name);

            AnimationFrameHeight = 36;

            HitSound = SoundID.Shatter;
            DustType = DustID.Ebonwood;
        }

        public override void ModifyLight(int i, int j, ref float r, ref float g, ref float b)
        {
            float variance = Main.rand.Next(-5, 6) * 0.0025f;
            r = 0.31f + variance;
            g = 0.1f;
            b = 0.44f + variance * 2f;
        }

        public override void AnimateTile(ref int frame, ref int frameCounter)
        {
            frameCounter++;
            if (frameCounter >= 20)
            {
                frameCounter = 0;
                frame++;
                frame %= 2;
            }
        }

        public override IEnumerable<Item> GetItemDrops(int i, int j)
        {
            yield return new Item(ItemID.EbonstoneBlock);
        }

        public override void DrawEffects(int i, int j, SpriteBatch spriteBatch, ref TileDrawInfo drawData)
        {
            if (Main.gamePaused || !Main.instance.IsActive || Lighting.UpdateEveryFrame && !Main.rand.NextBool(4))
            {
                return;
            }

            if (Main.rand.NextBool(10))
            {
                var dust = Dust.NewDustDirect(new Vector2(i * 16, j * 16), 16, 16, DustID.Corruption);
                dust.noGravity = true;
            }
        }
    }
}