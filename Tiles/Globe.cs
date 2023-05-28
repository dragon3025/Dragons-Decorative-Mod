using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace DragonsDecorativeMod.Tiles
{
    public class Globe : ModTile
    {
        public override void SetStaticDefaults()
        {
            Main.tileFrameImportant[Type] = true;
            Main.tileNoAttach[Type] = true;
            Main.tileLavaDeath[Type] = true;

            TileObjectData.newTile.CopyFrom(TileObjectData.Style2x2);
            TileObjectData.addTile(Type);

            AnimationFrameHeight = 36;

            LocalizedText name = CreateMapEntryName();
            // name.SetDefault("Globe");
            AddMapEntry(new Color(168, 145, 127), name);
        }

        public override void AnimateTile(ref int frame, ref int frameCounter)
        {
            frameCounter++;
            if (frameCounter >= 20)
            {
                frameCounter = 0;
                frame++;
                frame %= 9;
            }
        }
    }
}