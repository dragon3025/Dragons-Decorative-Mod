using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;
using Terraria.DataStructures;

namespace DragonsDecorativeMod.Tiles.Natural
{
    public class PeacefulPlanteraBulb : ModTile
    {
        public override void SetStaticDefaults()
        {
            //TO-DO Make this tile emit DustID.PlanteraBulb particles. From the vanilla code:

            /*private void DrawTiles_EmitParticles(int j, int i, Tile tileCache, ushort typeCache, short tileFrameX, short tileFrameY, Color tileLight)
			{
				switch (typeCache)
				{
					case 238:
						if (_rand.Next(10) == 0)
						{
							int num = Dust.NewDust(new Vector2(i * 16, j * 16), 16, 16, 168);
							_dust[num].noGravity = true;
							_dust[num].alpha = 200;
						}
						break;*/

            Main.tileFrameImportant[Type] = true;
            Main.tileNoAttach[Type] = true;
            Main.tileLavaDeath[Type] = true;
            Main.tileLighted[Type] = true;
            TileObjectData.newTile.CopyFrom(TileObjectData.Style2x2);
            TileObjectData.newTile.DrawYOffset = 2;
            TileObjectData.newTile.AnchorValidTiles = new int[] { TileID.JungleGrass };
            TileObjectData.addTile(Type);
            AnimationFrameHeight = 36;
            ModTranslation name = CreateMapEntryName();
            name.SetDefault("Peaceful Plantera Bulb");
            AddMapEntry(new Color(225, 128, 206), name);
            DustType = DustID.Plantera_Pink;
        }

        public override void AnimateTile(ref int frame, ref int frameCounter)
        {
            frameCounter++;
            if (frameCounter >= 20)
            {
                frameCounter = 0;
                frame++;
                frame %= 4;
            }
        }

        public override void ModifyLight(int i, int j, ref float r, ref float g, ref float b)
        {
            r = 0.5f;
            g = 0f;
            b = 0.5f;
        }

        public override void KillMultiTile(int x, int y, int frameX, int frameY)
        {
            Item.NewItem(new EntitySource_TileBreak(x, y), x * 16, y * 16, 32, 32, ModContent.ItemType<Items.Natural.PeacefulPlanteraBulb>());
        }
    }
}