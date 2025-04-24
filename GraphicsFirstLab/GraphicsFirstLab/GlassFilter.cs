using System;
using System.Drawing;
using System.ComponentModel;

namespace Filters
{
    class GlassFilter : Filters
    {
        private Random rand = new Random();

        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            // Генерируем случайное смещение в диапазоне [-5, 5]
            int newX = (int)(x + (rand.NextDouble() - 0.5) * 10);
            int newY = (int)(y + (rand.NextDouble() - 0.5) * 10);

            newX = Clamp(newX, 0, sourceImage.Width - 1);
            newY = Clamp(newY, 0, sourceImage.Height - 1);

            return sourceImage.GetPixel(newX, newY);
        }
    }
}