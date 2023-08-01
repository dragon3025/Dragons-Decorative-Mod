namespace DragonsDecorativeMod.Configuration.DropDownBoxes
{
    public class Other
    {
        public bool Balloons;
        public bool BoxOfArrows;
        public bool PaintBottle;
        public bool Easel;
        public bool Globe;
        public bool GolfCart;
        public bool HorizontalBook;
        public bool HospitalBed;
        public bool LargeKeg;
        public bool LargePot;
        public bool Lectern;
        public bool MannequinHead;
        public bool MedusaWatching;
        public bool StaringStatue;
        public bool PaintBucket;
        public bool PureSpiritLamp;
        public bool RopeCoilPlaceable;
        public bool SkeletonModel;
        public bool ThreadPlaceable;

        public Other()
        {
            Balloons = true;
            BoxOfArrows = true;
            PaintBottle = true;
            Easel = true;
            Globe = true;
            GolfCart = true;
            HorizontalBook = true;
            HospitalBed = true;
            LargeKeg = true;
            LargePot = true;
            Lectern = true;
            MannequinHead = true;
            MedusaWatching = true;
            StaringStatue = true;
            PaintBucket = true;
            PureSpiritLamp = true;
            RopeCoilPlaceable = true;
            SkeletonModel = true;
            ThreadPlaceable = true;
        }

        public override bool Equals(object obj)
        {
            if (obj is Other other)
                return Balloons == other.Balloons &&
                    BoxOfArrows == other.BoxOfArrows &&
                    PaintBottle == other.PaintBottle &&
                    Easel == other.Easel &&
                    Globe == other.Globe &&
                    GolfCart == other.GolfCart &&
                    HorizontalBook == other.HorizontalBook &&
                    HospitalBed == other.HospitalBed &&
                    LargeKeg == other.LargeKeg &&
                    LargePot == other.LargePot &&
                    Lectern == other.Lectern &&
                    MannequinHead == other.MannequinHead &&
                    MedusaWatching == other.MedusaWatching &&
                    StaringStatue == other.StaringStatue &&
                    PaintBucket == other.PaintBucket &&
                    PureSpiritLamp == other.PureSpiritLamp &&
                    RopeCoilPlaceable == other.RopeCoilPlaceable &&
                    SkeletonModel == other.SkeletonModel &&
                    ThreadPlaceable == other.ThreadPlaceable;
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return new
            {
                Balloons,
                BoxOfArrows,
                PaintBottle,
                Easel,
                Globe,
                GolfCart,
                HorizontalBook,
                HospitalBed,
                LargeKeg,
                LargePot,
                Lectern,
                MannequinHead,
                MedusaWatching,
                StaringStatue,
                PaintBucket,
                PureSpiritLamp,
                RopeCoilPlaceable,
                SkeletonModel,
                ThreadPlaceable
            }.GetHashCode();
        }
    }
}
