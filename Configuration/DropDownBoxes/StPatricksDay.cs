namespace DragonsDecorativeMod.Configuration.DropDownBoxes
{
    public class StPatricksDay
    {
        public bool CloverDecal;
        public bool PaintingLuringToGold;

        public StPatricksDay()
        {
            CloverDecal = true;
            PaintingLuringToGold = true;
        }

        public override bool Equals(object obj)
        {
            if (obj is StPatricksDay other)
                return CloverDecal == other.CloverDecal &&
                    PaintingLuringToGold == other.PaintingLuringToGold;
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return new
            {
                CloverDecal,
                PaintingLuringToGold
            }.GetHashCode();
        }
    }
}
