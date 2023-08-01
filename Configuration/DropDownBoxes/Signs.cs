namespace DragonsDecorativeMod.Configuration.DropDownBoxes
{
    public class Signs
    {
        public bool SignBag;
        public bool SignBook;
        public bool SignGreenCross;
        public bool SignSwiss;
        public bool SignHeart;

        public Signs()
        {

            SignBag = true;
            SignBook = true;
            SignGreenCross = true;
            SignSwiss = true;
            SignHeart = true;
        }

        public override bool Equals(object obj)
        {
            if (obj is Signs other)
                return SignBag == other.SignBag &&
                    SignBook == other.SignBook &&
                    SignGreenCross == other.SignGreenCross &&
                    SignSwiss == other.SignSwiss &&
                    SignHeart == other.SignHeart;
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return new
            {
                SignBag,
                SignBook,
                SignGreenCross,
                SignSwiss,
                SignHeart
            }.GetHashCode();
        }
    }
}
