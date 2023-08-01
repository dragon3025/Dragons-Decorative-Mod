namespace DragonsDecorativeMod.Configuration.DropDownBoxes
{
    public class Pets
    {
        public bool Aquarium;
        public bool OwlStand;

        public Pets()
        {
            Aquarium = true;
            OwlStand = true;
        }

        public override bool Equals(object obj)
        {
            if (obj is Pets other)
                return Aquarium == other.Aquarium &&
                    OwlStand == other.OwlStand;
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return new
            {
                Aquarium,
                OwlStand
            }.GetHashCode();
        }
    }
}
