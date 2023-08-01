using Terraria.ModLoader.Config;

namespace DragonsDecorativeMod.Configuration.DropDownBoxes
{
    public class Garden
    {
        [Header("BlocksAndWalls")]
        public bool Vines;
        public bool WallFlowers;
        public bool Trellis;

        [Header("Other")]
        public bool BonsaiTree;
        public bool Clover;
        public bool HangingPlants;
        public bool Mushrooms;
        public bool Planters;
        public bool Plants;
        public bool PottedPlants;

        public Garden()
        {
            Vines = true;
            WallFlowers = true;
            Trellis = true;
            BonsaiTree = true;
            Clover = true;
            HangingPlants = true;
            Mushrooms = true;
            Planters = true;
            Plants = true;
            PottedPlants = true;
        }

        public override bool Equals(object obj)
        {
            if (obj is Garden other)
                return Vines == other.Vines &&
                    WallFlowers == other.WallFlowers &&
                    Trellis == other.Trellis &&
                    Vines == other.Vines &&
                    WallFlowers == other.WallFlowers &&
                    Trellis == other.Trellis &&
                    BonsaiTree == other.BonsaiTree &&
                    Clover == other.Clover &&
                    HangingPlants == other.HangingPlants &&
                    Mushrooms == other.Mushrooms &&
                    Planters == other.Planters &&
                    Plants == other.Plants &&
                    PottedPlants == other.PottedPlants;
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return new
            {
                Vines,
                WallFlowers,
                Trellis,
                BonsaiTree,
                Clover,
                HangingPlants,
                Mushrooms,
                Planters,
                Plants,
                PottedPlants
            }.GetHashCode();
        }
    }
}
