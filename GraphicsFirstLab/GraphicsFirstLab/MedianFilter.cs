using System;
using System.Drawing;
using System.Collections.Generic;

namespace Filters
{
    class MedianFilter : Filters
    {
        private int radius;

        public MedianFilter(int radius = 1)
        {
            this.radius = radius;
        }

        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            List<int> R = new List<int>();
            List<int> G = new List<int>();
            List<int> B = new List<int>();

            for (int l = -radius; l <= radius; l++)
            {
                for (int k = -radius; k <= radius; k++)
                {
                    int idX = Clamp(x + k, 0, sourceImage.Width - 1);
                    int idY = Clamp(y + l, 0, sourceImage.Height - 1);
                    Color neighborColor = sourceImage.GetPixel(idX, idY);

                    R.Add(neighborColor.R);
                    G.Add(neighborColor.G);
                    B.Add(neighborColor.B);
                }
            }

            R.Sort(); G.Sort(); B.Sort();
            int medianIndex = R.Count / 2;

            return Color.FromArgb(
                R[medianIndex],
                G[medianIndex],
                B[medianIndex]
            );
        }
    }
}