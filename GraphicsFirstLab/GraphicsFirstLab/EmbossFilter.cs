using System.Drawing;

namespace Filters
{
    class EmbossFilter : MatrixFilter
    {
        public EmbossFilter()
        {
            kernel = new float[,] {
                { 0,  1,  0 },
                { 1,  0, -1 },
                { 0, -1,  0 }
            };
        }

        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            int radiusX = kernel.GetLength(0) / 2;
            int radiusY = kernel.GetLength(1) / 2;

            float resultR = 0, resultG = 0, resultB = 0;

            for (int l = -radiusY; l <= radiusY; l++)
            {
                for (int k = -radiusX; k <= radiusX; k++)
                {
                    int idX = Clamp(x + k, 0, sourceImage.Width - 1);
                    int idY = Clamp(y + l, 0, sourceImage.Height - 1);
                    Color neighborColor = sourceImage.GetPixel(idX, idY);
                    float kernelValue = kernel[k + radiusX, l + radiusY];

                    resultR += neighborColor.R * kernelValue;
                    resultG += neighborColor.G * kernelValue;
                    resultB += neighborColor.B * kernelValue;
                }
            }

            return Color.FromArgb(
                Clamp((int)(resultR + 128), 0, 255),
                Clamp((int)(resultG + 128), 0, 255),
                Clamp((int)(resultB + 128), 0, 255)
            );
        }
    }
}