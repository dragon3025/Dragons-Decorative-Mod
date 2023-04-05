using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace DragonsDecorativeMod.Tiles.Natural
{
    public class FakeCrimsonAltar : ModTile
    {
        public override void SetStaticDefaults()
        {
            Main.tileFrameImportant[Type] = true;
            Main.tileNoAttach[Type] = true;
            Main.tileLavaDeath[Type] = true;
            Main.tileLighted[Type] = true;

            TileObjectData.newTile.CopyFrom(TileObjectData.Style3x2);
            TileObjectData.newTile.DrawYOffset = 2;
            TileObjectData.addTile(Type);

            LocalizedText name = CreateMapEntryName();
            // name.SetDefault("Fake Crimson Altar");
            AddMapEntry(new Color(214, 127, 133), name);

            DustType = DustID.Crimstone;
        }

        public override void ModifyLight(int i, int j, ref float r, ref float g, ref float b)
        {
            float variance = Main.rand.Next(-5, 6) * 0.0025f;
            r = 0.5f + variance * 2f;
            g = 0.2f + variance;
            b = 0.1f;
        }

        public override void KillMultiTile(int x, int y, int frameX, int frameY)
        {
            Item.NewItem(new EntitySource_TileBreak(x, y), x * 16, y * 16, 48, 32, ItemID.CrimstoneBlock);
        }

        public override void DrawEffects(int i, int j, SpriteBatch spriteBatch, ref TileDrawInfo drawData)
        {
            if (Main.gamePaused || !Main.instance.IsActive || Lighting.UpdateEveryFrame && !Main.rand.NextBool(4))
            {
                return;
            }

            if (Main.rand.NextBool(10))
            {
                var dust = Dust.NewDustDirect(new Vector2(i * 16, j * 16), 16, 16, DustID.Crimstone);
                dust.noGravity = true;
            }
        }
    }
}