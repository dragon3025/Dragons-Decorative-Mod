namespace DragonsDecorativeMod.Configuration.DropDownBoxes
{
    public class Signs
    {
        public bool SignBag;
        public bool SignBook;
        public bool SignCross;
        public bool SignSwiss;
        public bool SignHeart;

        public Signs()
        {

            SignBag = true;
            SignBook = true;
            SignCross = true;
            SignSwiss = true;
            SignHeart = true;
        }

        public override bool Equals(object obj)
        {
            if (obj is Signs other)
                return SignBag == other.SignBag &&
                    SignBook == other.SignBook &&
                    SignCross == other.SignCross &&
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
                SignCross,
                SignSwiss,
                SignHeart
            }.GetHashCode();
        }
    }
}
