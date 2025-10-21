namespace Labb2_Arv
{
    internal class Vehicle
    {
        string _brand = "Unknown";
        string _model = "Unknown";
        int _year;
        double _topSpeed;

        string Brand
        {
            get { return _brand; }
            set { _brand = value; }
        }
        string Model
        {
            get { return _model; }
            set { _model = value; }
        }
        int Year
        {
            get { return _year; }
            set { _year = value; }
        }
        double TopSpeed
        {
            get { return _topSpeed; }
            set { _topSpeed = value; }
        }
    }
}
