using System;
using System.Drawing;
using System.ComponentModel;

namespace Filters
{
    class Waves2 : Filters
    {
        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            int newX = x;
            int newY = (int)(y + 20 * Math.Sin(2 * Math.PI * x / 30));  // Улучшенная формула

            // Ограничиваем координаты
            newX = Clamp(newX, 0, sourceImage.Width - 1);
            newY = Clamp(newY, 0, sourceImage.Height - 1);

            return sourceImage.GetPixel(newX, newY);
        }
    }
}