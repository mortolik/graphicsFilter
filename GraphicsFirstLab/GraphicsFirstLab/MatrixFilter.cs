﻿using System.Drawing;

namespace Filters
{
    class MatrixFilter : Filters
    {
        protected float[,] kernel = null;

        protected MatrixFilter() { }

        public MatrixFilter(float[,] kernel)
        {
            this.kernel = kernel;
        }

        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            int radiusX = kernel.GetLength(0) / 2;
            int radiusY = kernel.GetLength(1) / 2;

            float resultR = 0;
            float resultG = 0;
            float resultB = 0;

            for (int l = -radiusY; l <= radiusY; l++)
            {
                for (int k = -radiusX; k <= radiusX; k++)
                {
                    int idX = Clamp(x + k, 0, sourceImage.Width - 1);
                    int idY = Clamp(y + l, 0, sourceImage.Height - 1);
                    Color neighborColor = sourceImage.GetPixel(idX, idY);

                    int kernelX = k + radiusX;
                    int kernelY = l + radiusY;

                    if (kernelX >= 0 && kernelX < kernel.GetLength(0) &&
                        kernelY >= 0 && kernelY < kernel.GetLength(1))
                    {
                        resultR += neighborColor.R * kernel[kernelX, kernelY];
                        resultG += neighborColor.G * kernel[kernelX, kernelY];
                        resultB += neighborColor.B * kernel[kernelX, kernelY];
                    }
                }
            }

            return Color.FromArgb(
                Clamp((int)resultR, 0, 255),
                Clamp((int)resultG, 0, 255),
                Clamp((int)resultB, 0, 255)
            );
        }
    }
}