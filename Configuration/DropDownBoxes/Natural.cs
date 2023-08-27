namespace DragonsDecorativeMod.Configuration.DropDownBoxes
{
    public class Natural
    {
        public bool Pots;
        public bool AltarsShadowOrbAndCrimsonHeart;
        public bool FakeLarva;
        public bool FallenLog;
        public bool PeacefulPlanteraBulb;
        public bool MysteriousTablet;

        public Natural()
        {
            Pots = true;
            AltarsShadowOrbAndCrimsonHeart = true;
            FakeLarva = true;
            FallenLog = true;
            PeacefulPlanteraBulb = true;
            MysteriousTablet = true;
        }

        public override bool Equals(object obj)
        {
            if (obj is Natural other)
                return Pots == other.Pots &&
                    AltarsShadowOrbAndCrimsonHeart == other.AltarsShadowOrbAndCrimsonHeart &&
                    FakeLarva == other.FakeLarva &&
                    FallenLog == other.FallenLog &&
                    PeacefulPlanteraBulb == other.PeacefulPlanteraBulb &&
                    MysteriousTablet == other.MysteriousTablet;
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return new
            {
                Pots,
                AltarsShadowOrbAndCrimsonHeart,
                FakeLarva,
                FallenLog,
                PeacefulPlanteraBulb,
                MysteriousTablet
            }.GetHashCode();
        }
    }
}
