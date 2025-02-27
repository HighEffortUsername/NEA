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
        int x;
        int y;
        int z;
        public Vertex(Form1 form1)
        {
            _form1 = form1;
            x = Convert.ToInt32(form1.textBox1.Text);
            y = Convert.ToInt32(form1.textBox2.Text);
            z = Convert.ToInt32(form1.textBox3.Text);
        }
        public int GetX(int x)
        {
            int output = x;
            return output;
        }
        public int GetY(int y)
        {
            int output = y;
            return output;
        }
        public int GetZ(int z)
        {
            int output = z;
            return output;
        }
    }
}
