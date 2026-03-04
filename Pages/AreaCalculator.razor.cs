namespace Length_Calculator.Pages
{
    public partial class AreaCalculator
    {
        public string statement {  get; set; }
        public double length { get; set; }
        public double width { get; set; }
        public double area { get; set; }
        public void CalArea()
        {
            if (length == 0 && width == 0)
            {
                statement = "length and width can not be 0 ( Zero )";
            }
            else
            {
                area = length * width;
                statement = "Area of Rectangle: " + area;
            }
        }
    }
}
