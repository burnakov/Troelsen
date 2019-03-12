using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericPoint
{
    struct Point<T>
    {
        private T x;
        private T y;

        public T X
        {
            get { return x; }
            set { x = value; }
        }
        public T Y
        {
            get { return y; }
            set { y = value; }
        }

        public Point(T xVal, T yVal)
        {
            x = xVal;
            y = yVal;
        }

        public void ResetPoint()
        {
            x = default(T);
            y = default(T);
        }
        public override string ToString()
        {
            return string.Format("[{0}, {1}]", x, y);
        }
    }
}
