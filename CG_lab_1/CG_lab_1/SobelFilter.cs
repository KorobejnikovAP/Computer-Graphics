using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CG_lab_1
{
    class SobelFilter : MatrixFilter
    {
        public SobelFilter()
        {
            //kernel = new float[3, 3] { { -1, -2, -1 }, { 0, 0, 0 }, { 1, 2, 1 } };
            kernel = new float[3, 3] { { -1, 0, 1 }, { -2, 0, 2 }, { -1, 0, 1 } };
        }
    }
}
