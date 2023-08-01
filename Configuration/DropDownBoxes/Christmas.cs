namespace DragonsDecorativeMod.Configuration.DropDownBoxes
{
    public class Christmas
    {
        public bool CandyCane;
        public bool Snowman;
        public bool LightPaintable;

        public Christmas()
        {
            CandyCane = true;
            Snowman = true;
            LightPaintable = true;
        }

        public override bool Equals(object obj)
        {
            if (obj is Christmas other)
                return CandyCane == other.CandyCane &&
                    Snowman == other.Snowman &&
                    LightPaintable == other.LightPaintable;
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return new
            {
                CandyCane,
                Snowman,
                LightPaintable
            }.GetHashCode();
        }
    }
}
