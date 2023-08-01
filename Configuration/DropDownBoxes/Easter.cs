namespace DragonsDecorativeMod.Configuration.DropDownBoxes
{
    public class Easter
    {
        public bool EasterBasket;
        public bool EasterEggs;

        public Easter()
        {
            EasterBasket = true;
            EasterEggs = true;
        }

        public override bool Equals(object obj)
        {
            if (obj is Easter other)
                return EasterBasket == other.EasterBasket &&
                    EasterEggs == other.EasterEggs;
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return new
            {
                EasterBasket,
                EasterEggs
            }.GetHashCode();
        }
    }
}
