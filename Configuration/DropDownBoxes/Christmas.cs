namespace DragonsDecorativeMod.Configuration.DropDownBoxes
{
    public class Christmas
    {
        public bool CandyCane;
        public bool ChristmasStocking;
        public bool GingerbreadHouse;
        public bool LightPaintable;
        public bool Mistletoe;
        public bool SnowGlobe;
        public bool StarSnowGlobe;
        public bool Snowman;

        public Christmas()
        {
            CandyCane = true;
            ChristmasStocking = true;
            GingerbreadHouse = true;
            LightPaintable = true;
            Mistletoe = true;
            SnowGlobe = true;
            StarSnowGlobe = true;
            Snowman = true;
        }

        public override bool Equals(object obj)
        {
            if (obj is Christmas other)
                return CandyCane == other.CandyCane &&
                    ChristmasStocking == other.ChristmasStocking &&
                    GingerbreadHouse == other.GingerbreadHouse &&
                    LightPaintable == other.LightPaintable &&
                    Mistletoe == other.Mistletoe &&
                    SnowGlobe == other.SnowGlobe &&
                    StarSnowGlobe == other.StarSnowGlobe &&
                    Snowman == other.Snowman;
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return new
            {
                CandyCane,
                ChristmasStocking,
                GingerbreadHouse,
                LightPaintable,
                Mistletoe,
                SnowGlobe,
                StarSnowGlobe,
                Snowman
            }.GetHashCode();
        }
    }
}
