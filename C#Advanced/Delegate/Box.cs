
namespace Delegate
{
    public class Box
    {
        private double _length;
        private double _breadth;
        private double _height;

        public double GetVolume()
        {
            return _breadth * _length * _height;
        }

        public void SetLength(double len)
        {
            _length = len;
        }

        public void Setbreadth(double bre)
        {
            _breadth = bre;
        }

        public void SetHeight(double hei)
        {
            _height = hei;
        }

        // Overload + operator to add two Box objects.

        public static Box operator +(Box b, Box c)
        {
            Box box = new Box
            {
                _breadth = b._breadth + c._breadth,
                _height = b._height + c._height,
                _length = b._length + c._length
            };

            return box;
        }

        public static bool operator ==(Box lhs, Box rhs)
        {
            bool status = lhs._length == rhs._length && lhs._height == rhs._height
                && lhs._breadth == rhs._breadth;
            return status;
        }

        public static bool operator !=(Box lhs, Box rhs)
        {
            bool status = lhs._length != rhs._length || lhs._height != rhs._height ||
                lhs._breadth != rhs._breadth;
            return status;
        }


        public override string ToString()
        {
            return string.Format("({0}, {1}, {2})", _length, _breadth, _height);
        }
    }
}