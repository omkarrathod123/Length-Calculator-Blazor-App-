namespace Length_Calculator.Pages
{
    public partial class Home
    {
        double centimeter = new double();
        double millimeter = new double();
        double foot = new double();
        double inch = new double();
        double kilomete = new double();
        public double CentimeterConvoter
        {
            get
            {
                return centimeter;
            }
            set
            {
                millimeter = value * 10;
                foot = value * 0.032;
                inch = value * 0.393;
                kilomete = value / 100000;
                centimeter = value;
            }
        }
        public double MillimeterConvoter
        {
            get
            {
                return millimeter;
            }
            set
            {
                centimeter = value * 0.1;
                foot = value * 0.003;
                inch = value * 0.039;
                kilomete = value * 1000000;
                millimeter = value;
            }
        }
        public double FootConvoter
        {
            get
            {
                return foot;
            }
            set
            {
                centimeter = value * 30.48;
                millimeter = value * 304;
                inch = value * 12;
                kilomete = value * 0.00030;
                foot = value;
            }
        }
        public double InchConvoter
        {
            get
            {
                return inch;
            }
            set
            {
                centimeter = value * 2.54;
                millimeter = 25.4;
                foot = value * 0.083;
                kilomete = value * 0.000254;
                inch = value;
            }
        }
        public double KilometerConvoter
        {
            get
            {
                return kilomete;
            }
            set
            {
                centimeter = value * 100000;
                foot = value * 3280.83;
                inch = value * 39370;
                millimeter = value * 1000000;
                kilomete = value;
            }
        }
    }
}
