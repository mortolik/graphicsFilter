using System.Drawing;

namespace Filters
{
    class SobelFilter : MatrixFilter
    {
        public SobelFilter(bool horizontal)
        {
            kernel = new float[3, 3];
            if (horizontal)
            {
                // Горизонтальное ядро Собеля
                kernel[0, 0] = -1; kernel[0, 1] = 0; kernel[0, 2] = 1;
                kernel[1, 0] = -2; kernel[1, 1] = 0; kernel[1, 2] = 2;
                kernel[2, 0] = -1; kernel[2, 1] = 0; kernel[2, 2] = 1;
            }
            else
            {
                // Вертикальное ядро Собеля
                kernel[0, 0] = -1; kernel[0, 1] = -2; kernel[0, 2] = -1;
                kernel[1, 0] = 0; kernel[1, 1] = 0; kernel[1, 2] = 0;
                kernel[2, 0] = 1; kernel[2, 1] = 2; kernel[2, 2] = 1;
            }
        }
    }
}