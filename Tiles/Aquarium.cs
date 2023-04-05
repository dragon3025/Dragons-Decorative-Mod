using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.ObjectData;

//TO-DO When 1.4.4 comes out for tModLoader, use the same graphic stretch affect that Terrariums have.

namespace DragonsDecorativeMod.Tiles
{
    public class Aquarium : ModTile
    {
        public override void SetStaticDefaults()
        {
            Main.tileFrameImportant[Type] = true;
            Main.tileLavaDeath[Type] = true;
            Main.tileSolidTop[Type] = true;
            Main.tileTable[Type] = true;

            TileObjectData.newTile.CopyFrom(TileObjectData.Style6x3);
            TileObjectData.newTile.DrawYOffset = 0;
            TileObjectData.addTile(Type);

            AnimationFrameHeight = 54;

            LocalizedText name = CreateMapEntryName();
            // name.SetDefault("Aquarium");
            AddMapEntry(new Color(127, 127, 255), name);
            DustType = DustID.Water;
        }

        public override void AnimateTile(ref int frame, ref int frameCounter)
        {
            frameCounter++;
            if (frameCounter >= 20)
            {
                frameCounter = 0;
                frame++;
                frame %= 22;
            }
        }

        public override void KillMultiTile(int x, int y, int frameX, int frameY)
        {
            Item.NewItem(new EntitySource_TileBreak(x, y), x * 16, y * 16, 32, 32, ModContent.ItemType<Items.Aquarium>());
        }
    }
}