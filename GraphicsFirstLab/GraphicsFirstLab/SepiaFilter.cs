using System.Drawing;

namespace Filters
{
    class SepiaFilter : Filters
    {
        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            Color sourceColor = sourceImage.GetPixel(x, y);
            int k = 30; // коэффициент для сепии
            int intensity = (int)(0.36 * sourceColor.R + 0.53 * sourceColor.G + 0.11 * sourceColor.B);

            int R = Clamp(intensity + 2 * k, 0, 255);
            int G = Clamp(intensity + (int)(0.5 * k), 0, 255);
            int B = Clamp(intensity - 1 * k, 0, 255);

            return Color.FromArgb(R, G, B);
        }
    }
}