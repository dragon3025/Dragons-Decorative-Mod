using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace DragonsDecorativeMod.Content.Tiles.Garden
{
    public class NatureGlobe : ModTile
    {
        public override void SetStaticDefaults()
        {
            Main.tileFrameImportant[Type] = true;
            Main.tileNoAttach[Type] = true;
            Main.tileLavaDeath[Type] = true;

            TileObjectData.newTile.CopyFrom(TileObjectData.GetTileData(TileID.FishBowl, 0));
            TileObjectData.addTile(Type);

            LocalizedText name = CreateMapEntryName();
            AddMapEntry(new Color(130, 147, 150), name);

            DustType = DustID.Glass;
            HitSound = SoundID.Shatter;
        }

        public override void Load()
        {
            On_Player.RefreshMechanicalAccsFromItemType += On_Player_RefreshMechanicalAccsFromItemType;
        }

        private void On_Player_RefreshMechanicalAccsFromItemType(On_Player.orig_RefreshMechanicalAccsFromItemType orig, Player self, int accType)
        {
            orig(self, accType);
            if (self.dontHurtNature)
            {
                return;
            }

            Point position = self.position.ToTileCoordinates();
            int x_distance = 169 / 2;
            int y_distance = 124 / 2;
            for (int x = position.X - x_distance; x <= position.X + x_distance; x++)
            {
                for (int y = position.Y - y_distance; y <= position.Y + y_distance; y++)
                {
                    Tile tile = Framing.GetTileSafely(x, y);
                    if (!tile.HasTile)
                    {
                        continue;
                    }

                    if (tile.TileType == Type)
                    {
                        self.dontHurtNature = true;
                        return;
                    }
                }
            }
        }
    }
}