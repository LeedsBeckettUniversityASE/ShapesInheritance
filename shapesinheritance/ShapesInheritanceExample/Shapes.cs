using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesInheritanceExample
{
    interface Shapes
    {
        void draw(Graphics g);
        void set(Color c, params int[] list);
    }
}
