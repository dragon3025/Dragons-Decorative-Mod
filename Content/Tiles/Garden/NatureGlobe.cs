using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.ObjectData;
using static Terraria.ModLoader.ModContent;

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

        public override void NearbyEffects(int i, int j, bool closer)
        {
            if (closer)
            {
                Main.LocalPlayer.AddBuff(BuffType<Buffs.NatureGlobe>(), 15);
            }
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
            if (self.HasBuff(BuffType<Buffs.NatureGlobe>()))
            {
                self.dontHurtNature = true;
            }
        }
    }
}