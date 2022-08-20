using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Audio;
using Terraria.ID;
using Terraria.ModLoader;

namespace DragonsDecorativeMod.Projectiles
{
    public class MoonGlobe : ModProjectile
    {
        public override void SetDefaults()
        {
            Projectile.width = 18;
            Projectile.height = 18;
            Projectile.aiStyle = 2;
            Projectile.friendly = true;
            Projectile.penetrate = 1;
        }

        public override void Kill(int timeLeft)
        {
            SoundEngine.PlaySound(SoundID.Item107, Projectile.position);
            int num12;
            for (int num378 = 0; num378 < 15; num378 = num12 + 1)
            {
                Dust.NewDust(Projectile.position, Projectile.width, Projectile.height, DustID.Glass, 0f, -2f, 0, default(Color), 1.5f);
                num12 = num378;
            }
            if (Main.netMode != NetmodeID.MultiplayerClient)
            {
                Main.moonType = Main.rand.Next(9);
                NetMessage.SendData(MessageID.WorldData);
            }
        }
    }
}