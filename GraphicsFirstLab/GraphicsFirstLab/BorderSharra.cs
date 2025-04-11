using Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CG
{
    class BorderSharra : MatrixFilter
    {
        public BorderSharra(bool horizontal)
        {
            kernel = new float[3, 3];
            if (horizontal)
            {
                kernel[0, 0] = 3; kernel[0, 1] = 0; kernel[0, 2] = -3;
                kernel[1, 0] = 10; kernel[1, 1] = 0; kernel[1, 2] = -10;
                kernel[2, 0] = 3; kernel[2, 1] = 0; kernel[2, 2] = -3;
            }
            else
            {
                kernel[0, 0] = 3; kernel[0, 1] = 10; kernel[0, 2] = 3;
                kernel[1, 0] = 0; kernel[1, 1] = 0; kernel[1, 2] = 0;
                kernel[2, 0] = -3; kernel[2, 1] = -10; kernel[2, 2] = -3;
            }
        }
    }
}