using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceHierarchy
{
    interface IAdvancedDraw : IDrawable
    {
        void DrawInBoundingBox(int top, int bottom, int left, int right);
        void DrawUpsideDown();
    }
}
