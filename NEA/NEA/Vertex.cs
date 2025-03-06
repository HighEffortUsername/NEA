using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEA
{
    internal class Vertex
    {
        private readonly Form1 _form1;//Passes the form into the class, letting it access the text boxes.
        float x;
        float y;
        float z;
        public Vertex(float newx, float newy, float newz)
        {
            _form1 = form1;
            x = newx;
            y = newy;
            z = newz;
        }
        public float GetX(float x)
        {
            float output = x;
            return output;
        }
        public float GetY(float y)
        {
            float output = y;
            return output;
        }
        public float GetZ(float z)
        {
            float output = z;
            return output;
        }
    }
}
