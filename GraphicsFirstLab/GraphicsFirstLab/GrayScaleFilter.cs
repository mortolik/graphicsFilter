using System.Drawing;

namespace Filters
{
    class GrayScaleFilter : Filters
    {
        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            Color sourceColor = sourceImage.GetPixel(x, y);
            int intensity = (int)(0.36 * sourceColor.R + 0.53 * sourceColor.G + 0.11 * sourceColor.B);
            intensity = Clamp(intensity, 0, 255);
            return Color.FromArgb(intensity, intensity, intensity);
        }
    }
}